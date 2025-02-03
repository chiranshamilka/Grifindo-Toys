namespace AdminGrifindoLeaveManagement
{
    partial class DecisionLeaves
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
            this.LblDefineRoster = new System.Windows.Forms.Label();
            this.btnGoback = new System.Windows.Forms.Button();
            this.EmployeeLeaveDataGrid = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRejected = new System.Windows.Forms.Button();
            this.btnApproved = new System.Windows.Forms.Button();
            this.txtLeaveID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grifindoToysDataSet4 = new AdminGrifindoLeaveManagement.GrifindoToysDataSet4();
            this.manageEmployeeLeaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manageEmployeeLeaveTableAdapter = new AdminGrifindoLeaveManagement.GrifindoToysDataSet4TableAdapters.ManageEmployeeLeaveTableAdapter();
            this.leaveIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfLeaveDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeLeaveDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindoToysDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageEmployeeLeaveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDefineRoster
            // 
            this.LblDefineRoster.AutoSize = true;
            this.LblDefineRoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDefineRoster.Location = new System.Drawing.Point(270, 27);
            this.LblDefineRoster.Name = "LblDefineRoster";
            this.LblDefineRoster.Size = new System.Drawing.Size(183, 29);
            this.LblDefineRoster.TabIndex = 32;
            this.LblDefineRoster.Text = "Manage Leaves";
            // 
            // btnGoback
            // 
            this.btnGoback.Location = new System.Drawing.Point(50, 27);
            this.btnGoback.Name = "btnGoback";
            this.btnGoback.Size = new System.Drawing.Size(75, 23);
            this.btnGoback.TabIndex = 37;
            this.btnGoback.Text = "Go Back";
            this.btnGoback.UseVisualStyleBackColor = true;
            this.btnGoback.Click += new System.EventHandler(this.btnGoback_Click);
            // 
            // EmployeeLeaveDataGrid
            // 
            this.EmployeeLeaveDataGrid.AutoGenerateColumns = false;
            this.EmployeeLeaveDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeLeaveDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeLeaveDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leaveIDDataGridViewTextBoxColumn,
            this.EmployeeID,
            this.startDateTimeDataGridViewTextBoxColumn,
            this.endDateTimeDataGridViewTextBoxColumn,
            this.noOfLeaveDaysDataGridViewTextBoxColumn,
            this.decisionDataGridViewTextBoxColumn});
            this.EmployeeLeaveDataGrid.DataSource = this.manageEmployeeLeaveBindingSource;
            this.EmployeeLeaveDataGrid.Location = new System.Drawing.Point(40, 221);
            this.EmployeeLeaveDataGrid.Name = "EmployeeLeaveDataGrid";
            this.EmployeeLeaveDataGrid.Size = new System.Drawing.Size(761, 296);
            this.EmployeeLeaveDataGrid.TabIndex = 45;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(683, 138);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 48;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRejected
            // 
            this.btnRejected.Location = new System.Drawing.Point(582, 138);
            this.btnRejected.Name = "btnRejected";
            this.btnRejected.Size = new System.Drawing.Size(75, 23);
            this.btnRejected.TabIndex = 47;
            this.btnRejected.Text = "Reject";
            this.btnRejected.UseVisualStyleBackColor = true;
            this.btnRejected.Click += new System.EventHandler(this.btnRejected_Click);
            // 
            // btnApproved
            // 
            this.btnApproved.Location = new System.Drawing.Point(492, 139);
            this.btnApproved.Name = "btnApproved";
            this.btnApproved.Size = new System.Drawing.Size(75, 23);
            this.btnApproved.TabIndex = 46;
            this.btnApproved.Text = "Approve";
            this.btnApproved.UseVisualStyleBackColor = true;
            this.btnApproved.Click += new System.EventHandler(this.btnApproved_Click);
            // 
            // txtLeaveID
            // 
            this.txtLeaveID.Location = new System.Drawing.Point(252, 136);
            this.txtLeaveID.Multiline = true;
            this.txtLeaveID.Name = "txtLeaveID";
            this.txtLeaveID.Size = new System.Drawing.Size(201, 23);
            this.txtLeaveID.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Leave ID";
            // 
            // grifindoToysDataSet4
            // 
            this.grifindoToysDataSet4.DataSetName = "GrifindoToysDataSet4";
            this.grifindoToysDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manageEmployeeLeaveBindingSource
            // 
            this.manageEmployeeLeaveBindingSource.DataMember = "ManageEmployeeLeave";
            this.manageEmployeeLeaveBindingSource.DataSource = this.grifindoToysDataSet4;
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
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.Name = "EmployeeID";
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
            // decisionDataGridViewTextBoxColumn
            // 
            this.decisionDataGridViewTextBoxColumn.DataPropertyName = "Decision";
            this.decisionDataGridViewTextBoxColumn.HeaderText = "Decision";
            this.decisionDataGridViewTextBoxColumn.Name = "decisionDataGridViewTextBoxColumn";
            // 
            // DecisionLeaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 529);
            this.Controls.Add(this.txtLeaveID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRejected);
            this.Controls.Add(this.btnApproved);
            this.Controls.Add(this.EmployeeLeaveDataGrid);
            this.Controls.Add(this.btnGoback);
            this.Controls.Add(this.LblDefineRoster);
            this.Name = "DecisionLeaves";
            this.Text = "DecisionLeaves";
            this.Load += new System.EventHandler(this.DecisionLeaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeLeaveDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindoToysDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageEmployeeLeaveBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDefineRoster;
        private System.Windows.Forms.Button btnGoback;
        private System.Windows.Forms.DataGridView EmployeeLeaveDataGrid;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRejected;
        private System.Windows.Forms.Button btnApproved;
        private System.Windows.Forms.TextBox txtLeaveID;
        private System.Windows.Forms.Label label1;
        private GrifindoToysDataSet4 grifindoToysDataSet4;
        private System.Windows.Forms.BindingSource manageEmployeeLeaveBindingSource;
        private GrifindoToysDataSet4TableAdapters.ManageEmployeeLeaveTableAdapter manageEmployeeLeaveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfLeaveDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decisionDataGridViewTextBoxColumn;
    }
}