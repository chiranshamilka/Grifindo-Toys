using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GtifindoLeaveManagementEmployee
{
    public partial class ViewStatus : Form
    {
        public ViewStatus()
        {
            InitializeComponent();
        }

        private void ViewStatus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindoToysDataSet1.ManageEmployeeLeave' table. You can move, or remove it, as needed.
            this.manageEmployeeLeaveTableAdapter.Fill(this.grifindoToysDataSet1.ManageEmployeeLeave);

        }

        private void btnApplyLeave_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();
            mainForm.Show();
            this.Close(); // Close ViewStatus
        }

        private void btnDeleteLeaves_Click(object sender, EventArgs e)
        {
            DeleteLeave DeleteLeaveForm = new DeleteLeave(); // Create instance of ViewStatus form
            DeleteLeaveForm.Show(); // Open new form
            this.Hide(); // Hide the current form
        }
    }
}
