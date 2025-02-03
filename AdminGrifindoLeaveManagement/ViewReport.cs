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
    public partial class ViewReport : Form
    {
        public ViewReport()
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

        private void btnIndividual_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text))
            {
                MessageBox.Show("Please enter an Employee ID.");
                return;
            }

            // Query to fetch leave records for a specific employee
            string query = "SELECT * FROM ManageEmployeeLeave WHERE EmployeeID = @EmployeeID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = Convert.ToInt32(txtEmployeeID.Text) }
            };

            // Fetch data
            DBConnection dbConnection = new DBConnection();
            DataTable dt = dbConnection.GetData(query, parameters);

            // Update DataGridView
            if (dt.Rows.Count > 0)
            {
                dataGridViewLeaveReport.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No leave records found for this Employee ID.");
                dataGridViewLeaveReport.DataSource = null;
            }
        }

        private void ViewReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindoToysDataSet5.ManageEmployeeLeave' table. You can move, or remove it, as needed.
            this.manageEmployeeLeaveTableAdapter.Fill(this.grifindoToysDataSet5.ManageEmployeeLeave);

        }

        private void btnAllReport_Click(object sender, EventArgs e)
        {
            // Query to fetch all leave records
            string query = "SELECT * FROM ManageEmployeeLeave";

            // Fetch data (Pass an empty parameter array if required)
            DBConnection dbConnection = new DBConnection();
            DataTable dt = dbConnection.GetData(query, new SqlParameter[] { });

            // Update DataGridView
            if (dt.Rows.Count > 0)
            {
                dataGridViewLeaveReport.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No leave records found.");
                dataGridViewLeaveReport.DataSource = null;
            }
        }
    }
}
