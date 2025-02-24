using System;
using System.Reflection;

class ReflectionInvokePrivateMethodExample 
{
    static void Main() 
    {
        Calculator calculator = new Calculator();

        Type type = typeof(Calculator);

        MethodInfo multiplyMethod = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

        if (multiplyMethod == null) 
        {
            Console.WriteLine("Private method 'Multiply' not found.");
            return;
        }

        object result = multiplyMethod.Invoke(calculator, new object[] { 5, 7 });

        Console.WriteLine("Result of Multiplication: " + result);
    }
}

class Calculator 
{
    private int Multiply(int a, int b) 
    {
        return a * b;
    }
}
