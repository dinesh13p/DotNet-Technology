using System;
using System.Data;
// Ensure you have installed the NuGet package: MySql.Data
using MySql.Data.MySqlClient; 

namespace SQLConnectionExample
{
    internal class Program
    {
        // Your MySQL connection string is correct for XAMPP!
        private static string connectionString = "Server=localhost;Port=3306;Database=bca_fifth;Uid=root;Pwd=;";

        static void Main(string[] args)
        {
            string query = "SELECT * FROM Employee";

            // 1. CHANGED: SqlConnection -> MySqlConnection
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // 2. CHANGED: SqlDataAdapter -> MySqlDataAdapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                // 3. CHANGED: SqlCommandBuilder -> MySqlCommandBuilder
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

                DataSet dataSet = new DataSet();

                try
                {
                    // 1. Load Data into DataSet
                    adapter.Fill(dataSet, "EmployeeTable");
                    DataTable employeeTable = dataSet.Tables["EmployeeTable"];

                    Console.WriteLine("--- Loaded Data from Database ---");
                    LoopAndDisplayRows(employeeTable);

                    // 2. Update Data in memory
                    string targetName = "Dinesh Poudel"; // Example target
                    bool employeeFound = false;

                    foreach (DataRow row in employeeTable.Rows)
                    {
                        if (row["Name"].ToString().Equals(targetName, StringComparison.OrdinalIgnoreCase))
                        {
                            int currentExp = Convert.ToInt32(row["Experience"]);
                            row["Experience"] = currentExp + 1; // Increase experience by 1
                            employeeFound = true;
                            Console.WriteLine($"\n[Memory Update] Found {targetName}. Experience increased from {currentExp} to {row["Experience"]}.");
                            break;
                        }
                    }

                    if (employeeFound)
                    {
                        // Save the modifications back to the Database 
                        adapter.Update(dataSet, "EmployeeTable");
                        Console.WriteLine("Database updated successfully via MySqlDataAdapter.Update().");
                    }
                    else
                    {
                        Console.WriteLine($"\nEmployee named '{targetName}' was not found to update.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }

        // Helper method to loop through DataTable rows and display values
        static void LoopAndDisplayRows(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine($"Name: {row["Name"]}, Department: {row["Department"]}, Experience: {row["Experience"]} years");
            }
        }
    }
}