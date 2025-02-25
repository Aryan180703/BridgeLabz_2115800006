using System;
using System.IO;
using System.Collections.Generic;
class Student {
    private string id;
    private string name;
    private int age;
    private int marks;
    public Student(string id, string name, int age, int marks) {
        this.id = id;
        this.name = name;
        this.age = age;
        this.marks = marks;
    }
    public override string ToString() {
        return "ID: " + id + ", Name: " + name + ", Age: " + age + ", Marks: " + marks;
    }
}
class Program {
    static void Main(string[] args) {
        string filePath = "students.csv";
        List<Student> students = new List<Student>();
        if (!File.Exists(filePath)) {
            Console.WriteLine("CSV file not found.");
            return;
        }
        string[] lines = File.ReadAllLines(filePath);
        for (int i = 1; i < lines.Length; i++) {
            string[] data = lines[i].Split(',');
            string id = data[0];
            string name = data[1];
            int age = int.Parse(data[2]);
            int marks = int.Parse(data[3]);
            students.Add(new Student(id, name, age, marks));
        }
        foreach (Student student in students) {
            Console.WriteLine(student);
        }
    }
}
