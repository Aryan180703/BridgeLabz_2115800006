using System;
interface Refuelable {
    void Refuel();
}
class Vehicle {
    public string Model { get; set; }
    public int MaxSpeed { get; set; }
    public Vehicle(string model, int maxSpeed) {
        Model = model;
        MaxSpeed = maxSpeed;
    }
    public void DisplayInfo() {
        Console.WriteLine("Model : " + Model);
        Console.WriteLine("Max Speed : " + MaxSpeed );
    }
}
class ElectricVehicle : Vehicle {
    public int BatteryCapacity { get; set; }
    public ElectricVehicle(string model, int maxSpeed, int batteryCapacity) : base(model, maxSpeed) {
        BatteryCapacity = batteryCapacity;
    }
    public void Charge() {
        Console.WriteLine("Charging electric vehicle");
    }
}

class PetrolVehicle : Vehicle, Refuelable {
    public int FuelCapacity { get; set; }
    public PetrolVehicle(string model, int maxSpeed, int fuelCapacity) : base(model, maxSpeed) {
        FuelCapacity = fuelCapacity;
    }
    public void Refuel() {
        Console.WriteLine("Refueling petrol vehicle");
    }
}
