namespace AdminGrifindoLeaveManagement
{
    partial class MainMenu
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
            this.BtnRegEmployee = new System.Windows.Forms.Button();
            this.leaveDef = new System.Windows.Forms.Button();
            this.RejectOrApproveLeaves = new System.Windows.Forms.Button();
            this.DefRoster = new System.Windows.Forms.Button();
            this.ViewReport = new System.Windows.Forms.Button();
            this.MainLBL = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRegEmployee
            // 
            this.BtnRegEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegEmployee.Location = new System.Drawing.Point(188, 131);
            this.BtnRegEmployee.Name = "BtnRegEmployee";
            this.BtnRegEmployee.Size = new System.Drawing.Size(197, 43);
            this.BtnRegEmployee.TabIndex = 0;
            this.BtnRegEmployee.Text = "Register Employee";
            this.BtnRegEmployee.UseVisualStyleBackColor = true;
            this.BtnRegEmployee.Click += new System.EventHandler(this.BtnRegEmployee_Click);
            // 
            // leaveDef
            // 
            this.leaveDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveDef.Location = new System.Drawing.Point(420, 131);
            this.leaveDef.Name = "leaveDef";
            this.leaveDef.Size = new System.Drawing.Size(197, 43);
            this.leaveDef.TabIndex = 1;
            this.leaveDef.Text = "Define Leaves";
            this.leaveDef.UseVisualStyleBackColor = true;
            this.leaveDef.Click += new System.EventHandler(this.leaveDef_Click);
            // 
            // RejectOrApproveLeaves
            // 
            this.RejectOrApproveLeaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RejectOrApproveLeaves.Location = new System.Drawing.Point(188, 201);
            this.RejectOrApproveLeaves.Name = "RejectOrApproveLeaves";
            this.RejectOrApproveLeaves.Size = new System.Drawing.Size(197, 43);
            this.RejectOrApproveLeaves.TabIndex = 2;
            this.RejectOrApproveLeaves.Text = "Decision for Leaves";
            this.RejectOrApproveLeaves.UseVisualStyleBackColor = true;
            this.RejectOrApproveLeaves.Click += new System.EventHandler(this.RejectOrApproveLeaves_Click);
            // 
            // DefRoster
            // 
            this.DefRoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefRoster.Location = new System.Drawing.Point(420, 203);
            this.DefRoster.Name = "DefRoster";
            this.DefRoster.Size = new System.Drawing.Size(197, 43);
            this.DefRoster.TabIndex = 3;
            this.DefRoster.Text = "Define Roster";
            this.DefRoster.UseVisualStyleBackColor = true;
            this.DefRoster.Click += new System.EventHandler(this.DefRoster_Click);
            // 
            // ViewReport
            // 
            this.ViewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewReport.Location = new System.Drawing.Point(188, 287);
            this.ViewReport.Name = "ViewReport";
            this.ViewReport.Size = new System.Drawing.Size(197, 43);
            this.ViewReport.TabIndex = 4;
            this.ViewReport.Text = "View Report";
            this.ViewReport.UseVisualStyleBackColor = true;
            this.ViewReport.Click += new System.EventHandler(this.ViewReport_Click);
            // 
            // MainLBL
            // 
            this.MainLBL.AutoSize = true;
            this.MainLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLBL.Location = new System.Drawing.Point(302, 9);
            this.MainLBL.Name = "MainLBL";
            this.MainLBL.Size = new System.Drawing.Size(174, 37);
            this.MainLBL.TabIndex = 5;
            this.MainLBL.Text = "Main Menu";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(635, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MainLBL);
            this.Controls.Add(this.ViewReport);
            this.Controls.Add(this.DefRoster);
            this.Controls.Add(this.RejectOrApproveLeaves);
            this.Controls.Add(this.leaveDef);
            this.Controls.Add(this.BtnRegEmployee);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegEmployee;
        private System.Windows.Forms.Button leaveDef;
        private System.Windows.Forms.Button RejectOrApproveLeaves;
        private System.Windows.Forms.Button DefRoster;
        private System.Windows.Forms.Button ViewReport;
        private System.Windows.Forms.Label MainLBL;
        private System.Windows.Forms.Button button1;
    }
}