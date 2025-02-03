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

namespace AdminGrifindoLeaveManagement
{
    public partial class DecisionLeaves : Form
    {
        public DecisionLeaves()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Terminates the application
            }
        }

        private void btnGoback_Click(object sender, EventArgs e)
        {
            this.Close(); // Hide the current form
            MainMenu mainMenuForm = new MainMenu(); // Create the MainMenu form instance
            mainMenuForm.Show(); // Show the MainMenu form
        }

        private void btnApproved_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtLeaveID.Text))
            {
                MessageBox.Show("Please enter a valid Leave ID.");
                return;
            }

            // Prepare the UPDATE SQL query
            string updateQuery = "UPDATE ManageEmployeeLeave SET Decision = 'Approved' WHERE LeaveID = @LeaveID";

            // Define SQL parameter
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@LeaveID", SqlDbType.Int) { Value = Convert.ToInt32(txtLeaveID.Text) }
            };

            // Execute the update query
            DBConnection dbConnection = new DBConnection();
            bool success = dbConnection.UpdateData(updateQuery, parameters);

            if (success)
            {
                MessageBox.Show("Leave request approved successfully!");
                LoadLeaveData(); // Refresh DataGridView
            }
            else
            {
                MessageBox.Show("Failed to approve leave request. Please try again.");
            }
        }

        private void DecisionLeaves_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindoToysDataSet4.ManageEmployeeLeave' table. You can move, or remove it, as needed.
            this.manageEmployeeLeaveTableAdapter.Fill(this.grifindoToysDataSet4.ManageEmployeeLeave);

        }

        private void btnRejected_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtLeaveID.Text))
            {
                MessageBox.Show("Please enter a valid Leave ID.");
                return;
            }

            // Prepare the UPDATE SQL query
            string updateQuery = "UPDATE ManageEmployeeLeave SET Decision = 'Not Approved' WHERE LeaveID = @LeaveID";

            // Define SQL parameter
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@LeaveID", SqlDbType.Int) { Value = Convert.ToInt32(txtLeaveID.Text) }
            };

            // Execute the update query
            DBConnection dbConnection = new DBConnection();
            bool success = dbConnection.UpdateData(updateQuery, parameters);

            if (success)
            {
                MessageBox.Show("Leave request rejected successfully!");
                LoadLeaveData(); // Refresh DataGridView
            }
            else
            {
                MessageBox.Show("Failed to reject leave request. Please try again.");
            }
        }

        private void LoadLeaveData()
        {
            // SQL query to fetch all leave records
            string query = "SELECT LeaveID, EmployeeID, StartDateTime, EndDateTime, NoOfLeaveDays, Decision FROM ManageEmployeeLeave";

            // Execute query with an empty parameter list
            DBConnection dbConnection = new DBConnection();
            DataTable dt = dbConnection.GetData(query, new SqlParameter[] { });

            // Bind data to DataGridView
            if (dt.Rows.Count > 0)
            {
                EmployeeLeaveDataGrid.DataSource = dt;
            }
            else
            {
                EmployeeLeaveDataGrid.DataSource = null;
                MessageBox.Show("No leave records found.");
            }
        }
    }
}
