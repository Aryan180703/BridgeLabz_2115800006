using System;
using System.Reflection;
using System.Collections.Generic;
[AttributeUsage(AttributeTargets.Method)]
class CacheResultAttribute : Attribute {}
class ExpensiveOperations 
{
    private static Dictionary<string, object> cache = new Dictionary<string, object>();
    [CacheResult]
    public int ComputeSquare(int number) 
    {
        string cacheKey = "ComputeSquare_" + number;
        if (cache.ContainsKey(cacheKey)) 
        {
            Console.WriteLine("Returning cached result for: " + number);
            return (int)cache[cacheKey];
        }
        Console.WriteLine("Computing square for: " + number);
        int result = number * number;
        cache[cacheKey] = result;
        return result;
    }
    [CacheResult]
    public int ComputeCube(int number) 
    {
        string cacheKey = "ComputeCube_" + number;
        if (cache.ContainsKey(cacheKey)) 
        {
            Console.WriteLine("Returning cached result for: " + number);
            return (int)cache[cacheKey];
        }
        Console.WriteLine("Computing cube for: " + number);
        int result = number * number * number;
        cache[cacheKey] = result;
        return result;
    }
}
class CachingSystem 
{
    public static object InvokeWithCaching(object obj, string methodName, object[] parameters) 
    {
        MethodInfo method = obj.GetType().GetMethod(methodName);
        var attributes = method.GetCustomAttributes(typeof(CacheResultAttribute), false);
        if (attributes.Length > 0) 
        {
            string cacheKey = methodName;
            foreach (var param in parameters) 
            {
                cacheKey += "_" + param;
            }
            FieldInfo cacheField = obj.GetType().GetField("cache", BindingFlags.NonPublic | BindingFlags.Static);
            var cache = (Dictionary<string, object>)cacheField.GetValue(null);
            if (cache.ContainsKey(cacheKey)) 
            {
                Console.WriteLine("Returning cached result for: " + cacheKey);
                return cache[cacheKey];
            }
            object result = method.Invoke(obj, parameters);
            cache[cacheKey] = result;
            return result;
        } 
        else 
        {
            return method.Invoke(obj, parameters);
        }
    }
}
class Program 
{
    static void Main() 
    {
        ExpensiveOperations operations = new ExpensiveOperations();
        Console.WriteLine("First Call (Square of 4): " + CachingSystem.InvokeWithCaching(operations, "ComputeSquare", new object[] { 4 }));
        Console.WriteLine("Second Call (Square of 4): " + CachingSystem.InvokeWithCaching(operations, "ComputeSquare", new object[] { 4 }));
        Console.WriteLine("First Call (Cube of 3): " + CachingSystem.InvokeWithCaching(operations, "ComputeCube", new object[] { 3 }));
        Console.WriteLine("Second Call (Cube of 3): " + CachingSystem.InvokeWithCaching(operations, "ComputeCube", new object[] { 3 }));
    }
}
