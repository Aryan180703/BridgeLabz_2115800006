using System;
using System.Collections;

class Program 
{
    static void Main() 
    {
        #pragma warning disable CS8618
        
        ArrayList list = new ArrayList();
        list.Add(1);
        list.Add("Hello");
        list.Add(3.14);

        foreach (var item in list) 
        {
            Console.WriteLine(item);
        }

        #pragma warning restore CS8618
    }
}
