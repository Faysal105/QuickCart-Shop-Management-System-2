using System;
using System.Data;
using System.Data.SqlClient;

namespace QuickCart_Shop_Management
{
    public class DatabaseAccess
    {
        private readonly string connectionString;

        public DatabaseAccess()
        {
            // Update your SQL Server details here
            //connectionString = "Data Source=TANVIR\\SQLEXPRESS;Initial Catalog=\"QuickCart Shop Management\";Persist Security Info=True;User ID=sa;Password=tanvir123";
            connectionString = "Data Source=DESKTOP-8NE2U85\\FAYSAL;Initial Catalog=\"QuickCart Shop Management\";Integrated Security=True";
            // If using SQL authentication:
            // connectionString = "Server=YOUR_SERVER_NAME;Database=QuickCart;User Id=USERNAME;Password=PASSWORD;";
        }

        // Open Connection
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Execute non-query (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Execute scalar (return single value)
        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        // Execute reader (SELECT queries)
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
