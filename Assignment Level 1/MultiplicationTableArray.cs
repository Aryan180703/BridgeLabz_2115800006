using System;
class MultiplicationTableUsingArray
{
    static void Main(String[] args)
    {
        //user input to enter a number 
        Console.WriteLine("Enter a number to print multiplication table");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] table = new int[10];
        //this loop will store multiples of entered number
        for(int i = 0; i < table.Length; i++)
        {
            table[i] = (i+1) * number;
        }
        //this loop will print the multipllication table
        for(int i = 0;  i < table.Length; i++)
        {
            Console.WriteLine($"{number} * {i+1} = {table[i]}");
        }
    }

}
