namespace CarsDatabase
{
    partial class frmCars
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtVehicleRegNo = new TextBox();
            label2 = new Label();
            txtMake = new TextBox();
            label3 = new Label();
            txtEngineSize = new TextBox();
            label4 = new Label();
            txtRentalPerDay = new TextBox();
            label5 = new Label();
            dtpDateRegistered = new DateTimePicker();
            chkAvailable = new CheckBox();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            btnFirst = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            lblRecordCount = new Label();
            label6 = new Label();
            label7 = new Label();
            toolTip1 = new ToolTip(components);
            txtMileage = new TextBox();
            label8 = new Label();
            txtInsuranceType = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(534, 64);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(310, 41);
            label1.TabIndex = 27;
            label1.Text = "AutoFleet Manager";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtVehicleRegNo
            // 
            txtVehicleRegNo.Location = new Point(453, 169);
            txtVehicleRegNo.Margin = new Padding(4);
            txtVehicleRegNo.Name = "txtVehicleRegNo";
            txtVehicleRegNo.Size = new Size(152, 39);
            txtVehicleRegNo.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 169);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(309, 32);
            label2.TabIndex = 19;
            label2.Text = "Vehicle registration number";
            // 
            // txtMake
            // 
            txtMake.Location = new Point(453, 232);
            txtMake.Margin = new Padding(4);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(130, 39);
            txtMake.TabIndex = 1;
            toolTip1.SetToolTip(txtMake, "Enter the make of the vehicle");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 232);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 32);
            label3.TabIndex = 20;
            label3.Text = "Make";
            // 
            // txtEngineSize
            // 
            txtEngineSize.Location = new Point(453, 289);
            txtEngineSize.Margin = new Padding(4);
            txtEngineSize.Name = "txtEngineSize";
            txtEngineSize.Size = new Size(77, 39);
            txtEngineSize.TabIndex = 2;
            toolTip1.SetToolTip(txtEngineSize, "Enter the engine size");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 289);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(134, 32);
            label4.TabIndex = 21;
            label4.Text = "Engine size";
            // 
            // txtRentalPerDay
            // 
            txtRentalPerDay.Location = new Point(453, 399);
            txtRentalPerDay.Margin = new Padding(4);
            txtRentalPerDay.Name = "txtRentalPerDay";
            txtRentalPerDay.Size = new Size(94, 39);
            txtRentalPerDay.TabIndex = 4;
            toolTip1.SetToolTip(txtRentalPerDay, "Enter the daily rental price");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 399);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(167, 32);
            label5.TabIndex = 23;
            label5.Text = "Rental per day";
            // 
            // dtpDateRegistered
            // 
            dtpDateRegistered.CustomFormat = "dd/MM/yyyy";
            dtpDateRegistered.Format = DateTimePickerFormat.Custom;
            dtpDateRegistered.Location = new Point(453, 346);
            dtpDateRegistered.Margin = new Padding(4);
            dtpDateRegistered.Name = "dtpDateRegistered";
            dtpDateRegistered.Size = new Size(203, 39);
            dtpDateRegistered.TabIndex = 3;
            // 
            // chkAvailable
            // 
            chkAvailable.AutoSize = true;
            chkAvailable.Location = new Point(453, 454);
            chkAvailable.Margin = new Padding(4);
            chkAvailable.Name = "chkAvailable";
            chkAvailable.Size = new Size(22, 21);
            chkAvailable.TabIndex = 5;
            chkAvailable.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(793, 154);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(105, 54);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(793, 221);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 54);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(793, 289);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 54);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(793, 360);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(105, 54);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(793, 432);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 54);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(793, 503);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(105, 54);
            btnExit.TabIndex = 13;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(139, 652);
            btnFirst.Margin = new Padding(4);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(116, 50);
            btnFirst.TabIndex = 14;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(270, 652);
            btnPrevious.Margin = new Padding(4);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(116, 50);
            btnPrevious.TabIndex = 15;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(731, 652);
            btnNext.Margin = new Padding(4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(116, 50);
            btnNext.TabIndex = 17;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.Location = new Point(867, 652);
            btnLast.Margin = new Padding(4);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(116, 50);
            btnLast.TabIndex = 18;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // lblRecordCount
            // 
            lblRecordCount.BackColor = Color.White;
            lblRecordCount.BorderStyle = BorderStyle.FixedSingle;
            lblRecordCount.Location = new Point(422, 654);
            lblRecordCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(275, 46);
            lblRecordCount.TabIndex = 16;
            lblRecordCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 346);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(178, 32);
            label6.TabIndex = 22;
            label6.Text = "Date registered";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(77, 454);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(110, 32);
            label7.TabIndex = 24;
            label7.Text = "Available";
            // 
            // txtMileage
            // 
            txtMileage.Location = new Point(453, 492);
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(143, 39);
            txtMileage.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(77, 503);
            label8.Name = "label8";
            label8.Size = new Size(100, 32);
            label8.TabIndex = 25;
            label8.Text = "Mileage";
            // 
            // txtInsuranceType
            // 
            txtInsuranceType.Location = new Point(453, 552);
            txtInsuranceType.Name = "txtInsuranceType";
            txtInsuranceType.Size = new Size(143, 39);
            txtInsuranceType.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(77, 552);
            label9.Name = "label9";
            label9.Size = new Size(116, 32);
            label9.TabIndex = 26;
            label9.Text = "Insurance";
            // 
            // frmCars
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1655, 979);
            Controls.Add(label9);
            Controls.Add(txtInsuranceType);
            Controls.Add(label8);
            Controls.Add(txtMileage);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblRecordCount);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnFirst);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(chkAvailable);
            Controls.Add(dtpDateRegistered);
            Controls.Add(label5);
            Controls.Add(txtRentalPerDay);
            Controls.Add(label4);
            Controls.Add(txtEngineSize);
            Controls.Add(label3);
            Controls.Add(txtMake);
            Controls.Add(label2);
            Controls.Add(txtVehicleRegNo);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmCars";
            Text = "AutoFleet Manager - Dashboard";
            FormClosing += frmCars_FormClosing;
            Load += frmCars_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtVehicleRegNo;
        private Label label2;
        private TextBox txtMake;
        private Label label3;
        private TextBox txtEngineSize;
        private Label label4;
        private TextBox txtRentalPerDay;
        private Label label5;
        private DateTimePicker dtpDateRegistered;
        private CheckBox chkAvailable;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnCancel;
        private Button btnExit;
        private Button btnFirst;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnLast;
        private Label lblRecordCount;
        private Label label6;
        private Label label7;
        private ToolTip toolTip1;
        private TextBox txtMileage;
        private Label label8;
        private TextBox txtInsuranceType;
        private Label label9;
    }
}
