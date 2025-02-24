using System;
using System.Collections.Generic;
using System.Reflection;
class User 
{
    public string Name;
    public int Age;
    public string Email;
   public void Display() 
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Email: " + Email);
    }
}
class ObjectMapper 
{
    public static T ToObject<T>(Type clazz, Dictionary<string, object> properties) where T : new() 
    {
        T obj = new T();
        FieldInfo[] fields = clazz.GetFields(BindingFlags.Public | BindingFlags.Instance);
        foreach (FieldInfo field in fields) 
        {
            if (properties.ContainsKey(field.Name)) 
            {
                field.SetValue(obj, properties[field.Name]);
            }
        }

        return obj;
    }
}
class CustomObjectMapperExample 
{
    static void Main() 
    {
        Dictionary<string, object> properties = new Dictionary<string, object>();
        properties.Add("Name", "Aryan Upadhyay");
        properties.Add("Age", 25);
        properties.Add("Email", "aryan@example.com");
        User user = ObjectMapper.ToObject<User>(typeof(User), properties);
        user.Display();
    }
}
