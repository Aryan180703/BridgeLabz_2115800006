using System;
using System.Text;
using System.Reflection;

class Person 
{
    public string FirstName = "Aryan";
    public string LastName = "Upadhyay";
    public int Age = 25;
    public bool IsEmployed = true;
}

class JsonConverter 
{
    public static string ToJson(object obj) 
    {
        Type type = obj.GetType();
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

        StringBuilder jsonBuilder = new StringBuilder();
        jsonBuilder.Append("{");

        for (int i = 0; i < fields.Length; i++) 
        {
            FieldInfo field = fields[i];
            string name = field.Name;
            object value = field.GetValue(obj);

            jsonBuilder.Append("\"" + name + "\": ");

            if (value is string) 
            {
                jsonBuilder.Append("\"" + value + "\"");
            } 
            else 
            {
                jsonBuilder.Append(value);
            }

            if (i < fields.Length - 1) 
            {
                jsonBuilder.Append(", ");
            }
        }

        jsonBuilder.Append("}");
        return jsonBuilder.ToString();
    }
}

class JsonRepresentationExample 
{
    static void Main() 
    {
        Person person = new Person();
        string json = JsonConverter.ToJson(person);
        Console.WriteLine("JSON Representation: " + json);
    }
}
