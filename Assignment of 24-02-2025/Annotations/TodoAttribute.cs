using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class TodoAttribute : Attribute 
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM") 
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

class Project 
{
    [Todo("Implement user authentication", "Aryan Upadhyay", "HIGH")]
    [Todo("Optimize database queries" , "Aditi Sharma")]
    public void Feature1() 
    {
        Console.WriteLine("Feature 1 implementation");
    }

    [Todo("Improve UI design", "Rahul Mehta", "LOW")]
    public void Feature2() 
    {
        Console.WriteLine("Feature 2 implementation");
    }

    public void Feature3() 
    {
        Console.WriteLine("Feature 3 implementation");
    }
}

class Program 
{
    static void Main() 
    {
        Project project = new Project();
        project.Feature1();
        project.Feature2();
        project.Feature3();

        MethodInfo[] methods = typeof(Project).GetMethods();
        
        foreach (MethodInfo method in methods) 
        {
            var attributes = method.GetCustomAttributes(typeof(TodoAttribute), false);
            
            foreach (TodoAttribute attribute in attributes) 
            {
                Console.WriteLine("Task : " + attribute.Task);
                Console.WriteLine("Assigned To : " + attribute.AssignedTo);
                Console.WriteLine("Priority : " + attribute.Priority);
            }
        }
    }
}
