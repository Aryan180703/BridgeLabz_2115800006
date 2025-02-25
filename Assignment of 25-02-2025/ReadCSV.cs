using System;
using System.IO;

class Program {
    static void Main() {
        string filePath = "students.csv";
        if (!File.Exists(filePath)) {
            Console.WriteLine("CSV file not found.");
            return;
        }
        string[] lines = File.ReadAllLines(filePath);
        Console.WriteLine("Student Details:");
        Console.WriteLine("ID\tName\tAge\tMarks");
        for (int i = 1; i < lines.Length; i++) {
            string[] data = lines[i].Split(',');
            string id = data[0];
            string name = data[1];
            string age = data[2];
            string marks = data[3];
            Console.WriteLine(id + "\t" + name + "\t" + age + "\t" + marks);
        }
    }
}
