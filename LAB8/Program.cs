using System;
using Microsoft.Data.SqlClient; // Note: Use System.Data.SqlClient if on older .NET Framework

class LabTask8
{
    private static string connectionString = "Server=YOUR_SERVER;Database=YOUR_DB;Trusted_Connection=True;TrustServerCertificate=True;";

    static void Main()
    {
        // Execute Task 1: Retrieve Data
        Console.WriteLine("--- Retrieving Active Employees ---");
        RetrieveEmployees();

        // Execute Task 2: Insert Data
        Console.WriteLine("\n--- Inserting New Employee ---");
        InsertEmployee("David Miller", 65000, "IT", false, 4);

        // Verify insertion by running retrieval again
        Console.WriteLine("\n--- Retrieving Active Employees After Insertion ---");
        RetrieveEmployees();
    }

    // 1. Retrieve Data (Read)
    static void RetrieveEmployees()
    {
        string query = "SELECT Name, Salary FROM Employee WHERE IsResigned = 0";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            
            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Displaying Name and Salary
                        string name = reader["Name"].ToString();
                        double salary = Convert.ToDouble(reader["Salary"]);
                        Console.WriteLine($"Name: {name}, Salary: ${salary}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }

    // 2. Insert Data (Write) using parameterized queries
    static void InsertEmployee(string name, double salary, string department, bool isResigned, int experience)
    {
        string query = "INSERT INTO Employee (Name, Salary, Department, IsResigned, Experience) " +
                       "VALUES (@Name, @Salary, @Department, @IsResigned, @Experience)";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);

            // Adding parameters to prevent SQL Injection
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Salary", salary);
            command.Parameters.AddWithValue("@Department", department);
            command.Parameters.AddWithValue("@IsResigned", isResigned ? 1 : 0);
            command.Parameters.AddWithValue("@Experience", experience);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) successfully inserted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during insert: {ex.Message}");
            }
        }
    }
}