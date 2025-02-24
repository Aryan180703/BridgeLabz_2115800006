using System;
using System.Diagnostics;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTimeAttribute : Attribute 
{
}
class PerformanceTester 
{
    [LogExecutionTime]
    public void FastMethod() 
    {
        int sum = 0;
        for (int i = 0; i < 1000; i++) 
        {
            sum += i;
        }
        Console.WriteLine("FastMethod Result: " + sum);
    }
    [LogExecutionTime]
    public void SlowMethod() 
    {
        int sum = 0;
        for (int i = 0; i < 1000000; i++) 
        {
            sum += i;
        }
        Console.WriteLine("SlowMethod Result: " + sum);
    }
}
class Program 
{
    static void Main() 
    {
        PerformanceTester tester = new PerformanceTester();
        MethodInfo[] methods = typeof(PerformanceTester).GetMethods();
        foreach (MethodInfo method in methods) 
        {
            var attributes = method.GetCustomAttributes(typeof(LogExecutionTimeAttribute), false);
            
            if (attributes.Length > 0) 
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                method.Invoke(tester, null);                
                stopwatch.Stop();
                Console.WriteLine("Execution Time for " + method.Name + " : " + stopwatch.ElapsedMilliseconds);
            }
        }
    }
}
