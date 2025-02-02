using System;
public class Student{
    public int rollNumber;
    protected string name;
    private double CGPA;
    public void SetCGPA(double cgpa){
        CGPA = cgpa;
    }
    public double GetCGPA(){
        return CGPA;
    }
}
public class PostgraduateStudent : Student{
    public void DisplayInfo(){
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Name: " + name);
    }
}
