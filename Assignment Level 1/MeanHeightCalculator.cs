using System;
class MeanHeightCalculator
{
    static void Main(string[] args)
    {
        double[] heights = new double[11];
        double sum = 0.0;
        Console.WriteLine("Enter the heights of 11 players:");
        // user input of heights
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write($"Enter height of player {i + 1}: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
            sum += heights[i];
        }
        // Calculate the mean height
        double mean = sum / heights.Length;
        // Print the mean height
        Console.WriteLine($"\nThe mean height of the football team is {mean}");
    }
}
