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
    public partial class DeleteLeave : Form
    {
        public DeleteLeave()
        {
            InitializeComponent();
        }

        private void DeleteLeave_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindoToysDataSet2.ManageEmployeeLeave' table. You can move, or remove it, as needed.
            this.manageEmployeeLeaveTableAdapter.Fill(this.grifindoToysDataSet2.ManageEmployeeLeave);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLeaves.SelectedRows.Count > 0) // Ensure a row is selected
            {
                int leaveID = Convert.ToInt32(LeaveID.Text);
                string leaveType = cmbLeaveType.Text;
                int employeeID = SessionManager.EmployeeID; // Get employee ID from session
                int noOfDays = Convert.ToInt32(dgvLeaves.SelectedRows[0].Cells["NoOfDays"].Value);

                DBConnection db = new DBConnection();
                bool success = db.DeleteLeave(leaveID, employeeID, leaveType, noOfDays);

                if (success)
                {
                    MessageBox.Show("Leave deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLeaveData(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to delete leave!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a leave record to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadLeaveData()
        {
            DBConnection db = new DBConnection();
            string query = "SELECT LeaveID, NoOfLeaveDays, StartDateTime, EndDateTime FROM ManageEmployeeLeave WHERE EmployeeID = @employeeID";
            SqlParameter[] parameters = { new SqlParameter("@employeeID", SessionManager.EmployeeID) };

            dgvLeaves.DataSource = db.GetData(query, parameters);
        }
    }
}
