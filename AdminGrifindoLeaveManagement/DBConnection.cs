using System;
using System.Data;
using System.Data.SqlClient;

namespace AdminGrifindoLeaveManagement
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
                string query = "SELECT COUNT(*) FROM Users WHERE EmployeeName = @username AND Password = @password";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // Consider hashing in production

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // Returns true if user exists
                }
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
