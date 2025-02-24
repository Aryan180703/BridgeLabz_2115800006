using System;
using System.Reflection;
class ReflectionPrivateFieldExample 
{
    static void Main() 
    {
        Person person = new Person();
        Type type = typeof(Person);
        FieldInfo ageField = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);
        if (ageField == null) 
        {
            Console.WriteLine("Private field 'age' not found.");
            return;
        }
        ageField.SetValue(person, 25);
        int retrievedAge = (int)ageField.GetValue(person);
        Console.WriteLine("Modified Age : " + retrievedAge);
    }
}

class Person 
{
    private int age;
    public void DisplayAge() 
    {
        Console.WriteLine("Age : " + age);
    }
}
