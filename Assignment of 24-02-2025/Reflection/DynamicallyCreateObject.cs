using System;
using System.Reflection;
class ReflectionCreateObjectExample 
{
    static void Main() 
    {
        Type type = typeof(Student);

        object studentInstance = Activator.CreateInstance(type);

        MethodInfo displayMethod = type.GetMethod("DisplayDetails");

        if (displayMethod != null) 
        {
            displayMethod.Invoke(studentInstance, null);
        }
        else 
        {
            Console.WriteLine("Method 'DisplayDetails' not found.");
        }
    }
}
class Student 
{
    private string name = "Aryan Upadhyay";
    private int age = 20;
    public void DisplayDetails() 
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}
