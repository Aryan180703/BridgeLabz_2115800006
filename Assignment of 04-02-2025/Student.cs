using System;
class Student {
    public static string UniversityName = "GLA University";
    private static int totalStudents = 0;
    public readonly int RollNumber;
    private string name;
    private string grade;
    public Student(string name, int rollNumber, string grade) {
        this.name = name;
        this.RollNumber = rollNumber;
        this.grade = grade;
        totalStudents++;
    }
    public string GetName() {
        return name;
    }
    public void SetName(string name) {
        this.name = name;
    }
    public string GetGrade() {
        return grade;
    }
    public void SetGrade(string grade) {
        this.grade = grade;
    }
    public static void DisplayTotalStudents() {
        Console.WriteLine("Total Students Enrolled: " + totalStudents);
    }
    public void DisplayDetails() {
        Console.WriteLine("Name: " + name + ", Roll Number: " + RollNumber + ", Grade: " + grade + ", University: " + UniversityName);
    }
    public void UpdateGrade(object obj, string newGrade) {
        if (obj is Student) {
            ((Student)obj).grade = newGrade;
            Console.WriteLine("Grade updated successfully!");
        }
        else {
            Console.WriteLine("Invalid operation: Object is not a Student.");
        }
    }
    static void Main() {
        Student s1 = new Student("Aryan", 07, "A");
        Student s2 = new Student("Dhruv", 18, "B");
        s1.DisplayDetails();
        s2.DisplayDetails();
        Student.DisplayTotalStudents();
        s1.UpdateGrade(s2, "A+");
        s2.DisplayDetails();
    }
}