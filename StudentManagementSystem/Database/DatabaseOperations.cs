using System;
using System.Data;
using System.Data.Odbc;

namespace StudentManagementSystem.Database
{
    public class DatabaseOperations
    {
        private DatabaseConnection dbcon;

        public DatabaseOperations(string connectionString)
        {
            dbcon = new DatabaseConnection(connectionString);
        }

        // Execute Non-Queries (No return values)
        public int ExecuteNonQuery(string query, params OdbcParameter[] parameters)
        {
            int rowsAffected = 0;

            using (var connection = dbcon.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (OdbcCommand command = new OdbcCommand(query, connection))
                    {
                        command.Parameters.AddRange(parameters);
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error executing query: {ex.Message}");
                }
            }
            return rowsAffected;
        }

        // Execute Select Queries (Returns a DataTable Object)
        public DataTable ExecuteSelectQuery(string query, params OdbcParameter[] parameters)
        {
            DataTable resultTable = new DataTable();

            try
            {
                using (var connection = dbcon.GetConnection())
                {
                    connection.Open();

                    using (var command = new OdbcCommand(query, connection))
                    {
                        command.Parameters.AddRange(parameters);
                        using (OdbcDataAdapter dataAdapter = new OdbcDataAdapter(command))
                        {
                            dataAdapter.Fill(resultTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing query: {ex.Message}");
            }

            return resultTable;
        }

        // Execute Scalar Queries
        public int ExecuteScalarQuery(string query, params OdbcParameter[] parameters)
        {
            try
            {
                using (var connection = dbcon.GetConnection())
                {
                    connection.Open();

                    using (var command = new OdbcCommand(query, connection))
                    {
                        command.Parameters.AddRange(parameters);
                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing scalar query: {ex.Message}");
                return 0;
            }
        }
    }
}
