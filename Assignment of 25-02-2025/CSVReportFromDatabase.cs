using System;
using System.Data.SqlClient;
using System.IO;
using System.Collections.Generic;
class Program {
    static void Main(string[] args) {
        string connectionString = "Server=YOUR_SERVER;Database=YOUR_DATABASE;Trusted_Connection=True;";
        string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";
        string outputFile = "employee_report.csv";
        List<string> lines = new List<string>();
        lines.Add("Employee ID,Name,Department,Salary");
        using (SqlConnection connection = new SqlConnection(connectionString)) {
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection)) {
                using (SqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        string line = reader["EmployeeID"] + "," +
                                      reader["Name"] + "," +
                                      reader["Department"] + "," +
                                      reader["Salary"];
                        lines.Add(line);
                    }
                }
            }
        }
        File.WriteAllLines(outputFile, lines);
        Console.WriteLine("CSV report generated: " + outputFile);
    }
}
