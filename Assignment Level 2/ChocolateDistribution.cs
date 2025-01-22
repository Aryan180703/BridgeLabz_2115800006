using System;

class ChocolateDistribute{
    public static void Main(string[] args) {
        Console.Write("Enter the total number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the total number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;
        // Prints the result
        Console.WriteLine($"The number of chocolates each child gets is {chocolatesPerChild} and the number of remaining chocolates is {remainingChocolates}.");
    }
}
