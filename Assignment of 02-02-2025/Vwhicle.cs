using System;
public class Vehicle{
    private string ownerName;
    private string vehicleType;
    public static double registrationFee = 100.0;
    public Vehicle(string owner, string type){
        ownerName = owner;
        vehicleType = type;
    }
    public void DisplayVehicleDetails(){
        Console.WriteLine("Owner Name: " + ownerName);
        Console.WriteLine("Vehicle Type: " + vehicleType);
        Console.WriteLine("Registration Fee: " + registrationFee);
    }
    public static void UpdateRegistrationFee(double newFee){
        registrationFee = newFee;
    }
}
