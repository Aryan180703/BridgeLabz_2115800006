using System;
using System.Reflection;

class Configuration 
{
    private static string API_KEY = "INITIAL_KEY";

    public static void DisplayApiKey() 
    {
        Console.WriteLine("API_KEY: " + API_KEY);
    }
}

class ReflectionModifyStaticFieldExample 
{
    static void Main() 
    {
        Type type = typeof(Configuration);

        FieldInfo field = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

        if (field != null) 
        {
            Console.WriteLine("Original Value:");
            Configuration.DisplayApiKey();

            field.SetValue(null, "UPDATED_KEY");

            Console.WriteLine("Modified Value:");
            Configuration.DisplayApiKey();
        }
        else 
        {
            Console.WriteLine("Field 'API_KEY' not found.");
        }
    }
}
