namespace GtifindoLeaveManagementEmployee
{
    partial class DeleteLeave
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
            this.btnLeaveHistory = new System.Windows.Forms.Button();
            this.btnRemainLeaves = new System.Windows.Forms.Button();
            this.btnDeleteLeaves = new System.Windows.Forms.Button();
            this.btnViewStatus = new System.Windows.Forms.Button();
            this.btnApplyLeave = new System.Windows.Forms.Button();
            this.LblViewStatus = new System.Windows.Forms.Label();
            this.cmbLeaveType = new System.Windows.Forms.ComboBox();
            this.LeaveType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LeaveID = new System.Windows.Forms.TextBox();
            this.dgvLeaves = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grifindoToysDataSet2 = new GtifindoLeaveManagementEmployee.GrifindoToysDataSet2();
            this.manageEmployeeLeaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manageEmployeeLeaveTableAdapter = new GtifindoLeaveManagementEmployee.GrifindoToysDataSet2TableAdapters.ManageEmployeeLeaveTableAdapter();
            this.leaveIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindoToysDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageEmployeeLeaveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(670, 71);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnLeaveHistory
            // 
            this.btnLeaveHistory.Location = new System.Drawing.Point(554, 71);
            this.btnLeaveHistory.Name = "btnLeaveHistory";
            this.btnLeaveHistory.Size = new System.Drawing.Size(89, 23);
            this.btnLeaveHistory.TabIndex = 19;
            this.btnLeaveHistory.Text = "Leave History";
            this.btnLeaveHistory.UseVisualStyleBackColor = true;
            // 
            // btnRemainLeaves
            // 
            this.btnRemainLeaves.Location = new System.Drawing.Point(438, 71);
            this.btnRemainLeaves.Name = "btnRemainLeaves";
            this.btnRemainLeaves.Size = new System.Drawing.Size(89, 23);
            this.btnRemainLeaves.TabIndex = 18;
            this.btnRemainLeaves.Text = "Remain Leaves";
            this.btnRemainLeaves.UseVisualStyleBackColor = true;
            // 
            // btnDeleteLeaves
            // 
            this.btnDeleteLeaves.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDeleteLeaves.Location = new System.Drawing.Point(317, 71);
            this.btnDeleteLeaves.Name = "btnDeleteLeaves";
            this.btnDeleteLeaves.Size = new System.Drawing.Size(89, 23);
            this.btnDeleteLeaves.TabIndex = 17;
            this.btnDeleteLeaves.Text = "Delete Leaves";
            this.btnDeleteLeaves.UseVisualStyleBackColor = false;
            // 
            // btnViewStatus
            // 
            this.btnViewStatus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewStatus.Location = new System.Drawing.Point(193, 71);
            this.btnViewStatus.Name = "btnViewStatus";
            this.btnViewStatus.Size = new System.Drawing.Size(89, 23);
            this.btnViewStatus.TabIndex = 16;
            this.btnViewStatus.Text = "View Status";
            this.btnViewStatus.UseVisualStyleBackColor = false;
            // 
            // btnApplyLeave
            // 
            this.btnApplyLeave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnApplyLeave.Location = new System.Drawing.Point(69, 71);
            this.btnApplyLeave.Name = "btnApplyLeave";
            this.btnApplyLeave.Size = new System.Drawing.Size(89, 23);
            this.btnApplyLeave.TabIndex = 15;
            this.btnApplyLeave.Text = "Apply Leaves";
            this.btnApplyLeave.UseVisualStyleBackColor = false;
            // 
            // LblViewStatus
            // 
            this.LblViewStatus.AutoSize = true;
            this.LblViewStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblViewStatus.Location = new System.Drawing.Point(260, 16);
            this.LblViewStatus.Name = "LblViewStatus";
            this.LblViewStatus.Size = new System.Drawing.Size(180, 29);
            this.LblViewStatus.TabIndex = 14;
            this.LblViewStatus.Text = "Delete Leaves";
            // 
            // cmbLeaveType
            // 
            this.cmbLeaveType.FormattingEnabled = true;
            this.cmbLeaveType.Items.AddRange(new object[] {
            "AnnualLeaves",
            "CasualLeaves"});
            this.cmbLeaveType.Location = new System.Drawing.Point(394, 217);
            this.cmbLeaveType.Name = "cmbLeaveType";
            this.cmbLeaveType.Size = new System.Drawing.Size(200, 21);
            this.cmbLeaveType.TabIndex = 22;
            // 
            // LeaveType
            // 
            this.LeaveType.AutoSize = true;
            this.LeaveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveType.Location = new System.Drawing.Point(192, 217);
            this.LeaveType.Name = "LeaveType";
            this.LeaveType.Size = new System.Drawing.Size(119, 24);
            this.LeaveType.TabIndex = 21;
            this.LeaveType.Text = "Leave Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Leave ID";
            // 
            // LeaveID
            // 
            this.LeaveID.Location = new System.Drawing.Point(394, 170);
            this.LeaveID.Multiline = true;
            this.LeaveID.Name = "LeaveID";
            this.LeaveID.Size = new System.Drawing.Size(200, 25);
            this.LeaveID.TabIndex = 24;
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
            this.decisionDataGridViewTextBoxColumn});
            this.dgvLeaves.DataSource = this.manageEmployeeLeaveBindingSource;
            this.dgvLeaves.Location = new System.Drawing.Point(26, 273);
            this.dgvLeaves.Name = "dgvLeaves";
            this.dgvLeaves.Size = new System.Drawing.Size(750, 291);
            this.dgvLeaves.TabIndex = 25;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(638, 215);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grifindoToysDataSet2
            // 
            this.grifindoToysDataSet2.DataSetName = "GrifindoToysDataSet2";
            this.grifindoToysDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manageEmployeeLeaveBindingSource
            // 
            this.manageEmployeeLeaveBindingSource.DataMember = "ManageEmployeeLeave";
            this.manageEmployeeLeaveBindingSource.DataSource = this.grifindoToysDataSet2;
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
            // decisionDataGridViewTextBoxColumn
            // 
            this.decisionDataGridViewTextBoxColumn.DataPropertyName = "Decision";
            this.decisionDataGridViewTextBoxColumn.HeaderText = "Decision";
            this.decisionDataGridViewTextBoxColumn.Name = "decisionDataGridViewTextBoxColumn";
            // 
            // DeleteLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvLeaves);
            this.Controls.Add(this.LeaveID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLeaveType);
            this.Controls.Add(this.LeaveType);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLeaveHistory);
            this.Controls.Add(this.btnRemainLeaves);
            this.Controls.Add(this.btnDeleteLeaves);
            this.Controls.Add(this.btnViewStatus);
            this.Controls.Add(this.btnApplyLeave);
            this.Controls.Add(this.LblViewStatus);
            this.Name = "DeleteLeave";
            this.Text = "DeleteLeave";
            this.Load += new System.EventHandler(this.DeleteLeave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindoToysDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageEmployeeLeaveBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLeaveHistory;
        private System.Windows.Forms.Button btnRemainLeaves;
        private System.Windows.Forms.Button btnDeleteLeaves;
        private System.Windows.Forms.Button btnViewStatus;
        private System.Windows.Forms.Button btnApplyLeave;
        private System.Windows.Forms.Label LblViewStatus;
        private System.Windows.Forms.ComboBox cmbLeaveType;
        private System.Windows.Forms.Label LeaveType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LeaveID;
        private System.Windows.Forms.DataGridView dgvLeaves;
        private System.Windows.Forms.Button btnDelete;
        private GrifindoToysDataSet2 grifindoToysDataSet2;
        private System.Windows.Forms.BindingSource manageEmployeeLeaveBindingSource;
        private GrifindoToysDataSet2TableAdapters.ManageEmployeeLeaveTableAdapter manageEmployeeLeaveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decisionDataGridViewTextBoxColumn;
    }
}