using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GtifindoLeaveManagementEmployee
{
    internal class DBConnection
    {
        private readonly string connectionString = @"Data Source=YENASYS\SQLEXPRESS;Initial Catalog=GrifindoToys;Integrated Security=True;";
        private SqlConnection connection;

        public DBConnection()
        {
            connection = new SqlConnection(connectionString);
        }

        public SqlConnection OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            return connection;
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        // **INSERT Operation**
        public bool InsertData(string query, SqlParameter[] parameters)
        {
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            finally
            {
                CloseConnection();
            }
        }

        // **UPDATE Operation**
        public bool UpdateData(string query, SqlParameter[] parameters)
        {
            return InsertData(query, parameters); // Same as Insert
        }

        // **DELETE Operation**
        public bool DeleteData(string query, SqlParameter[] parameters)
        {
            return InsertData(query, parameters); // Same as Insert
        }

        // **SELECT Operation**
        public DataTable GetData(string query, SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }

        public bool ValidateUser(string username, string password)
        {
            try
            {
                OpenConnection();
                string query = "SELECT EmployeeID FROM Users WHERE EmployeeName = @username AND Password = @password AND UserRole = 'Employee'";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // Hash in production

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        SessionManager.EmployeeID = Convert.ToInt32(result); // Store EmployeeID globally
                        SessionManager.EmployeeName = username; // Store username if needed
                        return true;
                    }
                }
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool ApplyLeave(int employeeID, string leaveType, DateTime startDate, DateTime endDate, int noOfDays)
        {
            try
            {
                OpenConnection();
                using (SqlTransaction transaction = connection.BeginTransaction()) // Start transaction
                {
                    try
                    {
                        // Insert Leave Request
                        string insertQuery = "INSERT INTO ManageEmployeeLeave (EmployeeID, StartDateTime, EndDateTime, NoOfLeaveDays) VALUES (@employeeID, @startDate, @endDate, @noOfDays)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@employeeID", employeeID);
                            //cmd.Parameters.AddWithValue("@leaveType", leaveType);
                            cmd.Parameters.AddWithValue("@startDate", startDate);
                            cmd.Parameters.AddWithValue("@endDate", endDate);
                            cmd.Parameters.AddWithValue("@noOfDays", noOfDays);
                            cmd.ExecuteNonQuery();
                        }

                        // Deduct leave from EmployeeLeaves table
                        string updateQuery = $"UPDATE EmployeeLeaves SET {leaveType} = {leaveType} - @noOfDays WHERE EmployeeID = @employeeID AND {leaveType} >= @noOfDays";
                        using (SqlCommand cmd = new SqlCommand(updateQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@employeeID", employeeID);
                            cmd.Parameters.AddWithValue("@noOfDays", noOfDays);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected == 0)
                            {
                                throw new Exception("Insufficient leave balance!");
                            }
                        }

                        transaction.Commit(); // Commit transaction
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback(); // Rollback if error
                        throw;
                    }
                }
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool DeleteLeave(int leaveID, int employeeID, string leaveType, int noOfDays)
        {
            try
            {
                OpenConnection();

                // Step 1: Delete leave record from ManageEmployeeLeave
                string deleteQuery = "DELETE FROM ManageEmployeeLeave WHERE LeaveID = @leaveID AND EmployeeID = @employeeID";

                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection))
                {
                    deleteCmd.Parameters.AddWithValue("@leaveID", leaveID);
                    deleteCmd.Parameters.AddWithValue("@employeeID", employeeID);

                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0) // If deletion was successful
                    {
                        // Step 2: Determine which column to update in EmployeeLeaves
                        string updateQuery;
                        if (leaveType == "AnnualLeaves")
                        {
                            updateQuery = "UPDATE EmployeeLeaves SET AnnualLeaves = AnnualLeaves + @noOfDays WHERE EmployeeID = @employeeID";
                        }
                        else if (leaveType == "CasualLeaves")
                        {
                            updateQuery = "UPDATE EmployeeLeaves SET CasualLeaves = CasualLeaves + @noOfDays WHERE EmployeeID = @employeeID";
                        }
                        else
                        {
                            return false; // Invalid leave type
                        }

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                        {
                            updateCmd.Parameters.AddWithValue("@noOfDays", noOfDays);
                            updateCmd.Parameters.AddWithValue("@employeeID", employeeID);
                            updateCmd.ExecuteNonQuery();
                        }

                        return true; // Successfully deleted and updated
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
            return false;

        }

    }
}
