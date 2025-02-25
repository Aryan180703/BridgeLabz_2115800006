using System;
using System.IO;
class Program {
    static void Main(string[] args) {
        string filePath = "employees.csv";
        if (!File.Exists(filePath)) {
            Console.WriteLine("CSV file not found.");
            return;
        }
        Console.Write("Enter employee name to search: ");
        string searchName = Console.ReadLine();
        string[] lines = File.ReadAllLines(filePath);
        bool found = false;
        for (int i = 1; i < lines.Length; i++) {
            string[] data = lines[i].Split(',');
            string name = data[1];
            string department = data[2];
            string salary = data[3];
            if (name.Equals(searchName, StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("Department: " + department);
                Console.WriteLine("Salary: " + salary);
                found = true;
                break;
            }
        }
        if (!found) {
            Console.WriteLine("Employee not found.");
        }
    }
}
