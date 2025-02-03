namespace GtifindoLeaveManagementEmployee
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.LblMain = new System.Windows.Forms.Label();
            this.btnApplyLeave = new System.Windows.Forms.Button();
            this.btnViewStatus = new System.Windows.Forms.Button();
            this.btnDeleteLeaves = new System.Windows.Forms.Button();
            this.btnRemainLeaves = new System.Windows.Forms.Button();
            this.btnLeaveHistory = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblNoOfLeaveDates = new System.Windows.Forms.Label();
            this.NoOfDays = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.BtnApplyLeaves = new System.Windows.Forms.Button();
            this.dgvLeaves = new System.Windows.Forms.DataGridView();
            this.grifindoToysDataSet = new GtifindoLeaveManagementEmployee.GrifindoToysDataSet();
            this.manageEmployeeLeaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manageEmployeeLeaveTableAdapter = new GtifindoLeaveManagementEmployee.GrifindoToysDataSetTableAdapters.ManageEmployeeLeaveTableAdapter();
            this.leaveIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfLeaveDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveType = new System.Windows.Forms.Label();
            this.cmbLeaveType = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindoToysDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageEmployeeLeaveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LblMain
            // 
            this.LblMain.AutoSize = true;
            this.LblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMain.Location = new System.Drawing.Point(296, 20);
            this.LblMain.Name = "LblMain";
            this.LblMain.Size = new System.Drawing.Size(168, 29);
            this.LblMain.TabIndex = 0;
            this.LblMain.Text = "Apply Leaves";
            // 
            // btnApplyLeave
            // 
            this.btnApplyLeave.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnApplyLeave.Location = new System.Drawing.Point(75, 74);
            this.btnApplyLeave.Name = "btnApplyLeave";
            this.btnApplyLeave.Size = new System.Drawing.Size(89, 23);
            this.btnApplyLeave.TabIndex = 1;
            this.btnApplyLeave.Text = "Apply Leaves";
            this.btnApplyLeave.UseVisualStyleBackColor = false;
            // 
            // btnViewStatus
            // 
            this.btnViewStatus.Location = new System.Drawing.Point(199, 74);
            this.btnViewStatus.Name = "btnViewStatus";
            this.btnViewStatus.Size = new System.Drawing.Size(89, 23);
            this.btnViewStatus.TabIndex = 2;
            this.btnViewStatus.Text = "View Status";
            this.btnViewStatus.UseVisualStyleBackColor = true;
            this.btnViewStatus.Click += new System.EventHandler(this.btnViewStatus_Click);
            // 
            // btnDeleteLeaves
            // 
            this.btnDeleteLeaves.Location = new System.Drawing.Point(323, 74);
            this.btnDeleteLeaves.Name = "btnDeleteLeaves";
            this.btnDeleteLeaves.Size = new System.Drawing.Size(89, 23);
            this.btnDeleteLeaves.TabIndex = 3;
            this.btnDeleteLeaves.Text = "Delete Leaves";
            this.btnDeleteLeaves.UseVisualStyleBackColor = true;
            this.btnDeleteLeaves.Click += new System.EventHandler(this.btnDeleteLeaves_Click);
            // 
            // btnRemainLeaves
            // 
            this.btnRemainLeaves.Location = new System.Drawing.Point(444, 74);
            this.btnRemainLeaves.Name = "btnRemainLeaves";
            this.btnRemainLeaves.Size = new System.Drawing.Size(89, 23);
            this.btnRemainLeaves.TabIndex = 4;
            this.btnRemainLeaves.Text = "Remain Leaves";
            this.btnRemainLeaves.UseVisualStyleBackColor = true;
            // 
            // btnLeaveHistory
            // 
            this.btnLeaveHistory.Location = new System.Drawing.Point(560, 74);
            this.btnLeaveHistory.Name = "btnLeaveHistory";
            this.btnLeaveHistory.Size = new System.Drawing.Size(89, 23);
            this.btnLeaveHistory.TabIndex = 5;
            this.btnLeaveHistory.Text = "Leave History";
            this.btnLeaveHistory.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(676, 74);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(133, 157);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(99, 24);
            this.lblStartDate.TabIndex = 7;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(133, 204);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(96, 24);
            this.lblEndDate.TabIndex = 8;
            this.lblEndDate.Text = "End Date";
            // 
            // lblNoOfLeaveDates
            // 
            this.lblNoOfLeaveDates.AutoSize = true;
            this.lblNoOfLeaveDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfLeaveDates.Location = new System.Drawing.Point(133, 253);
            this.lblNoOfLeaveDates.Name = "lblNoOfLeaveDates";
            this.lblNoOfLeaveDates.Size = new System.Drawing.Size(180, 24);
            this.lblNoOfLeaveDates.TabIndex = 9;
            this.lblNoOfLeaveDates.Text = "No of Leave Dates";
            // 
            // NoOfDays
            // 
            this.NoOfDays.Location = new System.Drawing.Point(370, 252);
            this.NoOfDays.Multiline = true;
            this.NoOfDays.Name = "NoOfDays";
            this.NoOfDays.Size = new System.Drawing.Size(200, 25);
            this.NoOfDays.TabIndex = 12;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(370, 157);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 13;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(370, 204);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 14;
            // 
            // BtnApplyLeaves
            // 
            this.BtnApplyLeaves.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnApplyLeaves.Location = new System.Drawing.Point(621, 254);
            this.BtnApplyLeaves.Name = "BtnApplyLeaves";
            this.BtnApplyLeaves.Size = new System.Drawing.Size(85, 27);
            this.BtnApplyLeaves.TabIndex = 15;
            this.BtnApplyLeaves.Text = "Apply Leaves";
            this.BtnApplyLeaves.UseVisualStyleBackColor = false;
            this.BtnApplyLeaves.Click += new System.EventHandler(this.BtnApplyLeaves_Click);
            // 
            // dgvLeaves
            // 
            this.dgvLeaves.AutoGenerateColumns = false;
            this.dgvLeaves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leaveIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.startDateTimeDataGridViewTextBoxColumn,
            this.endDateTimeDataGridViewTextBoxColumn,
            this.noOfLeaveDaysDataGridViewTextBoxColumn});
            this.dgvLeaves.DataSource = this.manageEmployeeLeaveBindingSource;
            this.dgvLeaves.Location = new System.Drawing.Point(38, 385);
            this.dgvLeaves.Name = "dgvLeaves";
            this.dgvLeaves.Size = new System.Drawing.Size(750, 263);
            this.dgvLeaves.TabIndex = 16;
            // 
            // grifindoToysDataSet
            // 
            this.grifindoToysDataSet.DataSetName = "GrifindoToysDataSet";
            this.grifindoToysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manageEmployeeLeaveBindingSource
            // 
            this.manageEmployeeLeaveBindingSource.DataMember = "ManageEmployeeLeave";
            this.manageEmployeeLeaveBindingSource.DataSource = this.grifindoToysDataSet;
            // 
            // manageEmployeeLeaveTableAdapter
            // 
            this.manageEmployeeLeaveTableAdapter.ClearBeforeFill = true;
            // 
            // leaveIDDataGridViewTextBoxColumn
            // 
            this.leaveIDDataGridViewTextBoxColumn.DataPropertyName = "LeaveID";
            this.leaveIDDataGridViewTextBoxColumn.HeaderText = "LeaveID";
            this.leaveIDDataGridViewTextBoxColumn.Name = "leaveIDDataGridViewTextBoxColumn";
            this.leaveIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // startDateTimeDataGridViewTextBoxColumn
            // 
            this.startDateTimeDataGridViewTextBoxColumn.DataPropertyName = "StartDateTime";
            this.startDateTimeDataGridViewTextBoxColumn.HeaderText = "StartDateTime";
            this.startDateTimeDataGridViewTextBoxColumn.Name = "startDateTimeDataGridViewTextBoxColumn";
            // 
            // endDateTimeDataGridViewTextBoxColumn
            // 
            this.endDateTimeDataGridViewTextBoxColumn.DataPropertyName = "EndDateTime";
            this.endDateTimeDataGridViewTextBoxColumn.HeaderText = "EndDateTime";
            this.endDateTimeDataGridViewTextBoxColumn.Name = "endDateTimeDataGridViewTextBoxColumn";
            // 
            // noOfLeaveDaysDataGridViewTextBoxColumn
            // 
            this.noOfLeaveDaysDataGridViewTextBoxColumn.DataPropertyName = "NoOfLeaveDays";
            this.noOfLeaveDaysDataGridViewTextBoxColumn.HeaderText = "NoOfLeaveDays";
            this.noOfLeaveDaysDataGridViewTextBoxColumn.Name = "noOfLeaveDaysDataGridViewTextBoxColumn";
            // 
            // LeaveType
            // 
            this.LeaveType.AutoSize = true;
            this.LeaveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveType.Location = new System.Drawing.Point(133, 300);
            this.LeaveType.Name = "LeaveType";
            this.LeaveType.Size = new System.Drawing.Size(119, 24);
            this.LeaveType.TabIndex = 17;
            this.LeaveType.Text = "Leave Type";
            // 
            // cmbLeaveType
            // 
            this.cmbLeaveType.FormattingEnabled = true;
            this.cmbLeaveType.Items.AddRange(new object[] {
            "AnnualLeaves",
            "CasualLeaves"});
            this.cmbLeaveType.Location = new System.Drawing.Point(370, 302);
            this.cmbLeaveType.Name = "cmbLeaveType";
            this.cmbLeaveType.Size = new System.Drawing.Size(200, 21);
            this.cmbLeaveType.TabIndex = 18;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(621, 297);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbLeaveType);
            this.Controls.Add(this.LeaveType);
            this.Controls.Add(this.dgvLeaves);
            this.Controls.Add(this.BtnApplyLeaves);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.NoOfDays);
            this.Controls.Add(this.lblNoOfLeaveDates);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLeaveHistory);
            this.Controls.Add(this.btnRemainLeaves);
            this.Controls.Add(this.btnDeleteLeaves);
            this.Controls.Add(this.btnViewStatus);
            this.Controls.Add(this.btnApplyLeave);
            this.Controls.Add(this.LblMain);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindoToysDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageEmployeeLeaveBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMain;
        private System.Windows.Forms.Button btnApplyLeave;
        private System.Windows.Forms.Button btnViewStatus;
        private System.Windows.Forms.Button btnDeleteLeaves;
        private System.Windows.Forms.Button btnRemainLeaves;
        private System.Windows.Forms.Button btnLeaveHistory;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblNoOfLeaveDates;
        private System.Windows.Forms.TextBox NoOfDays;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button BtnApplyLeaves;
        private System.Windows.Forms.DataGridView dgvLeaves;
        private GrifindoToysDataSet grifindoToysDataSet;
        private System.Windows.Forms.BindingSource manageEmployeeLeaveBindingSource;
        private GrifindoToysDataSetTableAdapters.ManageEmployeeLeaveTableAdapter manageEmployeeLeaveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfLeaveDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label LeaveType;
        private System.Windows.Forms.ComboBox cmbLeaveType;
        private System.Windows.Forms.Button btnClear;
    }
}