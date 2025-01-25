using System;
class FriendsComparison
{
    static void Main(string[] args)
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"Enter details for {names[i]}:");
            while (true)
            {
                Console.Write("Enter age: ");
                if (int.TryParse(Console.ReadLine(), out int age) && age > 0)
                {
                    ages[i] = age;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid age");
                }
            }
            while (true)
            {
                Console.Write("Enter height : ");
                if (double.TryParse(Console.ReadLine(), out double height) && height > 0)
                {
                    heights[i] = height;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid height. Please enter a positive number.");
                }
            }
        }
        int youngestIndex = 0;
        int tallestIndex = 0;

        for (int i = 1; i < names.Length; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }

            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }
        //print results
        Console.WriteLine("\nResults:");
        Console.WriteLine($"The youngest friend is {names[youngestIndex]} with an age of {ages[youngestIndex]} years.");
        Console.WriteLine($"The tallest friend is {names[tallestIndex]} with a height of {heights[tallestIndex]} cm.");
    }
}
