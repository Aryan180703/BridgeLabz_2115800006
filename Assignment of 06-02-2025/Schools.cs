using System;
using System.Collections.Generic;
class School {
    public string Name { get; set; }
    private List<Student> students = new List<Student>();
    public School(string name) {
        Name = name;
    }
    public void AddStudent(Student student) {
        students.Add(student);
        Console.WriteLine("Student " + student.Name + " added to " + Name);
    }
}
class Student {
    public string Name { get; }
    private List<Course> courses = new List<Course>();
    public Student(string name) {
        Name = name;
    }
    public void EnrollInCourse(Course course) {
        if (!courses.Contains(course)) {
            courses.Add(course);
            course.AddStudent(this);
            Console.WriteLine("Student " + Name + " enrolled in " + course.Name );
        }
    }
    public void ViewCourses() {
        Console.WriteLine("Courses enrolled by " + Name );
        foreach (var course in courses) {
            Console.WriteLine("  -   " + course.Name);
        }
    }
}
class Course {
    public string Name { get; }
    private List<Student> enrolledStudents = new List<Student>();
    public Course(string name) {
        Name = name;
    }
    public void AddStudent(Student student) {
        if (!enrolledStudents.Contains(student)) {
            enrolledStudents.Add(student);
        }
    }
    public void ViewEnrolledStudents() {
        Console.WriteLine("Students enrolled in " + Name + "  ");
        foreach (var student in enrolledStudents) {
            Console.WriteLine("- " + student.Name);
        }
    }
}
class Program {
    static void Main() {
        School school = new School("BLS International School");
        Student student1 = new Student("Aryan");
        Student student2 = new Student("Dhruv");        
        Course math = new Course("Maths");
        Course science = new Course("Science");
        school.AddStudent(student1);
        school.AddStudent(student2);
        student1.EnrollInCourse(math);
        student1.EnrollInCourse(science);
        student2.EnrollInCourse(math);
        student1.ViewCourses();
        student2.ViewCourses();
        math.ViewEnrolledStudents();
        science.ViewEnrolledStudents();
    }
}
