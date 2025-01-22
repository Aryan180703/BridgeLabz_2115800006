using System;
class SquareSide{
    static void Main(string[] args){
        Console.Write("Enter the perimeter of the square: ");
        double perimeter = Convert.ToDouble(Console.ReadLine());
        double side = CalculateSideFromPerimeter(perimeter);
		//Print the result
        Console.WriteLine($"The length of the side is {side} whose perimeter is {perimeter}");
    }

    // this Method calculates the side of the square
    static double CalculateSideFromPerimeter(double perimeter)
    {
        return perimeter / 4;
    }
}
