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
    public partial class DefineRoster : Form
    {
        public DefineRoster()
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

        private void DefineRoster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindoToysDataSet3.Roster' table. You can move, or remove it, as needed.
            this.rosterTableAdapter.Fill(this.grifindoToysDataSet3.Roster);

        }

        private void btnAddRoster_Click(object sender, EventArgs e)
        {
            // Validate EmployeeID
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text))
            {
                MessageBox.Show("Employee ID is required.");
                return;
            }

            if (dateTimePickerDutyDate.Value < DateTime.Today)
            {
                MessageBox.Show("Duty Date cannot be in the past.");
                return;
            }

            // Extract TimeSpan values from DateTimePickers
            TimeSpan startTime = txtStartTime.Value.TimeOfDay;
            TimeSpan endTime = txtEndTime.Value.TimeOfDay;

            if (startTime >= endTime)
            {
                MessageBox.Show("Starting Time must be earlier than Ending Time.");
                return;
            }

            // Check if EmployeeID exists in Users table
            string checkQuery = "SELECT COUNT(*) FROM Users WHERE EmployeeID = @EmployeeID";
            SqlParameter[] checkParams = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = Convert.ToInt32(txtEmployeeID.Text) }
            };

            DBConnection dbConnection = new DBConnection();
            DataTable dt = dbConnection.GetData(checkQuery, checkParams);

            if (dt.Rows.Count == 0 || Convert.ToInt32(dt.Rows[0][0]) == 0)
            {
                MessageBox.Show("Employee ID not found. Please check and try again.");
                return;
            }

            // Insert data into Roster table
            string insertQuery = "INSERT INTO Roster (EmployeeID, DutyDate, StartingTime, EndingTime) " +
                                 "VALUES (@EmployeeID, @DutyDate, @StartingTime, @EndingTime)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = Convert.ToInt32(txtEmployeeID.Text) },
                new SqlParameter("@DutyDate", SqlDbType.Date) { Value = dateTimePickerDutyDate.Value.Date },
                new SqlParameter("@StartingTime", SqlDbType.Time) { Value = startTime },
                new SqlParameter("@EndingTime", SqlDbType.Time) { Value = endTime }
            };

            bool success = dbConnection.InsertData(insertQuery, parameters);

            if (success)
            {
                MessageBox.Show("Roster added successfully!");
                LoadRosterData(); // Refresh DataGridView
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to add roster. Please try again.");
            }
        }

        private void ClearFields()
        {
            txtEmployeeID.Clear();
            dateTimePickerDutyDate.Value = DateTime.Today;

       

        }

        // Method to load roster data into DataGridView
        private void LoadRosterData()
        {
            string query = "SELECT * FROM Roster";
            DataTable dt = new DBConnection().GetData(query, null);
            EmployeeRosterDataGrid.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtSearchEmpID.Text))
            {
                MessageBox.Show("Please enter an Employee ID.");
                return;
            }

            // SQL query to search for roster details
            string searchQuery = "SELECT EmployeeID, DutyDate, StartingTime, EndingTime FROM Roster WHERE EmployeeID = @EmployeeID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = Convert.ToInt32(txtSearchEmpID.Text) }
            };

            // Execute query
            DBConnection dbConnection = new DBConnection();
            DataTable dt = dbConnection.GetData(searchQuery, parameters);

            if (dt.Rows.Count > 0)
            {
                // Fill data in text boxes
                dateTimePickerDutyDate.Value = Convert.ToDateTime(dt.Rows[0]["DutyDate"]);

                // Set Start and End time properly
                txtStartTime.Value = DateTime.Today.Add((TimeSpan)dt.Rows[0]["StartingTime"]);
                txtEndTime.Value = DateTime.Today.Add((TimeSpan)dt.Rows[0]["EndingTime"]);

                // Set EmployeeID
                txtEmployeeID.Text = dt.Rows[0]["EmployeeID"].ToString();

                // Update DataGridView
                EmployeeRosterDataGrid.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No roster records found for this Employee ID.");
                EmployeeRosterDataGrid.DataSource = null;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate EmployeeID
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text))
            {
                MessageBox.Show("Employee ID is required.");
                return;
            }

            if (dateTimePickerDutyDate.Value < DateTime.Today)
            {
                MessageBox.Show("Duty Date cannot be in the past.");
                return;
            }

            // Ensure txtStartTime and txtEndTime are DateTimePickers
            if (!(txtStartTime is DateTimePicker) || !(txtEndTime is DateTimePicker))
            {
                MessageBox.Show("Start Time and End Time must be valid date pickers.");
                return;
            }

            // Extract TimeSpan values from DateTimePickers (Same as Add)
            TimeSpan startTime = ((DateTimePicker)txtStartTime).Value.TimeOfDay;
            TimeSpan endTime = ((DateTimePicker)txtEndTime).Value.TimeOfDay;

            if (startTime >= endTime)
            {
                MessageBox.Show("Starting Time must be earlier than Ending Time.");
                return;
            }

            // Check if EmployeeID exists in Roster table
            string checkQuery = "SELECT COUNT(*) FROM Roster WHERE EmployeeID = @EmployeeID";
            SqlParameter[] checkParams = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = Convert.ToInt32(txtEmployeeID.Text) }
            };

            DBConnection dbConnection = new DBConnection();
            DataTable dt = dbConnection.GetData(checkQuery, checkParams);

            if (dt.Rows.Count == 0 || Convert.ToInt32(dt.Rows[0][0]) == 0)
            {
                MessageBox.Show("Roster entry not found for this Employee ID.");
                return;
            }

            // Update query
            string updateQuery = "UPDATE Roster SET DutyDate = @DutyDate, StartingTime = @StartingTime, EndingTime = @EndingTime WHERE EmployeeID = @EmployeeID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@DutyDate", SqlDbType.Date) { Value = dateTimePickerDutyDate.Value.Date },
                new SqlParameter("@StartingTime", SqlDbType.Time) { Value = startTime },
                new SqlParameter("@EndingTime", SqlDbType.Time) { Value = endTime },
                new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = Convert.ToInt32(txtEmployeeID.Text) }
            };

            bool success = dbConnection.UpdateData(updateQuery, parameters);

            if (success)
            {
                MessageBox.Show("Roster updated successfully!");
                LoadRosterData(); // Refresh DataGridView
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to update roster. Please try again.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Validate that EmployeeID is entered
            if (string.IsNullOrWhiteSpace(txtSearchEmpID.Text))
            {
                MessageBox.Show("Please enter an Employee ID.");
                return;
            }

            // Confirm with the user before deleting
            DialogResult result = MessageBox.Show("Are you sure you want to delete this roster record?",
                                                  "Confirm Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // SQL query to check if record exists
                string checkQuery = "SELECT COUNT(*) FROM Roster WHERE EmployeeID = @EmployeeID AND DutyDate = @DutyDate";

                // Prepare parameters for SQL query
                SqlParameter[] checkParams = new SqlParameter[]
                {
                    new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = Convert.ToInt32(txtSearchEmpID.Text) },
                    new SqlParameter("@DutyDate", SqlDbType.Date) { Value = dateTimePickerDutyDate.Value.Date }
                };

                // Execute check query
                DBConnection dbConnection = new DBConnection();
                DataTable dt = dbConnection.GetData(checkQuery, checkParams);

                // Check if the record exists
                if (dt.Rows.Count == 0 || Convert.ToInt32(dt.Rows[0][0]) == 0)
                {
                    MessageBox.Show("No record found to delete for this Employee ID and Duty Date.");
                    return;
                }

                // SQL query to delete the roster record by EmployeeID and DutyDate
                string deleteQuery = "DELETE FROM Roster WHERE EmployeeID = @EmployeeID AND DutyDate = @DutyDate";

                // Create new parameters for the DELETE query to avoid reusing the same parameter objects
                SqlParameter[] deleteParams = new SqlParameter[]
                {
                    new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = Convert.ToInt32(txtSearchEmpID.Text) },
                    new SqlParameter("@DutyDate", SqlDbType.Date) { Value = dateTimePickerDutyDate.Value.Date }
                };

                // Execute the delete query
                bool success = dbConnection.DeleteData(deleteQuery, deleteParams); // Use new parameters for deletion

                if (success)
                {
                    MessageBox.Show("Roster record deleted successfully!");
                    LoadRosterData(); // Refresh DataGridView
                    ClearFields(); // Clear input fields
                }
                else
                {
                    MessageBox.Show("Failed to delete the roster record. Please try again.");
                }
            }
        }
    }
}
