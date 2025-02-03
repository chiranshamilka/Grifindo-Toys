namespace GtifindoLeaveManagementEmployee
{
    partial class ViewStatus
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
            this.dgvLeaves = new System.Windows.Forms.DataGridView();
            this.grifindoToysDataSet1 = new GtifindoLeaveManagementEmployee.GrifindoToysDataSet1();
            this.manageEmployeeLeaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manageEmployeeLeaveTableAdapter = new GtifindoLeaveManagementEmployee.GrifindoToysDataSet1TableAdapters.ManageEmployeeLeaveTableAdapter();
            this.leaveIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindoToysDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageEmployeeLeaveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(680, 73);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnLeaveHistory
            // 
            this.btnLeaveHistory.Location = new System.Drawing.Point(564, 73);
            this.btnLeaveHistory.Name = "btnLeaveHistory";
            this.btnLeaveHistory.Size = new System.Drawing.Size(89, 23);
            this.btnLeaveHistory.TabIndex = 12;
            this.btnLeaveHistory.Text = "Leave History";
            this.btnLeaveHistory.UseVisualStyleBackColor = true;
            // 
            // btnRemainLeaves
            // 
            this.btnRemainLeaves.Location = new System.Drawing.Point(448, 73);
            this.btnRemainLeaves.Name = "btnRemainLeaves";
            this.btnRemainLeaves.Size = new System.Drawing.Size(89, 23);
            this.btnRemainLeaves.TabIndex = 11;
            this.btnRemainLeaves.Text = "Remain Leaves";
            this.btnRemainLeaves.UseVisualStyleBackColor = true;
            // 
            // btnDeleteLeaves
            // 
            this.btnDeleteLeaves.Location = new System.Drawing.Point(327, 73);
            this.btnDeleteLeaves.Name = "btnDeleteLeaves";
            this.btnDeleteLeaves.Size = new System.Drawing.Size(89, 23);
            this.btnDeleteLeaves.TabIndex = 10;
            this.btnDeleteLeaves.Text = "Delete Leaves";
            this.btnDeleteLeaves.UseVisualStyleBackColor = true;
            this.btnDeleteLeaves.Click += new System.EventHandler(this.btnDeleteLeaves_Click);
            // 
            // btnViewStatus
            // 
            this.btnViewStatus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnViewStatus.Location = new System.Drawing.Point(203, 73);
            this.btnViewStatus.Name = "btnViewStatus";
            this.btnViewStatus.Size = new System.Drawing.Size(89, 23);
            this.btnViewStatus.TabIndex = 9;
            this.btnViewStatus.Text = "View Status";
            this.btnViewStatus.UseVisualStyleBackColor = false;
            // 
            // btnApplyLeave
            // 
            this.btnApplyLeave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnApplyLeave.Location = new System.Drawing.Point(79, 73);
            this.btnApplyLeave.Name = "btnApplyLeave";
            this.btnApplyLeave.Size = new System.Drawing.Size(89, 23);
            this.btnApplyLeave.TabIndex = 8;
            this.btnApplyLeave.Text = "Apply Leaves";
            this.btnApplyLeave.UseVisualStyleBackColor = false;
            this.btnApplyLeave.Click += new System.EventHandler(this.btnApplyLeave_Click);
            // 
            // LblViewStatus
            // 
            this.LblViewStatus.AutoSize = true;
            this.LblViewStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblViewStatus.Location = new System.Drawing.Point(270, 18);
            this.LblViewStatus.Name = "LblViewStatus";
            this.LblViewStatus.Size = new System.Drawing.Size(226, 29);
            this.LblViewStatus.TabIndex = 7;
            this.LblViewStatus.Text = "View Leave Status";
            // 
            // dgvLeaves
            // 
            this.dgvLeaves.AutoGenerateColumns = false;
            this.dgvLeaves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leaveIDDataGridViewTextBoxColumn,
            this.startDateTimeDataGridViewTextBoxColumn,
            this.endDateTimeDataGridViewTextBoxColumn,
            this.decisionDataGridViewTextBoxColumn});
            this.dgvLeaves.DataSource = this.manageEmployeeLeaveBindingSource;
            this.dgvLeaves.Location = new System.Drawing.Point(38, 157);
            this.dgvLeaves.Name = "dgvLeaves";
            this.dgvLeaves.Size = new System.Drawing.Size(750, 291);
            this.dgvLeaves.TabIndex = 17;
            // 
            // grifindoToysDataSet1
            // 
            this.grifindoToysDataSet1.DataSetName = "GrifindoToysDataSet1";
            this.grifindoToysDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manageEmployeeLeaveBindingSource
            // 
            this.manageEmployeeLeaveBindingSource.DataMember = "ManageEmployeeLeave";
            this.manageEmployeeLeaveBindingSource.DataSource = this.grifindoToysDataSet1;
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
            // ViewStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLeaves);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLeaveHistory);
            this.Controls.Add(this.btnRemainLeaves);
            this.Controls.Add(this.btnDeleteLeaves);
            this.Controls.Add(this.btnViewStatus);
            this.Controls.Add(this.btnApplyLeave);
            this.Controls.Add(this.LblViewStatus);
            this.Name = "ViewStatus";
            this.Text = "ViewStatus";
            this.Load += new System.EventHandler(this.ViewStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindoToysDataSet1)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvLeaves;
        private GrifindoToysDataSet1 grifindoToysDataSet1;
        private System.Windows.Forms.BindingSource manageEmployeeLeaveBindingSource;
        private GrifindoToysDataSet1TableAdapters.ManageEmployeeLeaveTableAdapter manageEmployeeLeaveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decisionDataGridViewTextBoxColumn;
    }
}