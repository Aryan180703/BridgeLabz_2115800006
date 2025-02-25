using System;
using System.IO;
using System.Linq;
class Program {
    static void Main(string[] args) {
        string filePath = "employees.csv";
        if (!File.Exists(filePath)) {
            Console.WriteLine("CSV file not found.");
            return;
        }
        string[] lines = File.ReadAllLines(filePath);
        var sortedRecords = lines
            .Skip(1)
            .Select(line => line.Split(','))
            .OrderByDescending(data => int.Parse(data[3]))
            .Take(5)
            .ToArray();
        Console.WriteLine("Top 5 Highest-Paid Employees:");
        Console.WriteLine("ID\tName\tDepartment\tSalary");
        foreach (var record in sortedRecords) {
            Console.WriteLine(record[0] + "\t" + record[1] + "\t" + record[2] + "\t" + record[3]);
        }
    }
}
