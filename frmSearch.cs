using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLiteManager;

namespace CarsDatabase
{
    public partial class frmSearch : Form
    {

        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            // LOAD THE COMBO BOX WITH DATABASE FIELD NAMES
            cboField.Items.Clear();
            cboField.Items.Add("VehicleRegNo");
            cboField.Items.Add("Make");
            cboField.Items.Add("EngineSize");
            cboField.Items.Add("DateRegistered");
            cboField.Items.Add("RentalPerDay");
            cboField.Items.Add("Available");
            cboField.Items.Add("Mileage");
            cboField.Items.Add("InsuranceType");

            // Populate the cboOperator combo box with comparison operators
            cboOperator.Items.Clear();
            cboOperator.Items.Add("=");
            cboOperator.Items.Add("<");
            cboOperator.Items.Add(">");
            cboOperator.Items.Add("<=");
            cboOperator.Items.Add(">=");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Hide the search form and return to the main form (frmCars)
            this.Hide();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // Ensure all details have been entered
            if (cboField.Text == "" || cboOperator.Text == "" || txtValue.Text == "")
            {
                MessageBox.Show("Please select a field, operator and enter a value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Construct the SQLRead statement
            string SQLRead = $"SELECT * FROM tblCar WHERE {cboField.Text} {cboOperator.Text} '{txtValue.Text}'";

            // Note this uses the sqliteManager from frmCars
            dgvCars.DataSource = frmCars.sqliteManager.ReadData(SQLRead);

            // ====================================================
            // Code to display Available as a CheckBox and format prices

            if (dgvCars.Rows.Count > 0)  // if records found
            {
                // Remove the hidden ID column (usually it's at index 0)
                if (dgvCars.Columns.Contains("ID"))
                {
                    dgvCars.Columns.Remove("ID");
                }

                // Format the RentalPerDay column to show the pound symbol (£)
                if (dgvCars.Columns.Contains("RentalPerDay"))
                {
                    dgvCars.Columns["RentalPerDay"].DefaultCellStyle.Format = "'£'0.00";
                }
                if (dgvCars.Columns.Contains("DateRegistered"))
                {
                    dgvCars.Columns["DateRegistered"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                // Create the new CheckBox column for Available
                if (dgvCars.Columns.Contains("Available"))
                {
                    DataGridViewCheckBoxColumn checkCol = new DataGridViewCheckBoxColumn();
                    checkCol.Name = "AvailableChk";
                    checkCol.DataPropertyName = "Available"; // Map to the DataTable field
                    checkCol.HeaderText = "Available";
                    checkCol.TrueValue = "true";
                    checkCol.FalseValue = "false";
                    checkCol.ValueType = typeof(string);

                    // Swap the old text column with the new checkbox column
                    int columnIndex = dgvCars.Columns["Available"].Index;
                    dgvCars.Columns.RemoveAt(columnIndex);
                    dgvCars.Columns.Insert(columnIndex, checkCol);
                }
            }
            
        }
    }
}
