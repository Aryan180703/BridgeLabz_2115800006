using System;
class DistributeChocolate
{
    static void Main()
    {
        Console.Write("Enter the numberOfChocolates of chocolates: ");
        int numberOfChocolates = int.Parse(Console.ReadLine());        
        Console.Write("Enter the numberOfChocolates of children: ");
        int numberOfChildren = int.Parse(Console.ReadLine());
        if (numberOfChildren <= 0)
        {
            Console.WriteLine("The numberOfChocolates of children must be greater than zero.");
            return;
        }
        int[] result = NumberOfChocolatesAndRemaining(numberOfChocolates, numberOfChildren);
        // print the results
        Console.WriteLine($"Each child gets: {result[0]} chocolates");
        Console.WriteLine($"Remaining chocolates: {result[1]}");
    }

    public static int[] NumberOfChocolatesAndRemaining(int numberOfChocolates, int numberOfChildren)
    {
        //array to store quotient and remainder
        int[] result = new int[2];
        // Calculating chocolates per child and remaining chocolate
        result[0] = numberOfChocolates / numberOfChildren; // Chocolates per child
        result[1] = numberOfChocolates % numberOfChildren; // Remaining chocolates

        return result; // Returning the array
    }
}
