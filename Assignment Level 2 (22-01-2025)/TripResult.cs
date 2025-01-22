using System;

class TravelComputation {
    public static void Main(string[] args) {
        Console.Write("Enter name : ");
        string name = Console.ReadLine();
		Console.Write("Enter start city: ");
        string fromCity = Console.ReadLine();
        Console.Write("Enter via city: ");
        string viaCity = Console.ReadLine();
        Console.Write("Enter destination city: ");
        string toCity = Console.ReadLine();
        Console.Write("Enter distance betweem starting city and via city : ");
        double distanceFromToVia = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the distance betweem via city and destination city : ");
        double distanceViaToFinalCity = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter time taken from the starting city to via city : ");
        int timeFromToVia = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter time taken from the via city to destination city : ");
        int timeViaToFinalCity = Convert.ToInt32(Console.ReadLine());
        // Calculate the total distance and time
        double totalDistance = distanceFromToVia + distanceViaToFinalCity;
        int totalTime = timeFromToVia + timeViaToFinalCity;
        Console.WriteLine($"The Total Distance travelled by {name} from {fromCity} to {toCity} via {viaCity} is {totalDistance} miles and the Total Time taken is {totalTime} minutes.");
    }
}
