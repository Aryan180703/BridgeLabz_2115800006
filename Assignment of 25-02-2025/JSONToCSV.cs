using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
class Program {
    static void Main(string[] args) {
        string jsonFilePath = "students.json";
        string csvFilePath = "students.csv";
        string outputJsonFilePath = "converted_students.json";
        ConvertJsonToCsv(jsonFilePath, csvFilePath);
        ConvertCsvToJson(csvFilePath, outputJsonFilePath);
    }
    static void ConvertJsonToCsv(string jsonFilePath, string csvFilePath) {
        if (!File.Exists(jsonFilePath)) {
            Console.WriteLine("JSON file not found.");
            return;
        }
        string jsonData = File.ReadAllText(jsonFilePath);
        List<Student> students = JsonConvert.DeserializeObject<List<Student>>(jsonData);
        List<string> lines = new List<string>();
        lines.Add("ID,Name,Age,Marks");

        foreach (var student in students) {
            string line = student.ID + "," + student.Name + "," + student.Age + "," + student.Marks;
            lines.Add(line);
        }
        File.WriteAllLines(csvFilePath, lines);
        Console.WriteLine("JSON converted to CSV: " + csvFilePath);
    }
    static void ConvertCsvToJson(string csvFilePath, string outputJsonFilePath) {
        if (!File.Exists(csvFilePath)) {
            Console.WriteLine("CSV file not found.");
            return;
        }
        string[] lines = File.ReadAllLines(csvFilePath);
        List<Student> students = new List<Student>();
        for (int i = 1; i < lines.Length; i++) {
            string[] data = lines[i].Split(',');
            Student student = new Student {
                ID = data[0],
                Name = data[1],
                Age = Convert.ToInt32(data[2]),
                Marks = Convert.ToInt32(data[3])
            };
            students.Add(student);
        }
        string jsonData = JsonConvert.SerializeObject(students, Formatting.Indented);
        File.WriteAllText(outputJsonFilePath, jsonData);
        Console.WriteLine("CSV converted to JSON: " + outputJsonFilePath);
    }
}
class Student {
    public string ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}
