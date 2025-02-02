using System;
public class Course{
    private string courseName;
    private int duration;
    private double fee;
    public static string instituteName = "Default Institute";
    public Course(string name, int dur, double f){
        courseName = name;
        duration = dur;
        fee = f;
    }
    public void DisplayCourseDetails(){
        Console.WriteLine("Course Name: " + courseName);
        Console.WriteLine("Duration (in weeks): " + duration);
        Console.WriteLine("Fee: " + fee);
        Console.WriteLine("Institute Name: " + instituteName);
    }
    public static void UpdateInstituteName(string newInstituteName){
        instituteName = newInstituteName;
    }
}
