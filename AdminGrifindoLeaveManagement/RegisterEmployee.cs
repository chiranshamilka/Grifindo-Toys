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
    public partial class RegisterEmployee : Form
    {
        public RegisterEmployee()
        {
            InitializeComponent();
        }

        private void lblUserRole_Click(object sender, EventArgs e)
        {

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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text))
            {
                MessageBox.Show("Employee ID is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.");
                return;
            }

            if (dateTimePickerDOB.Value >= DateTime.Today)
            {
                MessageBox.Show("Date of Birth cannot be today or in the future.");
                return;
            }

            if (dateTimePickerJoinDate.Value >= DateTime.Today)
            {
                MessageBox.Show("Join Date cannot be today or in the future.");
                return;
            }

            if (combUserRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a user role.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is required.");
                return;
            }

            // Check if the EmployeeID already exists
            string checkQuery = "SELECT COUNT(*) FROM Users WHERE EmployeeID = @EmployeeID";
            SqlParameter[] checkParameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID", SqlDbType.VarChar) { Value = txtEmployeeID.Text }
            };

            DBConnection dbConnection = new DBConnection();
            DataTable dt = dbConnection.GetData(checkQuery, checkParameters);

            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                MessageBox.Show("Employee ID already exists. Please choose a different ID.");
                return;
            }

            // Prepare parameters for SQL query
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID", SqlDbType.VarChar) { Value = txtEmployeeID.Text },
                new SqlParameter("@EmployeeName", SqlDbType.VarChar) { Value = txtName.Text },
                new SqlParameter("@DOB", SqlDbType.Date) { Value = dateTimePickerDOB.Value },
                new SqlParameter("@JoinedDate", SqlDbType.Date) { Value = dateTimePickerJoinDate.Value },
                new SqlParameter("@UserRole", SqlDbType.VarChar) { Value = combUserRole.SelectedItem.ToString() },
                new SqlParameter("@Password", SqlDbType.VarChar) { Value = txtPassword.Text }
            };

            // SQL Insert query
            string query = "INSERT INTO Users (EmployeeID, EmployeeName, DOB, JoinedDate, UserRole, Password) " +
                           "VALUES (@EmployeeID, @EmployeeName, @DOB, @JoinedDate, @UserRole, @Password)";

            try
            {
                // Call InsertData
                bool success = dbConnection.InsertData(query, parameters);

                if (success)
                {
                    MessageBox.Show("Employee registered successfully!");
                    // Optional: Clear fields after successful registration
                    txtEmployeeID.Clear();
                    txtName.Clear();
                    dateTimePickerDOB.Value = DateTime.Today;
                    dateTimePickerJoinDate.Value = DateTime.Today;
                    combUserRole.SelectedIndex = -1;
                    txtPassword.Clear();

                    EmployeeRegDataGrid.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Failed to register the employee. Please try again.");
                }
            }
            catch (Exception ex)
            {
                // Show error message if an exception occurs
                MessageBox.Show($"Error occurred: {ex.Message}");
            }
        }

        private void RegisterEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindoToysDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.grifindoToysDataSet1.Users);

        }

        private void EmployeeRegDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Validate if EmployeeID is entered
            if (string.IsNullOrWhiteSpace(txtsearchEmpID.Text))
            {
                MessageBox.Show("Please enter an Employee ID to search.");
                return;
            }

            // SQL query to search for the employee by EmployeeID
            string query = "SELECT EmployeeID, EmployeeName, DOB, JoinedDate, UserRole, Password FROM Users WHERE EmployeeID = @EmployeeID";

            // Prepare parameters
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID", SqlDbType.VarChar) { Value = txtsearchEmpID.Text }
            };

            // Create an instance of DBConnection
            DBConnection dbConnection = new DBConnection();

            // Get the data for the employee
            DataTable dt = dbConnection.GetData(query, parameters);

            if (dt.Rows.Count > 0)
            {
                // Populate the DataGridView with the result (optional)
                EmployeeRegDataGrid.DataSource = dt;

                // Fill the textboxes and combobox with the corresponding employee data
                DataRow row = dt.Rows[0]; // Assuming EmployeeID is unique, we'll get the first result
                txtEmployeeID.Text = row["EmployeeID"].ToString();  // Fill EmployeeID (if needed)
                txtName.Text = row["EmployeeName"].ToString();
                dateTimePickerDOB.Value = Convert.ToDateTime(row["DOB"]);
                dateTimePickerJoinDate.Value = Convert.ToDateTime(row["JoinedDate"]);
                combUserRole.SelectedItem = row["UserRole"].ToString();  // Set the UserRole in combobox

                // Mask the password field (you can either display it or keep it hidden)
                txtPassword.Text = row["Password"].ToString(); // Set password (masked when shown in TextBox)
                txtPassword.PasswordChar = '*'; // Mask the password
            }
            else
            {
                MessageBox.Show("Employee not found.");
                EmployeeRegDataGrid.DataSource = null;  // Clear the DataGridView if no result is found
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Optional: Clear fields after successful registration
            txtEmployeeID.Clear();
            txtName.Clear();
            dateTimePickerDOB.Value = DateTime.Today;
            dateTimePickerJoinDate.Value = DateTime.Today;
            combUserRole.SelectedIndex = -1;
            txtPassword.Clear();
            txtsearchEmpID.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate that EmployeeID is entered
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text))
            {
                MessageBox.Show("Employee ID is required.");
                return;
            }

            // Prepare parameters list for the SQL update query
            List<SqlParameter> parameters = new List<SqlParameter>();
            string updateQuery = "UPDATE Users SET ";

            // Flag to check if we are adding a field to the query
            bool firstField = true;

            // Only add fields that the user has entered

            // Add EmployeeName to the update query if it's filled
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                if (!firstField) updateQuery += ", ";
                updateQuery += "EmployeeName = @EmployeeName";
                parameters.Add(new SqlParameter("@EmployeeName", SqlDbType.VarChar) { Value = txtName.Text });
                firstField = false;
            }

            // Add DOB to the update query if it's filled
            if (dateTimePickerDOB.Value != DateTime.Today)  // Check if a valid date is selected
            {
                if (!firstField) updateQuery += ", ";
                updateQuery += "DOB = @DOB";
                parameters.Add(new SqlParameter("@DOB", SqlDbType.Date) { Value = dateTimePickerDOB.Value });
                firstField = false;
            }

            // Add JoinedDate to the update query if it's filled
            if (dateTimePickerJoinDate.Value != DateTime.Today)  // Check if a valid date is selected
            {
                if (!firstField) updateQuery += ", ";
                updateQuery += "JoinedDate = @JoinedDate";
                parameters.Add(new SqlParameter("@JoinedDate", SqlDbType.Date) { Value = dateTimePickerJoinDate.Value });
                firstField = false;
            }

            // Add UserRole to the update query if it's selected
            if (combUserRole.SelectedIndex != -1)  // Ensure a role is selected
            {
                if (!firstField) updateQuery += ", ";
                updateQuery += "UserRole = @UserRole";
                parameters.Add(new SqlParameter("@UserRole", SqlDbType.VarChar) { Value = combUserRole.SelectedItem.ToString() });
                firstField = false;
            }

            // Add Password to the update query if it's filled
            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                if (!firstField) updateQuery += ", ";
                updateQuery += "Password = @Password";
                parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar) { Value = txtPassword.Text });
                firstField = false;
            }

            // Ensure there's at least one field to update
            if (firstField)
            {
                MessageBox.Show("No fields have been modified.");
                return;
            }

            // Add the WHERE clause to the query
            updateQuery += " WHERE EmployeeID = @EmployeeID";
            parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.VarChar) { Value = txtEmployeeID.Text });

            try
            {
                DBConnection dbConnection = new DBConnection();
                bool success = dbConnection.UpdateData(updateQuery, parameters.ToArray());

                if (success)
                {
                    MessageBox.Show("Employee details updated successfully!");
                    // Optionally, clear the fields after successful update
                    txtEmployeeID.Clear();
                    txtName.Clear();
                    dateTimePickerDOB.Value = DateTime.Today;
                    dateTimePickerJoinDate.Value = DateTime.Today;
                    combUserRole.SelectedIndex = -1;
                    txtPassword.Clear();  // Don't update the password unless explicitly needed
                }
                else
                {
                    MessageBox.Show("Failed to update employee details. Please try again.");
                }
            }
            catch (Exception ex)
            {
                // Show error message if an exception occurs
                MessageBox.Show($"Error occurred: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Validate EmployeeID input
            if (string.IsNullOrWhiteSpace(txtsearchEmpID.Text))
            {
                MessageBox.Show("Employee ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm with the user before deleting
            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee record?",
                                                  "Confirm Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            // Initialize database connection
            DBConnection dbConnection = new DBConnection();

            try
            {
                // Check if EmployeeID exists
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE EmployeeID = @EmployeeID";
                SqlParameter[] checkParam = { new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = int.Parse(txtsearchEmpID.Text) } };

                DataTable dt = dbConnection.GetData(checkQuery, checkParam);
                if (dt.Rows.Count == 0 || Convert.ToInt32(dt.Rows[0][0]) == 0)
                {
                    MessageBox.Show("Employee ID not found. Please check the ID and try again.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Delete Employee record
                string deleteQuery = "DELETE FROM Users WHERE EmployeeID = @EmployeeID";
                SqlParameter[] deleteParam = { new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = int.Parse(txtsearchEmpID.Text) } };

                bool success = dbConnection.DeleteData(deleteQuery, deleteParam);

                if (success)
                {
                    MessageBox.Show("Employee record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear input fields
                    ClearFields();

                    // Reload Data Grid View
                    LoadUserData();
                }
                else
                {
                    MessageBox.Show("Failed to delete the employee record. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // **Helper method to clear fields after deletion**
        private void ClearFields()
        {
            txtsearchEmpID.Clear();
            txtEmployeeID.Clear();
            txtName.Clear();
            dateTimePickerDOB.Value = DateTime.Today;
            dateTimePickerJoinDate.Value = DateTime.Today;
            combUserRole.SelectedIndex = -1;
            txtPassword.Clear();
        }

        // **Method to reload user data into DataGridView**
        private void LoadUserData()
        {
            string query = "SELECT EmployeeID, EmployeeName, DOB, JoinedDate, UserRole FROM Users"; // Excluding password for security
            DBConnection dbConnection = new DBConnection();
            DataTable dt = dbConnection.GetData(query, null);
            EmployeeRegDataGrid.DataSource = dt;
        }
    }
}
