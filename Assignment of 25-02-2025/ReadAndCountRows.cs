using System;
using System.IO;

class Program {
    static void Main() {
        string filePath = "employees.csv";
        if (!File.Exists(filePath)) {
            Console.WriteLine("CSV file not found.");
            return;
        }
        string[] lines = File.ReadAllLines(filePath);
        int recordCount = lines.Length - 1;
        Console.WriteLine("Number of records (excluding header): " + recordCount);
    }
}
