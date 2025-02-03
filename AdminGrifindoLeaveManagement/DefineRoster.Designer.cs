namespace AdminGrifindoLeaveManagement
{
    partial class DefineRoster
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
            this.btnExit = new System.Windows.Forms.Button();
            this.EmployeeRosterDataGrid = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchEmpID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddRoster = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGoback = new System.Windows.Forms.Button();
            this.lblCasualLeaves = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.LblDefineRoster = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDutyDate = new System.Windows.Forms.DateTimePicker();
            this.txtStartTime = new System.Windows.Forms.DateTimePicker();
            this.txtEndTime = new System.Windows.Forms.DateTimePicker();
            this.grifindoToysDataSet3 = new AdminGrifindoLeaveManagement.GrifindoToysDataSet3();
            this.rosterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rosterTableAdapter = new AdminGrifindoLeaveManagement.GrifindoToysDataSet3TableAdapters.RosterTableAdapter();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dutyDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeRosterDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindoToysDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rosterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(719, 381);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EmployeeRosterDataGrid
            // 
            this.EmployeeRosterDataGrid.AutoGenerateColumns = false;
            this.EmployeeRosterDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeRosterDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeRosterDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.dutyDateDataGridViewTextBoxColumn,
            this.startingTimeDataGridViewTextBoxColumn,
            this.endingTimeDataGridViewTextBoxColumn});
            this.EmployeeRosterDataGrid.DataSource = this.rosterBindingSource;
            this.EmployeeRosterDataGrid.Location = new System.Drawing.Point(69, 425);
            this.EmployeeRosterDataGrid.Name = "EmployeeRosterDataGrid";
            this.EmployeeRosterDataGrid.Size = new System.Drawing.Size(745, 233);
            this.EmployeeRosterDataGrid.TabIndex = 44;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(618, 381);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(528, 382);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(432, 383);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 41;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchEmpID
            // 
            this.txtSearchEmpID.Location = new System.Drawing.Point(238, 385);
            this.txtSearchEmpID.Name = "txtSearchEmpID";
            this.txtSearchEmpID.Size = new System.Drawing.Size(164, 20);
            this.txtSearchEmpID.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Employee ID";
            // 
            // btnAddRoster
            // 
            this.btnAddRoster.Location = new System.Drawing.Point(528, 259);
            this.btnAddRoster.Name = "btnAddRoster";
            this.btnAddRoster.Size = new System.Drawing.Size(75, 23);
            this.btnAddRoster.TabIndex = 38;
            this.btnAddRoster.Text = "Add";
            this.btnAddRoster.UseVisualStyleBackColor = true;
            this.btnAddRoster.Click += new System.EventHandler(this.btnAddRoster_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(528, 288);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGoback
            // 
            this.btnGoback.Location = new System.Drawing.Point(69, 28);
            this.btnGoback.Name = "btnGoback";
            this.btnGoback.Size = new System.Drawing.Size(75, 23);
            this.btnGoback.TabIndex = 36;
            this.btnGoback.Text = "Go Back";
            this.btnGoback.UseVisualStyleBackColor = true;
            this.btnGoback.Click += new System.EventHandler(this.btnGoback_Click);
            // 
            // lblCasualLeaves
            // 
            this.lblCasualLeaves.AutoSize = true;
            this.lblCasualLeaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasualLeaves.Location = new System.Drawing.Point(110, 231);
            this.lblCasualLeaves.Name = "lblCasualLeaves";
            this.lblCasualLeaves.Size = new System.Drawing.Size(120, 24);
            this.lblCasualLeaves.TabIndex = 34;
            this.lblCasualLeaves.Text = "Starting Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(140, 166);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(90, 24);
            this.lblDate.TabIndex = 32;
            this.lblDate.Text = "Duty Date";
            // 
            // LblDefineRoster
            // 
            this.LblDefineRoster.AutoSize = true;
            this.LblDefineRoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDefineRoster.Location = new System.Drawing.Point(295, 21);
            this.LblDefineRoster.Name = "LblDefineRoster";
            this.LblDefineRoster.Size = new System.Drawing.Size(160, 29);
            this.LblDefineRoster.TabIndex = 31;
            this.LblDefineRoster.Text = "Define Roster";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(278, 107);
            this.txtEmployeeID.Multiline = true;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(201, 23);
            this.txtEmployeeID.TabIndex = 30;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(119, 107);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(118, 24);
            this.lblEmployeeID.TabIndex = 29;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Ending Time";
            // 
            // dateTimePickerDutyDate
            // 
            this.dateTimePickerDutyDate.Location = new System.Drawing.Point(278, 168);
            this.dateTimePickerDutyDate.Name = "dateTimePickerDutyDate";
            this.dateTimePickerDutyDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDutyDate.TabIndex = 48;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtStartTime.Location = new System.Drawing.Point(278, 233);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(200, 20);
            this.txtStartTime.TabIndex = 49;
            // 
            // txtEndTime
            // 
            this.txtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtEndTime.Location = new System.Drawing.Point(279, 291);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(200, 20);
            this.txtEndTime.TabIndex = 50;
            // 
            // grifindoToysDataSet3
            // 
            this.grifindoToysDataSet3.DataSetName = "GrifindoToysDataSet3";
            this.grifindoToysDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rosterBindingSource
            // 
            this.rosterBindingSource.DataMember = "Roster";
            this.rosterBindingSource.DataSource = this.grifindoToysDataSet3;
            // 
            // rosterTableAdapter
            // 
            this.rosterTableAdapter.ClearBeforeFill = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // dutyDateDataGridViewTextBoxColumn
            // 
            this.dutyDateDataGridViewTextBoxColumn.DataPropertyName = "DutyDate";
            this.dutyDateDataGridViewTextBoxColumn.HeaderText = "DutyDate";
            this.dutyDateDataGridViewTextBoxColumn.Name = "dutyDateDataGridViewTextBoxColumn";
            // 
            // startingTimeDataGridViewTextBoxColumn
            // 
            this.startingTimeDataGridViewTextBoxColumn.DataPropertyName = "StartingTime";
            this.startingTimeDataGridViewTextBoxColumn.HeaderText = "StartingTime";
            this.startingTimeDataGridViewTextBoxColumn.Name = "startingTimeDataGridViewTextBoxColumn";
            // 
            // endingTimeDataGridViewTextBoxColumn
            // 
            this.endingTimeDataGridViewTextBoxColumn.DataPropertyName = "EndingTime";
            this.endingTimeDataGridViewTextBoxColumn.HeaderText = "EndingTime";
            this.endingTimeDataGridViewTextBoxColumn.Name = "endingTimeDataGridViewTextBoxColumn";
            // 
            // DefineRoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 598);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.dateTimePickerDutyDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.EmployeeRosterDataGrid);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchEmpID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddRoster);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGoback);
            this.Controls.Add(this.lblCasualLeaves);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.LblDefineRoster);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lblEmployeeID);
            this.Name = "DefineRoster";
            this.Text = "DefineRoster";
            this.Load += new System.EventHandler(this.DefineRoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeRosterDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindoToysDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rosterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView EmployeeRosterDataGrid;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchEmpID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddRoster;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGoback;
        private System.Windows.Forms.Label lblCasualLeaves;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label LblDefineRoster;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDutyDate;
        private System.Windows.Forms.DateTimePicker txtStartTime;
        private System.Windows.Forms.DateTimePicker txtEndTime;
        private GrifindoToysDataSet3 grifindoToysDataSet3;
        private System.Windows.Forms.BindingSource rosterBindingSource;
        private GrifindoToysDataSet3TableAdapters.RosterTableAdapter rosterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dutyDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingTimeDataGridViewTextBoxColumn;
    }
}