using System;
class TriangularParkRun {
    public static void Main(string[] args) {
        Console.WriteLine("Enter sides of triangular park in meters : ")
        Console.Write("First side  : ");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Second side : ");
        double side2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Third side : ");
        double side3 = Convert.ToDouble(Console.ReadLine());
        double rounds = NumberOfRounds(side1 , side2 , side3);
        Console.WriteLine($"The total number of rounds the athlete will run is {Math.Ceiling(rounds)} to complete 5 km.");
    }
    static double NumberOfRounds(double side1 , double side2 , double side3){
        double perimeter = side1 + side2 + side3;
        double totalDistance = 5000;
        return totalDistance / perimeter;
    }
}
