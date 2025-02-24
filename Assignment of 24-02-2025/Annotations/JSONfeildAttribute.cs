using System;
using System.Reflection;
using System.Text;
using System.Collections.Generic;
[AttributeUsage(AttributeTargets.Field)]
class JsonFieldAttribute : Attribute 
{
    public string Name { get; }
    public JsonFieldAttribute(string name) 
    {
        Name = name;
    }
}
class User 
{
    [JsonField("user_name")]
    public string Username;
    [JsonField("email_id")]
    public string Email;
    public int Age;
    public User(string username, string email, int age) 
    {
        Username = username;
        Email = email;
        Age = age;
    }
}
class JsonSerializer 
{
    public static string SerializeToJson(object obj) 
    {
        Type type = obj.GetType();
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);
        StringBuilder jsonBuilder = new StringBuilder();
        jsonBuilder.Append("{");
        List<string> jsonFields = new List<string>();
        foreach (FieldInfo field in fields) 
        {
            var attributes = field.GetCustomAttributes(typeof(JsonFieldAttribute), false);
            string jsonKey;
            if (attributes.Length > 0) 
            {
                JsonFieldAttribute attribute = (JsonFieldAttribute)attributes[0];
                jsonKey = attribute.Name;
            } 
            else 
            {
                jsonKey = field.Name;
            }
            object value = field.GetValue(obj);
            string jsonValue = value is string ? "\"" + value + "\"" : value.ToString();
            jsonFields.Add("\"" + jsonKey + "\": " + jsonValue);
        }
        jsonBuilder.Append(string.Join(", ", jsonFields));
        jsonBuilder.Append("}");
        return jsonBuilder.ToString();
    }
}
class Program 
{
    static void Main() 
    {
        User user = new User("AryanUpadhyay", "aryan@example.com", 25);
        string json = JsonSerializer.SerializeToJson(user);
        Console.WriteLine(json);
    }
}
