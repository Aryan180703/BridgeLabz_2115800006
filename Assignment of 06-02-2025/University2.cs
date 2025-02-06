using System;

public class Student{
    public string Name { get; set; }
    public string Email { get; set; }
    public List<Course> Courses { get; set; }

    public Student(string name, string email){
        Name = name;
        Email = email;
        Courses = new List<Course>();
    }

    public void EnrollCourse(Course course)
    {
        Courses.Add(course);
    }
}

public class Professor
{
    public string Name { get; set; }
    public string Department { get; set; }
    public List<Course> CoursesTaught { get; set; }

    public Professor(string name, string department)
    {
        Name = name;
        Department = department;
        CoursesTaught = new List<Course>();
    }

    public void AssignProfessor(Course course){
        course.Professor = this;
        CoursesTaught.Add(course);
    }
}
public class Course{
    public string CourseName { get; set; }
    public int Credits { get; set; }
    public Professor Professor { get; set; }
    public List<Student> Students { get; set; }
    public Course(string courseName, int credits){
        CourseName = courseName;
        Credits = credits;
        Students = new List<Student>();
    }
    public void AddStudent(Student student){
        Students.Add(student);
    }
}
class Program{
    static void Main(string[] args){
        Student student1 = new Student("Aryan Upadhyay", "aryanupadhyay1807@gmail.com");
        Student student2 = new Student("Dhruv", "dhruvsupadhyay1970@gmail.com");
        Professor professor1 = new Professor("Abhishek Sharma", "DSA");
        Professor professor2 = new Professor("Sahil Kumar", "C#");
        Course course1 = new Course("DSA", 3);
        Course course2 = new Course("C#", 4);
        professor1.AssignProfessor(course1);
        professor2.AssignProfessor(course2);
        student1.EnrollCourse(course1);
        student2.EnrollCourse(course1);
        student1.EnrollCourse(course2);
        course1.AddStudent(student1);
        course1.AddStudent(student2);
        course2.AddStudent(student1);
        Console.WriteLine("Courses Enrolled by " + student1.Name + ":");
        foreach (var course in student1.Courses){
            Console.WriteLine(course.CourseName);
        }
        Console.WriteLine("\nCourses Taught by " + professor1.Name + ":");
        foreach (var course in professor1.CoursesTaught){
            Console.WriteLine(course.CourseName);
        }
        Console.WriteLine("\nStudents Enrolled in " + course1.CourseName + ":");
        foreach (var student in course1.Students){
            Console.WriteLine(student.Name);
        }
    }
}
