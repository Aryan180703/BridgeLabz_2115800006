using System;
using System.Reflection;
using System.Reflection.Emit;

public interface IGreeting 
{
    void SayHello(string name);
}

public class Greeting : IGreeting 
{
    public void SayHello(string name) 
    {
        Console.WriteLine("Hello, " + name + "!");
    }
}

public class LoggingProxy : DispatchProxy 
{
    private object _target;

    public static T Create<T>(T target) where T : class 
    {
        T proxy = Create<T, LoggingProxy>();
        ((LoggingProxy)(object)proxy)._target = target;
        return proxy;
    }

    protected override object Invoke(MethodInfo method, object[] args) 
    {
        Console.WriteLine("Invoking Method: " + method.Name);

        object result = method.Invoke(_target, args);

        Console.WriteLine("Method Execution Completed: " + method.Name);
        return result;
    }
}

class Program 
{
    static void Main() 
    {
        IGreeting greeting = LoggingProxy.Create<IGreeting>(new Greeting());
        greeting.SayHello("Aryan Upadhyay");
    }
}
