using SQLiteManager;
using System.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarsDatabase
{
    public partial class frmCars : Form
    {
        public static SQLiteManager.SQLiteManager sqliteManager = new SQLiteManager.SQLiteManager();
        List<Car> cars = new List<Car>();
        frmSearch frmSearch = new frmSearch();

        
        const string DB_FILE_NAME = @"C:\Users\golub\OneDrive\Desktop\CarsDatabase\Hire.db";
        int currentIndex;

        public frmCars()
        {
            InitializeComponent();
        }

        private void frmCars_Load(object sender, EventArgs e)
        {
            sqliteManager.DBFileName = DB_FILE_NAME;
            LoadCars();
            currentIndex = 0;
            DisplayCurrentCar();
        }

        private void LoadCars()
        {
            string SQLRead = "SELECT * FROM tblCar";
            DataTable dataTable = sqliteManager.ReadData(SQLRead);
            cars.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                Car car = new Car();
                car.ID = Convert.ToInt32(row["ID"]);
                car.VehicleRegNo = Convert.ToString(row["VehicleRegNo"]);
                car.Make = Convert.ToString(row["Make"]);
                car.EngineSize = Convert.ToString(row["EngineSize"]);
                car.DateRegistered = Convert.ToDateTime(row["DateRegistered"]);
                car.RentalPerDay = Convert.ToDouble(row["RentalPerDay"]);
                car.Available = row["Available"].ToString().ToLower() == "true" || row["Available"].ToString() == "1";
                car.Mileage = row["Mileage"] != DBNull.Value ? Convert.ToInt32(row["Mileage"]) : 0;
                car.InsuranceType = row["InsuranceType"] != DBNull.Value ? Convert.ToString(row["InsuranceType"]) : "Basic";

                cars.Add(car);
            }
        }

        private void DisplayCurrentCar()
        {
            if (cars.Count == 0) return;

            Car currentCar = cars[currentIndex];

            txtVehicleRegNo.Text = currentCar.VehicleRegNo;
            txtMake.Text = currentCar.Make;
            txtEngineSize.Text = currentCar.EngineSize;
            dtpDateRegistered.Text = currentCar.DateRegistered.ToString();
            txtRentalPerDay.Text = "£" + currentCar.RentalPerDay.ToString("F2");
            chkAvailable.Checked = currentCar.Available;
            txtMileage.Text = currentCar.Mileage.ToString();
            txtInsuranceType.Text = currentCar.InsuranceType;

            int currentCarNumber = currentIndex + 1;
            int numberCars = cars.Count;
            lblRecordCount.Text = $"{currentCarNumber} of {numberCars}";

            btnPrevious.Enabled = (currentIndex > 0);
            btnFirst.Enabled = (currentIndex > 0);
            btnLast.Enabled = (currentIndex < numberCars - 1);
            btnNext.Enabled = (currentIndex < numberCars - 1);

            btnUpdate.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnSearch.Enabled = true;
            btnCancel.Enabled = true;
            btnExit.Enabled = true;
        }

        private void btnPrevious_Click(object sender, EventArgs e) { currentIndex--; DisplayCurrentCar(); }
        private void btnNext_Click(object sender, EventArgs e) { currentIndex++; DisplayCurrentCar(); }
        private void btnFirst_Click(object sender, EventArgs e) { currentIndex = 0; DisplayCurrentCar(); }
        private void btnLast_Click(object sender, EventArgs e) { currentIndex = cars.Count - 1; DisplayCurrentCar(); }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVehicleRegNo.Text) ||
                string.IsNullOrWhiteSpace(txtMake.Text) ||
                string.IsNullOrWhiteSpace(txtEngineSize.Text) ||
                string.IsNullOrWhiteSpace(txtRentalPerDay.Text) ||
                string.IsNullOrWhiteSpace(txtMileage.Text) ||
                string.IsNullOrWhiteSpace(txtInsuranceType.Text))
            {
                MessageBox.Show("Please fill in all key fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cleanPrice = txtRentalPerDay.Text.Replace("£", "").Trim();
            if (!double.TryParse(cleanPrice, out double parsedPrice))
            {
                MessageBox.Show("Please enter a valid number for Rental Per Day.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtMileage.Text, out int parsedMileage))
            {
                MessageBox.Show("Please enter a valid number for Mileage.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentIndex >= 0) { UpdateCurrentRecord(); } else { SaveNewRecord(); }

            LoadCars();
            if (currentIndex == -1) { currentIndex = cars.Count - 1; }
            DisplayCurrentCar();
        }

        private void SaveNewRecord()
        {
            string cleanPrice = txtRentalPerDay.Text.Replace("£", "").Trim();
            string SQLInsert = $"INSERT INTO tblCar (VehicleRegNo, Make, EngineSize, DateRegistered, RentalPerDay, Available, Mileage, InsuranceType) VALUES (" +
                $"'{txtVehicleRegNo.Text}', '{txtMake.Text}', '{txtEngineSize.Text}', '{dtpDateRegistered.Text}', '{cleanPrice}', '{chkAvailable.Checked.ToString().ToLower()}', {txtMileage.Text}, '{txtInsuranceType.Text}')";
            sqliteManager.AddNewRecord(SQLInsert);
        }

        private void UpdateCurrentRecord()
        {
            Car currentCar = cars[currentIndex];
            string cleanPrice = txtRentalPerDay.Text.Replace("£", "").Trim();
            string SQLUpdate = $"UPDATE tblCar SET VehicleRegNo = '{txtVehicleRegNo.Text}', Make = '{txtMake.Text}', EngineSize = '{txtEngineSize.Text}', DateRegistered = '{dtpDateRegistered.Text}', RentalPerDay = '{cleanPrice}', Available = '{chkAvailable.Checked.ToString().ToLower()}', Mileage = {txtMileage.Text}, InsuranceType = '{txtInsuranceType.Text}' WHERE ID = {currentCar.ID}";
            sqliteManager.UpdateRecord(SQLUpdate);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currentIndex = -1;
            txtVehicleRegNo.Clear();
            txtMake.Clear();
            txtEngineSize.Clear();
            dtpDateRegistered.Text = "";
            txtRentalPerDay.Clear();
            chkAvailable.Checked = false;
            txtMileage.Clear();
            txtInsuranceType.Clear();

            txtVehicleRegNo.Focus();
            btnAdd.Enabled = false; btnDelete.Enabled = false; btnSearch.Enabled = false; btnExit.Enabled = false;
            btnFirst.Enabled = false; btnPrevious.Enabled = false; btnNext.Enabled = false; btnLast.Enabled = false;
            lblRecordCount.Text = "Adding a new record";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0) { DisplayCurrentCar(); } else { currentIndex = 0; DisplayCurrentCar(); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this car?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Car currentCar = cars[currentIndex];
                if (sqliteManager.DeleteRecord(currentCar.ID, "tblCar")) { MessageBox.Show("Record Deleted"); }
                LoadCars();
                if (cars.Count > 0) { currentIndex = 0; DisplayCurrentCar(); } else { btnAdd_Click(sender, e); }
            }
        }

        private void btnExit_Click(object sender, EventArgs e) { Application.Exit(); }

        private void frmCars_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult reply = MessageBox.Show("Do you wish to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reply == DialogResult.No) { e.Cancel = true; }
        }

        private void btnSearch_Click(object sender, EventArgs e) { frmSearch.Show(); }
    }
}