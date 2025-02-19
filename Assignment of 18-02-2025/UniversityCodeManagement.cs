using System;
using System.Collections.Generic;

public abstract class CourseType {
    public string EvaluationType { get; set; } 
    public CourseType(string evaluationType) { 
        EvaluationType = evaluationType; 
    }
    public abstract void Evaluate(); 
}

public class ExamCourse : CourseType {
    public string ExamDate { get; set; } 
    public ExamCourse(string examDate) : base("Exam") { 
        ExamDate = examDate; 
    }
    public override void Evaluate() { 
        Console.WriteLine("Evaluating the course with an exam on " + ExamDate + "."); 
    }
}

public class AssignmentCourse : CourseType {
    public int NumberOfAssignments { get; set; } 
    public AssignmentCourse(int numberOfAssignments) : base("Assignment") { 
        NumberOfAssignments = numberOfAssignments; 
    }
    public override void Evaluate() { 
        Console.WriteLine("Evaluating the course with " + NumberOfAssignments + " assignments."); 
    }
}

public class Course<T> where T : CourseType {
    public string CourseName { get; set; } 
    public T Evaluation { get; set; } 
    public Course(string courseName, T evaluation) { 
        CourseName = courseName; 
        Evaluation = evaluation; 
    }
    public void DisplayCourseDetails() { 
        Console.WriteLine("Course Name: " + CourseName); 
        Console.WriteLine("Evaluation Type: " + Evaluation.EvaluationType); 
        Evaluation.Evaluate(); 
    }
}

public class UniversityCourseManagement {
    public List<Course<CourseType>> Courses { get; set; } 
    public UniversityCourseManagement() { 
        Courses = new List<Course<CourseType>>(); 
    }
    public void AddCourse(Course<CourseType> course) { 
        Courses.Add(course); 
    }
    public void DisplayAllCourses() { 
        foreach (var course in Courses) { 
            course.DisplayCourseDetails(); 
            Console.WriteLine(); 
        } 
    }
}

public class Program {
    public static void Main(string[] args) { 
        var examCourse = new Course<ExamCourse>("Mathematics 101", new ExamCourse("2025-05-30")); 
        var assignmentCourse = new Course<AssignmentCourse>("Computer Science 101", new AssignmentCourse(5)); 
        var managementSystem = new UniversityCourseManagement(); 
        managementSystem.AddCourse(examCourse); 
        managementSystem.AddCourse(assignmentCourse); 
        managementSystem.DisplayAllCourses(); 
    }
}
