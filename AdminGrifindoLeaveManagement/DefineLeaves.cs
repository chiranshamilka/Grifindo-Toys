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
    public partial class DefineLeaves : Form
    {
        public DefineLeaves()
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

        private void DefineLeaves_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindoToysDataSet2.EmployeeLeaves' table. You can move, or remove it, as needed.
            this.employeeLeavesTableAdapter.Fill(this.grifindoToysDataSet2.EmployeeLeaves);

        }

        private void btnAddLeaves_Click(object sender, EventArgs e)
        {
            // Validate EmployeeID
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text))
            {
                MessageBox.Show("Employee ID is required.");
                return;
            }

            // Validate Annual Leaves
            if (!int.TryParse(txtAnnualLeaves.Text, out int annualLeaves) || annualLeaves < 0 || annualLeaves > 14)
            {
                MessageBox.Show("Annual Leaves must be between 0 and 14.");
                return;
            }

            // Validate Casual Leaves
            if (!int.TryParse(txtCasualLeaves.Text, out int casualLeaves) || casualLeaves < 0 || casualLeaves > 7)
            {
                MessageBox.Show("Casual Leaves must be between 0 and 7.");
                return;
            }

            // Check if EmployeeID exists in Users table
            string checkQuery = "SELECT COUNT(*) FROM Users WHERE EmployeeID = @EmployeeID";
            SqlParameter[] checkParams = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = txtEmployeeID.Text }
            };

            DBConnection dbConnection = new DBConnection();
            DataTable dt = dbConnection.GetData(checkQuery, checkParams);

            if (dt.Rows.Count == 0 || Convert.ToInt32(dt.Rows[0][0]) == 0)
            {
                MessageBox.Show("Employee ID not found in Users table.");
                return;
            }

            // Insert query for EmployeeLeaves table
            string query = "INSERT INTO EmployeeLeaves (EmployeeID, AnnualLeaves, CasualLeaves) " +
                           "VALUES (@EmployeeID, @AnnualLeaves, @CasualLeaves)";

            // Parameters for the query
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = txtEmployeeID.Text },
                new SqlParameter("@AnnualLeaves", SqlDbType.Int) { Value = annualLeaves },
                new SqlParameter("@CasualLeaves", SqlDbType.Int) { Value = casualLeaves }
            };

            try
            {
                bool success = dbConnection.InsertData(query, parameters);

                if (success)
                {
                    MessageBox.Show("Leave record added successfully!");

                    // Clear input fields after successful addition
                    txtEmployeeID.Clear();
                    txtAnnualLeaves.Clear();
                    txtCasualLeaves.Clear();

                    // Refresh the DataGridView
                    LoadLeaveData();
                }
                else
                {
                    MessageBox.Show("Failed to add leave record. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}");
            }
        }

        private void LoadLeaveData()
        {
            string query = "SELECT EmployeeID, AnnualLeaves, CasualLeaves FROM EmployeeLeaves";
            DBConnection dbConnection = new DBConnection();
            DataTable dt = dbConnection.GetData(query, null);

            if (dt.Rows.Count > 0)
            {
                EmployeeLeavesDataGrid.DataSource = dt;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Validate EmployeeID input
            if (string.IsNullOrWhiteSpace(txtSearchEmpID.Text))
            {
                MessageBox.Show("Please enter an Employee ID to search.");
                return;
            }

            // SQL query to search EmployeeLeaves table
            string query = "SELECT * FROM EmployeeLeaves WHERE EmployeeID = @EmployeeID";

            // SQL parameter
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = txtSearchEmpID.Text }
            };

            try
            {
                // Fetch data from DB
                DBConnection dbConnection = new DBConnection();
                DataTable dt = dbConnection.GetData(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    // Fill text boxes with fetched data
                    txtAnnualLeaves.Text = dt.Rows[0]["AnnualLeaves"].ToString();
                    txtCasualLeaves.Text = dt.Rows[0]["CasualLeaves"].ToString();
                    txtEmployeeID.Text = dt.Rows[0]["EmployeeID"].ToString();

                    // Update DataGridView with the searched record
                    EmployeeLeavesDataGrid.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No records found for the given Employee ID.");
                    txtAnnualLeaves.Clear();
                    txtCasualLeaves.Clear();
                    txtSearchEmpID.Clear();
                    EmployeeLeavesDataGrid.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Validate EmployeeID input
            if (string.IsNullOrWhiteSpace(txtSearchEmpID.Text))
            {
                MessageBox.Show("Please enter an Employee ID to delete.");
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                                                  "Confirm Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Create a new DB connection
                    DBConnection dbConnection = new DBConnection();

                    // Check if the record exists
                    string checkQuery = "SELECT COUNT(*) FROM EmployeeLeaves WHERE EmployeeID = @EmployeeID";
                    SqlParameter[] checkParams = new SqlParameter[]
                    {
                        new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = txtSearchEmpID.Text }
                    };

                    DataTable dt = dbConnection.GetData(checkQuery, checkParams);

                    if (dt.Rows.Count == 0 || Convert.ToInt32(dt.Rows[0][0]) == 0)
                    {
                        MessageBox.Show("No record found for the given Employee ID.");
                        return;
                    }

                    // Delete the record (use a new SqlParameter array)
                    string deleteQuery = "DELETE FROM EmployeeLeaves WHERE EmployeeID = @EmployeeID";
                    SqlParameter[] deleteParams = new SqlParameter[]
                    {
                        new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = txtSearchEmpID.Text }
                    };

                    bool success = dbConnection.DeleteData(deleteQuery, deleteParams);

                    if (success)
                    {
                        MessageBox.Show("Employee leave record deleted successfully!");

                        // Clear input fields
                        txtEmployeeID.Clear();
                        txtAnnualLeaves.Clear();
                        txtCasualLeaves.Clear();
                        txtSearchEmpID.Clear();

                        // Refresh DataGridView
                        LoadLeaveData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the record. Please try again.");
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"SQL Error: {sqlEx.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occurred: {ex.Message}");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text))
            {
                MessageBox.Show("Employee ID is required.");
                return;
            }

            // Check if the entered EmployeeID exists
            string checkQuery = "SELECT COUNT(*) FROM EmployeeLeaves WHERE EmployeeID = @EmployeeID";
            SqlParameter[] checkParams = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = txtEmployeeID.Text }
            };

            DBConnection dbConnection = new DBConnection();
            DataTable dt = dbConnection.GetData(checkQuery, checkParams);

            if (dt.Rows.Count == 0 || Convert.ToInt32(dt.Rows[0][0]) == 0)
            {
                MessageBox.Show("Employee record not found.");
                return;
            }

            // Validate AnnualLeave and CasualLeave
            int annualLeave = 0;
            int casualLeave = 0;

            if (!int.TryParse(txtAnnualLeaves.Text, out annualLeave) || annualLeave < 0 || annualLeave > 14)
            {
                MessageBox.Show("Annual Leaves must be between 0 and 14.");
                return;
            }

            if (!int.TryParse(txtCasualLeaves.Text, out casualLeave) || casualLeave < 0 || casualLeave > 7)
            {
                MessageBox.Show("Casual Leaves must be between 0 and 7.");
                return;
            }

            // Prepare the UPDATE SQL query
            string updateQuery = "UPDATE EmployeeLeaves SET AnnualLeaves = @AnnualLeaves, CasualLeaves = @CasualLeaves WHERE EmployeeID = @EmployeeID";
            SqlParameter[] updateParams = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = txtEmployeeID.Text },
                new SqlParameter("@AnnualLeaves", SqlDbType.Int) { Value = annualLeave },
                new SqlParameter("@CasualLeaves", SqlDbType.Int) { Value = casualLeave }
            };

            try
            {
                // Call UpdateData method
                bool success = dbConnection.UpdateData(updateQuery, updateParams);

                if (success)
                {
                    MessageBox.Show("Employee leave record updated successfully!");

                    // Clear fields after update
                    txtEmployeeID.Clear();
                    txtAnnualLeaves.Clear();
                    txtCasualLeaves.Clear();
                    txtSearchEmpID.Clear();

                    // Refresh the DataGridView
                    LoadLeaveData();
                }
                else
                {
                    MessageBox.Show("Failed to update the employee leave record. Please try again.");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear fields after update
            txtEmployeeID.Clear();
            txtAnnualLeaves.Clear();
            txtCasualLeaves.Clear();
            txtSearchEmpID.Clear();
        }
    }
}
