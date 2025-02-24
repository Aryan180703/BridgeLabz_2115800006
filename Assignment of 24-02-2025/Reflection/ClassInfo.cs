using System;
using System.Reflection;
class ReflectionExample 
{
    static void Main() 
    {
        Console.WriteLine("Enter the full class name :");
        string className = Console.ReadLine();
        Type type = Type.GetType(className);
        if (type == null) 
        {
            Console.WriteLine("Class not found. Please make sure the class name and namespace are correct");
            return;
        }
        Console.WriteLine("Class Name: " + type.Name);
        Console.WriteLine("\nMethods:");
        MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
        foreach (MethodInfo method in methods) 
        {
            Console.WriteLine(method.Name);
        }
        Console.WriteLine("\nFields:");
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
        foreach (FieldInfo field in fields) 
        {
            Console.WriteLine(field.Name);
        }
        Console.WriteLine("\nConstructors:");
        ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
        foreach (ConstructorInfo constructor in constructors) 
        {
            Console.WriteLine(constructor.ToString());
        }
    }
}
class SampleClass 
{
    private int privateField;
    public string publicField;
    public SampleClass() 
    {
        Console.WriteLine("Default Constructor");
    }
    public SampleClass(int number) 
    {
        privateField = number;
    }
    private void PrivateMethod() 
    {
        Console.WriteLine("Private Method");
    }
    public void PublicMethod() 
    {
        Console.WriteLine("Public Method");
    }
}
