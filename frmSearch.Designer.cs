namespace CarsDatabase
{
    partial class frmSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtValue = new TextBox();
            label2 = new Label();
            cboOperator = new ComboBox();
            label1 = new Label();
            cboField = new ComboBox();
            btnRun = new Button();
            btnClose = new Button();
            dgvCars = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtValue);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboOperator);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboField);
            groupBox1.Location = new Point(240, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(617, 215);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(468, 40);
            label3.Name = "label3";
            label3.Size = new Size(72, 32);
            label3.TabIndex = 5;
            label3.Text = "Value";
            // 
            // txtValue
            // 
            txtValue.Location = new Point(395, 113);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(204, 39);
            txtValue.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 40);
            label2.Name = "label2";
            label2.Size = new Size(109, 32);
            label2.TabIndex = 3;
            label2.Text = "Operator";
            // 
            // cboOperator
            // 
            cboOperator.FormattingEnabled = true;
            cboOperator.Location = new Point(248, 113);
            cboOperator.Name = "cboOperator";
            cboOperator.Size = new Size(123, 40);
            cboOperator.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 40);
            label1.Name = "label1";
            label1.Size = new Size(65, 32);
            label1.TabIndex = 1;
            label1.Text = "Field";
            // 
            // cboField
            // 
            cboField.FormattingEnabled = true;
            cboField.Location = new Point(17, 113);
            cboField.Name = "cboField";
            cboField.Size = new Size(198, 40);
            cboField.TabIndex = 0;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(887, 98);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(117, 43);
            btnRun.TabIndex = 6;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(887, 167);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(117, 43);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvCars
            // 
            dgvCars.AllowUserToAddRows = false;
            dgvCars.AllowUserToDeleteRows = false;
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Location = new Point(240, 301);
            dgvCars.Name = "dgvCars";
            dgvCars.ReadOnly = true;
            dgvCars.RowHeadersWidth = 62;
            dgvCars.Size = new Size(1065, 277);
            dgvCars.TabIndex = 8;
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 785);
            Controls.Add(dgvCars);
            Controls.Add(btnClose);
            Controls.Add(groupBox1);
            Controls.Add(btnRun);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmSearch";
            Text = "AutoFleet Manager - Advanced Search";
            Load += frmSearch_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboField;
        private Label label3;
        private TextBox txtValue;
        private Label label2;
        private ComboBox cboOperator;
        private Label label1;
        private Button btnRun;
        private Button btnClose;
        private DataGridView dgvCars;
    }
}