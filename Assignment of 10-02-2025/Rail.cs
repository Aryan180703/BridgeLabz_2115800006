using System;
using System.Collections.Generic;

abstract class Vehicle {
    private int vehicleId;
    private string driverName;
    private double ratePerKm;

    public int VehicleId {
        get { return vehicleId; }
        private set { vehicleId = value; }
    }

    public string DriverName {
        get { return driverName; }
        private set { driverName = value; }
    }

    public double RatePerKm {
        get { return ratePerKm; }
        private set { ratePerKm = value; }
    }

    protected Vehicle(int vehicleId, string driverName, double ratePerKm) {
        VehicleId = vehicleId;
        DriverName = driverName;
        RatePerKm = ratePerKm;
    }

    public virtual void GetVehicleDetails() {
        Console.WriteLine("Vehicle ID: " + VehicleId);
        Console.WriteLine("Driver Name: " + DriverName);
        Console.WriteLine("Rate Per Km: " + RatePerKm);
        Console.WriteLine();
    }

    public abstract double CalculateFare(double distance);
}

interface IGPS {
    void GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

class Car : Vehicle, IGPS {
    private string currentLocation;

    public Car(int vehicleId, string driverName, double ratePerKm, string initialLocation) 
        : base(vehicleId, driverName, ratePerKm) {
        currentLocation = initialLocation;
    }

    public override double CalculateFare(double distance) {
        return distance * RatePerKm;
    }

    public void GetCurrentLocation() {
        Console.WriteLine("Car Location: " + currentLocation);
        Console.WriteLine();
    }

    public void UpdateLocation(string newLocation) {
        currentLocation = newLocation;
        Console.WriteLine("Car location updated to: " + newLocation);
        Console.WriteLine();
    }
}

class Bike : Vehicle, IGPS {
    private string currentLocation;

    public Bike(int vehicleId, string driverName, double ratePerKm, string initialLocation) 
        : base(vehicleId, driverName, ratePerKm) {
        currentLocation = initialLocation;
    }

    public override double CalculateFare(double distance) {
        return distance * RatePerKm * 0.9; // Discounted rate for bikes
    }

    public void GetCurrentLocation() {
        Console.WriteLine("Bike Location: " + currentLocation);
        Console.WriteLine();
    }

    public void UpdateLocation(string newLocation) {
        currentLocation = newLocation;
        Console.WriteLine("Bike location updated to: " + newLocation);
        Console.WriteLine();
    }
}

class Auto : Vehicle, IGPS {
    private string currentLocation;

    public Auto(int vehicleId, string driverName, double ratePerKm, string initialLocation) 
        : base(vehicleId, driverName, ratePerKm) {
        currentLocation = initialLocation;
    }

    public override double CalculateFare(double distance) {
        return distance * RatePerKm * 1.1; // Slightly higher fare for autos
    }

    public void GetCurrentLocation() {
        Console.WriteLine("Auto Location: " + currentLocation);
        Console.WriteLine();
    }

    public void UpdateLocation(string newLocation) {
        currentLocation = newLocation;
        Console.WriteLine("Auto location updated to: " + newLocation);
        Console.WriteLine();
    }
}

class Program {
    static void Main() {
        List<Vehicle> vehicles = new List<Vehicle>();

        while (true) {
            Console.WriteLine("1. Add Vehicle");
            Console.WriteLine("2. View Vehicle Details");
            Console.WriteLine("3. Calculate Fare");
            Console.WriteLine("4. Get Vehicle Location");
            Console.WriteLine("5. Update Vehicle Location");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice) {
                case 1:
                    Console.WriteLine("1. Car");
                    Console.WriteLine("2. Bike");
                    Console.WriteLine("3. Auto");
                    Console.Write("Enter vehicle type: ");
                    int type = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Vehicle ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Driver Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Rate Per Km: ");
                    double rate = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter Initial Location: ");
                    string location = Console.ReadLine();

                    if (type == 1) {
                        vehicles.Add(new Car(id, name, rate, location));
                    } else if (type == 2) {
                        vehicles.Add(new Bike(id, name, rate, location));
                    } else if (type == 3) {
                        vehicles.Add(new Auto(id, name, rate, location));
                    }

                    Console.WriteLine("Vehicle Added Successfully!");
                    Console.WriteLine();
                    break;

                case 2:
                    foreach (var vehicle in vehicles) {
                        vehicle.GetVehicleDetails();
                    }
                    break;

                case 3:
                    Console.Write("Enter Vehicle ID to calculate fare: ");
                    int fareId = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Distance in Km: ");
                    double distance = Convert.ToDouble(Console.ReadLine());

                    foreach (var vehicle in vehicles) {
                        if (vehicle.VehicleId == fareId) {
                            Console.WriteLine("Total Fare: " + vehicle.CalculateFare(distance));
                            Console.WriteLine();
                            break;
                        }
                    }
                    break;

                case 4:
                    Console.Write("Enter Vehicle ID to get location: ");
                    int locId = Convert.ToInt32(Console.ReadLine());

                    foreach (var vehicle in vehicles) {
                        if (vehicle.VehicleId == locId && vehicle is IGPS) {
                            ((IGPS)vehicle).GetCurrentLocation();
                            break;
                        }
                    }
                    break;

                case 5:
                    Console.Write("Enter Vehicle ID to update location: ");
                    int updateId = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter New Location: ");
                    string newLocation = Console.ReadLine();

                    foreach (var vehicle in vehicles) {
                        if (vehicle.VehicleId == updateId && vehicle is IGPS) {
                            ((IGPS)vehicle).UpdateLocation(newLocation);
                            break;
                        }
                    }
                    break;

                case 6:
                    return;

                default:
                    Console.WriteLine("Invalid Choice");
                    Console.WriteLine();
                    break;
            }
        }
    }
}
