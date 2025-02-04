using System;
public class Vehicle {
    public static decimal RegistrationFee = 5000;
    public readonly string RegistrationNumber;
    private string ownerName;
    private string vehicleType;
    public Vehicle(string ownerName, string vehicleType, string registrationNumber) {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
        this.RegistrationNumber = registrationNumber;
    }
    public string GetOwnerName() {
        return ownerName;
    }
    public void SetOwnerName(string ownerName) {
        this.ownerName = ownerName;
    }
    public string GetVehicleType() {
        return vehicleType;
    }
    public void SetVehicleType(string vehicleType) {
        this.vehicleType = vehicleType;
    }
    public static void UpdateRegistrationFee(decimal newFee) {
        RegistrationFee = newFee;
        Console.WriteLine("Registration Fee has been updated to: " + RegistrationFee);
    }
    public void DisplayRegistrationDetails() {
        Console.WriteLine("Owner Name : " + ownerName);
        Console.WriteLine("Vehicle Type : " + vehicleType);
        Console.WriteLine("Registration Number : " + RegistrationNumber);
        Console.WriteLine("Registration Fee : " + RegistrationFee);
    }
}
class Program {
    static void Main(string[] args) {
        Vehicle vehicle1 = new Vehicle("Aryan Upadhyay", "Bike", "FZX123");

        vehicle1.DisplayRegistrationDetails();

        Vehicle.UpdateRegistrationFee(6000);

        Vehicle vehicle2 = new Vehicle("Tanisha", "Car", "YRZ456");

        if (vehicle2 is Vehicle) {
            vehicle2.DisplayRegistrationDetails();
        }
    }
}