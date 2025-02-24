using System;
using System.Reflection;
[AttributeUsage(AttributeTargets.Field)]
class MaxLengthAttribute : Attribute 
{
    public int Value { get; }
    public MaxLengthAttribute(int value) 
    {
        Value = value;
    }
}
class User 
{
    [MaxLength(10)]
    public string Username;
    public User(string username) 
    {
        Username = username;
        ValidateMaxLength();
    }
    private void ValidateMaxLength() 
    {
        FieldInfo[] fields = typeof(User).GetFields(BindingFlags.Public | BindingFlags.Instance);
        foreach (FieldInfo field in fields) 
        {
            var attributes = field.GetCustomAttributes(typeof(MaxLengthAttribute), false);
            foreach (MaxLengthAttribute attribute in attributes) 
            {
                string value = (string)field.GetValue(this);

                if (value.Length > attribute.Value) 
                {
                    throw new ArgumentException("Field " + field.Name + " exceeds max length of " + attribute.Value);
                }
            }
        }
    }
}
class Program 
{
    static void Main() 
    {
        try 
        {
            User user1 = new User("Aryan");
            Console.WriteLine("User 1 Created: " + user1.Username);
            User user2 = new User("AryanUpadhyay");
            Console.WriteLine("User 2 Created: " + user2.Username);
        } 
        catch (ArgumentException ex) 
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
