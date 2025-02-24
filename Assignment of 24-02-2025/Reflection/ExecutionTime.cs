using System;
using System.Diagnostics;
using System.Reflection;
public class SampleClass 
{
    public void FastMethod() 
    {
        int sum = 0;
        for (int i = 0; i < 1000; i++) 
        {
            sum += i;
        }
    }
    public void SlowMethod() 
    {
        int product = 1;
        for (int i = 1; i < 100000; i++) 
        {
            product *= i;
            product %= 100000;
        }
    }
}
public class MethodTimer 
{
    public static void MeasureExecutionTime(object obj) 
    {
        Type type = obj.GetType();
        MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        foreach (MethodInfo method in methods) 
        {
            object[] parameters = new object[0];
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            method.Invoke(obj, parameters);
            stopwatch.Stop();
            Console.WriteLine("Method: " + method.Name + ", Execution Time: " + stopwatch.ElapsedMilliseconds );
        }
    }
}
class Program 
{
    static void Main() 
    {
        SampleClass sample = new SampleClass();
        MethodTimer.MeasureExecutionTime(sample);
    }
}
