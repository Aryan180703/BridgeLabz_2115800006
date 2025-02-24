using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
[AttributeUsage(AttributeTargets.Constructor)]
public class InjectAttribute : Attribute { }
public interface IMessageService 
{
    void SendMessage(string message);
}
public class EmailService : IMessageService 
{
    public void SendMessage(string message) 
    {
        Console.WriteLine("Email Sent: " + message);
    }
}
public class Notification 
{
    private readonly IMessageService _messageService;
    [Inject]
    public Notification(IMessageService messageService) 
    {
        _messageService = messageService;
    }
    public void Notify(string message) 
    {
        _messageService.SendMessage(message);
    }
}
public class SimpleContainer 
{
    private readonly Dictionary<Type, Type> _registrations = new Dictionary<Type, Type>();
    public void Register<TInterface, TImplementation>() 
    {
        _registrations[typeof(TInterface)] = typeof(TImplementation);
    }
    public object Resolve(Type type) 
    {
        ConstructorInfo[] constructors = type.GetConstructors();
        foreach (ConstructorInfo constructor in constructors) 
        {
            if (constructor.GetCustomAttribute<InjectAttribute>() != null) 
            {
                ParameterInfo[] parameters = constructor.GetParameters();
                object[] dependencies = parameters.Select(p => Resolve(p.ParameterType)).ToArray();
                return Activator.CreateInstance(type, dependencies);
            }
        }
        if (_registrations.ContainsKey(type)) 
        {
            Type implementationType = _registrations[type];
            return Resolve(implementationType);
        }

        return Activator.CreateInstance(type);
    }
    public T Resolve<T>() 
    {
        return (T)Resolve(typeof(T));
    }
}
class Program 
{
    static void Main() 
    {
        SimpleContainer container = new SimpleContainer();
        container.Register<IMessageService, EmailService>();
        Notification notification = container.Resolve<Notification>();
        notification.Notify("Hello, Aryan Upadhyay!");
    }
}
