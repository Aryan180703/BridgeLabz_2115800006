using System;
using System.IO;
using System.Collections.Generic;
class Student {
    private string id;
    private string name;
    private int age;
    private int marks;
    private string grade;
    public Student(string id, string name, int age, int marks, string grade) {
        this.id = id;
        this.name = name;
        this.age = age;
        this.marks = marks;
        this.grade = grade;
    }
    public override string ToString() {
        return id + "," + name + "," + age + "," + marks + "," + grade;
    }
}
class Program {
    static void Main(string[] args) {
        string file1 = "students1.csv";
        string file2 = "students2.csv";
        string outputFile = "merged_students.csv";
        if (!File.Exists(file1) || !File.Exists(file2)) {
            Console.WriteLine("One or both CSV files not found.");
            return;
        }
        Dictionary<string, (string Name, int Age)> studentDetails = new Dictionary<string, (string, int)>();
        List<Student> mergedStudents = new List<Student>();
        string[] lines1 = File.ReadAllLines(file1);
        for (int i = 1; i < lines1.Length; i++) {
            string[] data = lines1[i].Split(',');
            string id = data[0];
            string name = data[1];
            int age = int.Parse(data[2]);
            studentDetails[id] = (name, age);
        }
        string[] lines2 = File.ReadAllLines(file2);
        for (int i = 1; i < lines2.Length; i++) {
            string[] data = lines2[i].Split(',');
            string id = data[0];
            int marks = int.Parse(data[1]);
            string grade = data[2];

            if (studentDetails.ContainsKey(id)) {
                var details = studentDetails[id];
                mergedStudents.Add(new Student(id, details.Name, details.Age, marks, grade));
            }
        }
        List<string> outputLines = new List<string>();
        outputLines.Add("ID,Name,Age,Marks,Grade");
        foreach (Student student in mergedStudents) {
            outputLines.Add(student.ToString());
        }
        File.WriteAllLines(outputFile, outputLines);
        Console.WriteLine("Merged CSV file created: " + outputFile);
    }
}
