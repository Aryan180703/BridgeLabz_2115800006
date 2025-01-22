using System;
class DistanceConverter{
    static void Main(string[] args){
        Console.Write("Enter the distance in feet: ");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());
        ConvertDistance(distanceInFeet);
    }
    //this method will convert distance to yards and miles
    static void ConvertDistance(double distanceInFeet)
    {
        double distanceInYards = distanceInFeet / 3;
        double distanceInMiles = distanceInYards / 1760; 
        Console.WriteLine($"The distance is {distanceInFeet} feet, which in yards is {distanceInYards} and miles is {distanceInMiles}");
    }
}
