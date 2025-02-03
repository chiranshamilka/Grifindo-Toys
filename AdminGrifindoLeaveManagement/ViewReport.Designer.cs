namespace AdminGrifindoLeaveManagement
{
    partial class ViewReport
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
            this.dataGridViewLeaveReport = new System.Windows.Forms.DataGridView();
            this.btnIndividual = new System.Windows.Forms.Button();
            this.btnAllReport = new System.Windows.Forms.Button();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblDefineRoster = new System.Windows.Forms.Label();
            this.btnGoback = new System.Windows.Forms.Button();
            this.grifindoToysDataSet5 = new AdminGrifindoLeaveManagement.GrifindoToysDataSet5();
            this.manageEmployeeLeaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manageEmployeeLeaveTableAdapter = new AdminGrifindoLeaveManagement.GrifindoToysDataSet5TableAdapters.ManageEmployeeLeaveTableAdapter();
            this.leaveIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfLeaveDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaveReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindoToysDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageEmployeeLeaveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(693, 141);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 52;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridViewLeaveReport
            // 
            this.dataGridViewLeaveReport.AutoGenerateColumns = false;
            this.dataGridViewLeaveReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLeaveReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeaveReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leaveIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.startDateTimeDataGridViewTextBoxColumn,
            this.endDateTimeDataGridViewTextBoxColumn,
            this.noOfLeaveDaysDataGridViewTextBoxColumn,
            this.decisionDataGridViewTextBoxColumn});
            this.dataGridViewLeaveReport.DataSource = this.manageEmployeeLeaveBindingSource;
            this.dataGridViewLeaveReport.Location = new System.Drawing.Point(36, 215);
            this.dataGridViewLeaveReport.Name = "dataGridViewLeaveReport";
            this.dataGridViewLeaveReport.Size = new System.Drawing.Size(745, 396);
            this.dataGridViewLeaveReport.TabIndex = 51;
            // 
            // btnIndividual
            // 
            this.btnIndividual.Location = new System.Drawing.Point(498, 141);
            this.btnIndividual.Name = "btnIndividual";
            this.btnIndividual.Size = new System.Drawing.Size(75, 23);
            this.btnIndividual.TabIndex = 49;
            this.btnIndividual.Text = "Individual Report";
            this.btnIndividual.UseVisualStyleBackColor = true;
            this.btnIndividual.Click += new System.EventHandler(this.btnIndividual_Click);
            // 
            // btnAllReport
            // 
            this.btnAllReport.Location = new System.Drawing.Point(596, 141);
            this.btnAllReport.Name = "btnAllReport";
            this.btnAllReport.Size = new System.Drawing.Size(75, 23);
            this.btnAllReport.TabIndex = 48;
            this.btnAllReport.Text = "All Reports";
            this.btnAllReport.UseVisualStyleBackColor = true;
            this.btnAllReport.Click += new System.EventHandler(this.btnAllReport_Click);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(245, 141);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(200, 20);
            this.txtEmployeeID.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 46;
            this.label2.Text = "Employee ID";
            // 
            // LblDefineRoster
            // 
            this.LblDefineRoster.AutoSize = true;
            this.LblDefineRoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDefineRoster.Location = new System.Drawing.Point(327, 24);
            this.LblDefineRoster.Name = "LblDefineRoster";
            this.LblDefineRoster.Size = new System.Drawing.Size(98, 29);
            this.LblDefineRoster.TabIndex = 53;
            this.LblDefineRoster.Text = "Reports";
            // 
            // btnGoback
            // 
            this.btnGoback.Location = new System.Drawing.Point(57, 24);
            this.btnGoback.Name = "btnGoback";
            this.btnGoback.Size = new System.Drawing.Size(75, 23);
            this.btnGoback.TabIndex = 54;
            this.btnGoback.Text = "Go Back";
            this.btnGoback.UseVisualStyleBackColor = true;
            this.btnGoback.Click += new System.EventHandler(this.btnGoback_Click);
            // 
            // grifindoToysDataSet5
            // 
            this.grifindoToysDataSet5.DataSetName = "GrifindoToysDataSet5";
            this.grifindoToysDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manageEmployeeLeaveBindingSource
            // 
            this.manageEmployeeLeaveBindingSource.DataMember = "ManageEmployeeLeave";
            this.manageEmployeeLeaveBindingSource.DataSource = this.grifindoToysDataSet5;
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
            // decisionDataGridViewTextBoxColumn
            // 
            this.decisionDataGridViewTextBoxColumn.DataPropertyName = "Decision";
            this.decisionDataGridViewTextBoxColumn.HeaderText = "Decision";
            this.decisionDataGridViewTextBoxColumn.Name = "decisionDataGridViewTextBoxColumn";
            // 
            // ViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 611);
            this.Controls.Add(this.btnGoback);
            this.Controls.Add(this.LblDefineRoster);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridViewLeaveReport);
            this.Controls.Add(this.btnIndividual);
            this.Controls.Add(this.btnAllReport);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label2);
            this.Name = "ViewReport";
            this.Text = "ViewReport";
            this.Load += new System.EventHandler(this.ViewReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaveReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindoToysDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageEmployeeLeaveBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridViewLeaveReport;
        private System.Windows.Forms.Button btnIndividual;
        private System.Windows.Forms.Button btnAllReport;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblDefineRoster;
        private System.Windows.Forms.Button btnGoback;
        private GrifindoToysDataSet5 grifindoToysDataSet5;
        private System.Windows.Forms.BindingSource manageEmployeeLeaveBindingSource;
        private GrifindoToysDataSet5TableAdapters.ManageEmployeeLeaveTableAdapter manageEmployeeLeaveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfLeaveDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decisionDataGridViewTextBoxColumn;
    }
}