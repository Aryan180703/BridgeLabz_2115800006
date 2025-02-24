using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReportAttribute : Attribute 
{
    public string Description { get; }
    public BugReportAttribute(string description) 
    {
        Description = description;
    }
}
class BugTracker 
{
    [BugReport("Null reference exception in edge case")]
    [BugReport("UI misalignment on smaller screens")]
    public void FixBugs() 
    {
        Console.WriteLine("Fixing reported bugs...");
    }
}
class Program 
{
    static void Main() 
    {
        BugTracker tracker = new BugTracker();
        tracker.FixBugs();
        MethodInfo methodInfo = typeof(BugTracker).GetMethod("FixBugs");
        var attributes = methodInfo.GetCustomAttributes(typeof(BugReportAttribute), false);
        foreach (BugReportAttribute attribute in attributes) 
        {
            Console.WriteLine("Bug Report: " + attribute.Description);
        }
    }
}
