using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGrifindoLeaveManagement
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Terminates the application
            }
        }

        private void BtnRegEmployee_Click(object sender, EventArgs e)
        {
            this.Close(); // Hide the current form
            RegisterEmployee regForm = new RegisterEmployee();
            regForm.ShowDialog(); // Show the RegisterEmployee form as a modal
     
        }

        private void leaveDef_Click(object sender, EventArgs e)
        {
            this.Close(); // Hide the current form
            DefineLeaves defineLeavesForm = new DefineLeaves();
            defineLeavesForm.ShowDialog(); // Show the DefineLeaves form as a modal
        
        }

        private void DefRoster_Click(object sender, EventArgs e)
        {
            this.Close(); // Hide the current form
            DefineRoster defineRosterForm = new DefineRoster();
            defineRosterForm.ShowDialog(); // Show DefineRoster form as a modal
      
        }

        private void RejectOrApproveLeaves_Click(object sender, EventArgs e)
        {
            this.Close(); // Hide the current form
            DecisionLeaves decisionLeavesForm = new DecisionLeaves();
            decisionLeavesForm.ShowDialog(); // Show DecisionLeaves form as a modal
           
        }

        private void ViewReport_Click(object sender, EventArgs e)
        {
            this.Close(); // Hide the current form
            ViewReport viewReportForm = new ViewReport();
            viewReportForm.ShowDialog(); // Show ViewReport form as a modal
            
        }
    }
}
