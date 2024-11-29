using System;
using System.Data.Odbc;
using System.Windows.Forms;

namespace StudentManagementSystem.Database
{
    public class DatabaseConnection
    {
        private OdbcConnection connection;

        //Connection String
        private readonly string connectionString = "DRIVER={MySQL ODBC 9.1 Unicode Driver};" +
                              "SERVER=localhost;" +
                              "DATABASE=smsdatabase;" +
                              "USER=root;" +
                              "PASSWORD=admin;";
        public DatabaseConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }
        
        //Get Connection
        public OdbcConnection GetConnection()
        {
            return new OdbcConnection(connectionString);
        }

        //Test Connection
        public bool TestConnection()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    MessageBox.Show("Database connection successful.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection failed: {ex.Message}");
                return false;
            }
        }
        // Open Connection
        public void OpenConnection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Database connection opened successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening connection: " + ex.Message);
            }
        }

        // Close Connection
        public void CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Database connection closed successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error closing connection: " + ex.Message);
            }
        }
    }
}