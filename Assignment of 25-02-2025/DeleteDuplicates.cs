using System;
using System.IO;
using System.Collections.Generic;
class Program {
    static void Main(string[] args) {
        string filePath = "students.csv";
        Dictionary<string, List<string>> records = new Dictionary<string, List<string>>();
        List<string> duplicates = new List<string>();
        if (!File.Exists(filePath)) {
            Console.WriteLine("CSV file not found.");
            return;
        }
        string[] lines = File.ReadAllLines(filePath);
        for (int i = 1; i < lines.Length; i++) {
            string[] data = lines[i].Split(',');
            string id = data[0];

            if (records.ContainsKey(id)) {
                duplicates.Add(lines[i]);
            } else {
                records[id] = new List<string>(data);
            }
        }
        if (duplicates.Count > 0) {
            Console.WriteLine("Duplicate Records Found:");
            foreach (string record in duplicates) {
                Console.WriteLine(record);
            }
        } else {
            Console.WriteLine("No duplicate records found.");
        }
    }
}
