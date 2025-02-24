using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class TaskInfoAttribute : Attribute 
{
    public int Priority { get; }
    public string AssignedTo { get; }
    public TaskInfoAttribute(int priority, string assignedTo) 
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}
class TaskManager 
{
    [TaskInfo(1, "Aryan Upadhyay")]
    public void CompleteTask() 
    {
        Console.WriteLine("Task completed.");
    }
}

class Program 
{
    static void Main() 
    {
        TaskManager taskManager = new TaskManager();
        taskManager.CompleteTask();
        MethodInfo methodInfo = typeof(TaskManager).GetMethod("CompleteTask");
        var attributes = methodInfo.GetCustomAttributes(typeof(TaskInfoAttribute), false);
        foreach (TaskInfoAttribute attribute in attributes) 
        {
            Console.WriteLine("Priority: " + attribute.Priority);
            Console.WriteLine("Assigned To: " + attribute.AssignedTo);
        }
    }
}
