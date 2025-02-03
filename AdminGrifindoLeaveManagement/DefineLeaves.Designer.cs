namespace AdminGrifindoLeaveManagement
{
    partial class DefineLeaves
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
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnualLeaves = new System.Windows.Forms.Label();
            this.txtAnnualLeaves = new System.Windows.Forms.TextBox();
            this.lblCasualLeaves = new System.Windows.Forms.Label();
            this.txtCasualLeaves = new System.Windows.Forms.TextBox();
            this.btnGoback = new System.Windows.Forms.Button();
            this.btnAddLeaves = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.EmployeeLeavesDataGrid = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchEmpID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grifindoToysDataSet2 = new AdminGrifindoLeaveManagement.GrifindoToysDataSet2();
            this.employeeLeavesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeLeavesTableAdapter = new AdminGrifindoLeaveManagement.GrifindoToysDataSet2TableAdapters.EmployeeLeavesTableAdapter();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annualLeavesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casualLeavesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeLeavesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindoToysDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeLeavesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(248, 106);
            this.txtEmployeeID.Multiline = true;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(201, 23);
            this.txtEmployeeID.TabIndex = 7;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(89, 106);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(118, 24);
            this.lblEmployeeID.TabIndex = 6;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Define Leaves";
            // 
            // lblAnualLeaves
            // 
            this.lblAnualLeaves.AutoSize = true;
            this.lblAnualLeaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnualLeaves.Location = new System.Drawing.Point(72, 165);
            this.lblAnualLeaves.Name = "lblAnualLeaves";
            this.lblAnualLeaves.Size = new System.Drawing.Size(135, 24);
            this.lblAnualLeaves.TabIndex = 9;
            this.lblAnualLeaves.Text = "Annual Leaves";
            // 
            // txtAnnualLeaves
            // 
            this.txtAnnualLeaves.Location = new System.Drawing.Point(248, 170);
            this.txtAnnualLeaves.Multiline = true;
            this.txtAnnualLeaves.Name = "txtAnnualLeaves";
            this.txtAnnualLeaves.Size = new System.Drawing.Size(201, 23);
            this.txtAnnualLeaves.TabIndex = 10;
            // 
            // lblCasualLeaves
            // 
            this.lblCasualLeaves.AutoSize = true;
            this.lblCasualLeaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasualLeaves.Location = new System.Drawing.Point(72, 230);
            this.lblCasualLeaves.Name = "lblCasualLeaves";
            this.lblCasualLeaves.Size = new System.Drawing.Size(132, 24);
            this.lblCasualLeaves.TabIndex = 11;
            this.lblCasualLeaves.Text = "Casual Leaves";
            // 
            // txtCasualLeaves
            // 
            this.txtCasualLeaves.Location = new System.Drawing.Point(248, 235);
            this.txtCasualLeaves.Multiline = true;
            this.txtCasualLeaves.Name = "txtCasualLeaves";
            this.txtCasualLeaves.Size = new System.Drawing.Size(201, 23);
            this.txtCasualLeaves.TabIndex = 12;
            // 
            // btnGoback
            // 
            this.btnGoback.Location = new System.Drawing.Point(39, 27);
            this.btnGoback.Name = "btnGoback";
            this.btnGoback.Size = new System.Drawing.Size(75, 23);
            this.btnGoback.TabIndex = 19;
            this.btnGoback.Text = "Go Back";
            this.btnGoback.UseVisualStyleBackColor = true;
            this.btnGoback.Click += new System.EventHandler(this.btnGoback_Click);
            // 
            // btnAddLeaves
            // 
            this.btnAddLeaves.Location = new System.Drawing.Point(498, 206);
            this.btnAddLeaves.Name = "btnAddLeaves";
            this.btnAddLeaves.Size = new System.Drawing.Size(75, 23);
            this.btnAddLeaves.TabIndex = 21;
            this.btnAddLeaves.Text = "Add";
            this.btnAddLeaves.UseVisualStyleBackColor = true;
            this.btnAddLeaves.Click += new System.EventHandler(this.btnAddLeaves_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(498, 235);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(689, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EmployeeLeavesDataGrid
            // 
            this.EmployeeLeavesDataGrid.AutoGenerateColumns = false;
            this.EmployeeLeavesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeLeavesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeLeavesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.annualLeavesDataGridViewTextBoxColumn,
            this.casualLeavesDataGridViewTextBoxColumn});
            this.EmployeeLeavesDataGrid.DataSource = this.employeeLeavesBindingSource;
            this.EmployeeLeavesDataGrid.Location = new System.Drawing.Point(39, 347);
            this.EmployeeLeavesDataGrid.Name = "EmployeeLeavesDataGrid";
            this.EmployeeLeavesDataGrid.Size = new System.Drawing.Size(745, 233);
            this.EmployeeLeavesDataGrid.TabIndex = 27;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(588, 298);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(498, 299);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(402, 300);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchEmpID
            // 
            this.txtSearchEmpID.Location = new System.Drawing.Point(208, 302);
            this.txtSearchEmpID.Name = "txtSearchEmpID";
            this.txtSearchEmpID.Size = new System.Drawing.Size(164, 20);
            this.txtSearchEmpID.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Employee ID";
            // 
            // grifindoToysDataSet2
            // 
            this.grifindoToysDataSet2.DataSetName = "GrifindoToysDataSet2";
            this.grifindoToysDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeLeavesBindingSource
            // 
            this.employeeLeavesBindingSource.DataMember = "EmployeeLeaves";
            this.employeeLeavesBindingSource.DataSource = this.grifindoToysDataSet2;
            // 
            // employeeLeavesTableAdapter
            // 
            this.employeeLeavesTableAdapter.ClearBeforeFill = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // annualLeavesDataGridViewTextBoxColumn
            // 
            this.annualLeavesDataGridViewTextBoxColumn.DataPropertyName = "AnnualLeaves";
            this.annualLeavesDataGridViewTextBoxColumn.HeaderText = "AnnualLeaves";
            this.annualLeavesDataGridViewTextBoxColumn.Name = "annualLeavesDataGridViewTextBoxColumn";
            // 
            // casualLeavesDataGridViewTextBoxColumn
            // 
            this.casualLeavesDataGridViewTextBoxColumn.DataPropertyName = "CasualLeaves";
            this.casualLeavesDataGridViewTextBoxColumn.HeaderText = "CasualLeaves";
            this.casualLeavesDataGridViewTextBoxColumn.Name = "casualLeavesDataGridViewTextBoxColumn";
            // 
            // DefineLeaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 578);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.EmployeeLeavesDataGrid);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchEmpID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddLeaves);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGoback);
            this.Controls.Add(this.txtCasualLeaves);
            this.Controls.Add(this.lblCasualLeaves);
            this.Controls.Add(this.txtAnnualLeaves);
            this.Controls.Add(this.lblAnualLeaves);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lblEmployeeID);
            this.Name = "DefineLeaves";
            this.Text = "DefineLeaves";
            this.Load += new System.EventHandler(this.DefineLeaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeLeavesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindoToysDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeLeavesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnualLeaves;
        private System.Windows.Forms.TextBox txtAnnualLeaves;
        private System.Windows.Forms.Label lblCasualLeaves;
        private System.Windows.Forms.TextBox txtCasualLeaves;
        private System.Windows.Forms.Button btnGoback;
        private System.Windows.Forms.Button btnAddLeaves;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView EmployeeLeavesDataGrid;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchEmpID;
        private System.Windows.Forms.Label label2;
        private GrifindoToysDataSet2 grifindoToysDataSet2;
        private System.Windows.Forms.BindingSource employeeLeavesBindingSource;
        private GrifindoToysDataSet2TableAdapters.EmployeeLeavesTableAdapter employeeLeavesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualLeavesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn casualLeavesDataGridViewTextBoxColumn;
    }
}