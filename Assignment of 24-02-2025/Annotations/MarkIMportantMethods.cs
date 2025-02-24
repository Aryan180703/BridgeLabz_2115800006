using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class ImportantMethodAttribute : Attribute 
{
    public string Level { get; }
    public ImportantMethodAttribute(string level = "HIGH") 
    {
        Level = level;
    }
}

class Operations 
{
    [ImportantMethod]
    public void CriticalOperation() 
    {
        Console.WriteLine("Performing critical operation");
    }

    [ImportantMethod("MEDIUM")]
    public void ModerateOperation() 
    {
        Console.WriteLine("Performing moderate operation");
    }
    public void NormalOperation() 
    {
        Console.WriteLine("Performing normal operation");
    }
}
class Program 
{
    static void Main() 
    {
        Operations ops = new Operations();
        ops.CriticalOperation();
        ops.ModerateOperation();
        ops.NormalOperation();
        MethodInfo[] methods = typeof(Operations).GetMethods();
        foreach (MethodInfo method in methods) 
        {
            var attributes = method.GetCustomAttributes(typeof(ImportantMethodAttribute), false);            
            foreach (ImportantMethodAttribute attribute in attributes) 
            {
                Console.WriteLine("Method: " + method.Name);
                Console.WriteLine("Importance Level: " + attribute.Level);
            }
        }
    }
}
