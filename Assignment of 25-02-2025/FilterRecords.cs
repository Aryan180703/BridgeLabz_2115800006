using System;
using System.IO;

class Program {
    static void Main(string[] args) {
        string filePath = "students.csv";
        if (!File.Exists(filePath)) {
            Console.WriteLine("CSV file not found.");
            return;
        }
        string[] lines = File.ReadAllLines(filePath);
        Console.WriteLine("Students who scored more than 80 marks:");
        Console.WriteLine("ID\tName\tAge\tMarks");
        Console.WriteLine("----------------------------------");
        for (int i = 1; i < lines.Length; i++) {
            string[] data = lines[i].Split(',');
            string id = data[0];
            string name = data[1];
            string age = data[2];
            int marks = int.Parse(data[3]);
            if (marks > 80) {
                Console.WriteLine(id + "\t" + name + "\t" + age + "\t" + marks);
            }
        }
    }
}
