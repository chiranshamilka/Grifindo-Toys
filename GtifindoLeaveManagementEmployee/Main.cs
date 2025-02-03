using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GtifindoLeaveManagementEmployee
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Optionally, confirm before closing
            var confirmResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();  // Closes the entire application
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindoToysDataSet.ManageEmployeeLeave' table. You can move, or remove it, as needed.
            this.manageEmployeeLeaveTableAdapter.Fill(this.grifindoToysDataSet.ManageEmployeeLeave);

        }

        private void BtnApplyLeaves_Click(object sender, EventArgs e)
        {
            int employeeID = SessionManager.EmployeeID;
            string leaveType = cmbLeaveType.SelectedItem?.ToString();
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            int noOfDays = (int)(endDate.Date - startDate.Date).TotalDays;

            if (string.IsNullOrEmpty(leaveType))
            {
                MessageBox.Show("Please select a leave type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (startDate > endDate)
            {
                MessageBox.Show("End date must be after start date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DBConnection db = new DBConnection();
            try
            {
                bool success = db.ApplyLeave(employeeID, leaveType, startDate, endDate, noOfDays);

                if (success)
                {
                    MessageBox.Show("Leave applied successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLeaveData(); // Refresh DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLeaveData()
        {
            DBConnection db = new DBConnection();
            string query = "SELECT LeaveID, EmployeeID, StartDateTime, EndDateTime, NoOfLeaveDays FROM ManageEmployeeLeave WHERE EmployeeID = @employeeID";

            SqlParameter[] parameters = {
                new SqlParameter("@employeeID", SessionManager.EmployeeID)
             };

            DataTable dt = db.GetData(query, parameters);

            if (dt.Rows.Count > 0)
            {
                dgvLeaves.DataSource = dt; // Bind DataGridView to DataTable
            }
            else
            {
                dgvLeaves.DataSource = null; // Clear if no data
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbLeaveType.SelectedIndex = -1; // Clear Leave Type selection
            dtpStartDate.Value = DateTime.Today; // Reset Start Date to today
            dtpEndDate.Value = DateTime.Today; // Reset End Date to today
            NoOfDays.Clear();
        }

        private void btnViewStatus_Click(object sender, EventArgs e)
        {
            ViewStatus viewStatusForm = new ViewStatus(); // Create instance of ViewStatus form
            viewStatusForm.Show(); // Open new form
            this.Hide(); // Hide the current form
        }

        private void btnDeleteLeaves_Click(object sender, EventArgs e)
        {
            DeleteLeave DeleteLeaveForm = new DeleteLeave(); // Create instance of ViewStatus form
            DeleteLeaveForm.Show(); // Open new form
            this.Hide(); // Hide the current form
        }
    }
}
