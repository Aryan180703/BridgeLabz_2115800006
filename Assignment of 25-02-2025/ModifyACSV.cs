using System;
using System.IO;
class Program {
    static void Main(string[] args) {
        string inputFilePath = "employees.csv";
        string outputFilePath = "updated_employees.csv";
        if (!File.Exists(inputFilePath)) {
            Console.WriteLine("CSV file not found.");
            return;
        }
        string[] lines = File.ReadAllLines(inputFilePath);
        for (int i = 1; i < lines.Length; i++) {
            string[] data = lines[i].Split(',');

            string department = data[2];
            int salary = int.Parse(data[3]);

            if (department.Equals("IT", StringComparison.OrdinalIgnoreCase)) {
                salary = (int)(salary * 1.10);
                data[3] = salary.ToString();
                lines[i] = string.Join(",", data);
            }
        }
        File.WriteAllLines(outputFilePath, lines);
        Console.WriteLine("Updated records saved to " + outputFilePath);
    }
}
