using System;
using System.Collections.Generic;

abstract class Vehicle
{
    private string vehicleNumber, type;
    private double rentalRate;

    public string VehicleNumber 
    { 
        get { return vehicleNumber; } 
        private set { vehicleNumber = value; } 
    }
    public string Type 
    { 
        get { return type; } 
        private set { type = value; } 
    }
    public double RentalRate 
    { 
        get { return rentalRate; } 
        private set { rentalRate = value; } 
    }

    protected Vehicle(string vehicleNumber, string type, double rentalRate)
    {
        VehicleNumber = vehicleNumber;
        Type = type;
        RentalRate = rentalRate;
    }

    public abstract double CalculateRentalCost(int days);

    public virtual void DisplayDetails()
    {
        Console.WriteLine();
        Console.WriteLine("Vehicle Number: " + VehicleNumber);
        Console.WriteLine("Type: " + Type);
        Console.WriteLine("Rental Rate: " + RentalRate + " per day");
        Console.WriteLine();
    }
}

interface IInsurable
{
    double CalculateInsurance();
    void GetInsuranceDetails();
}

class Car : Vehicle, IInsurable
{
    private string insurancePolicyNumber;

    public Car(string vehicleNumber, double rentalRate, string insurancePolicyNumber) 
        : base(vehicleNumber, "Car", rentalRate)
    {
        this.insurancePolicyNumber = insurancePolicyNumber;
    }

    public override double CalculateRentalCost(int days)
    {
        return days * RentalRate;
    }

    public double CalculateInsurance()
    {
        return RentalRate * 5;
    }

    public void GetInsuranceDetails()
    {
        Console.WriteLine("Insurance Policy: " + insurancePolicyNumber);
        Console.WriteLine("Insurance Cost: " + CalculateInsurance());
        Console.WriteLine();
    }
}

class Bike : Vehicle, IInsurable
{
    private string insurancePolicyNumber;

    public Bike(string vehicleNumber, double rentalRate, string insurancePolicyNumber) 
        : base(vehicleNumber, "Bike", rentalRate)
    {
        this.insurancePolicyNumber = insurancePolicyNumber;
    }

    public override double CalculateRentalCost(int days)
    {
        return days * RentalRate * 0.9;
    }

    public double CalculateInsurance()
    {
        return RentalRate * 3;
    }

    public void GetInsuranceDetails()
    {
        Console.WriteLine("Insurance Policy: " + insurancePolicyNumber);
        Console.WriteLine("Insurance Cost: " + CalculateInsurance());
        Console.WriteLine();
    }
}

class Truck : Vehicle, IInsurable
{
    private string insurancePolicyNumber;

    public Truck(string vehicleNumber, double rentalRate, string insurancePolicyNumber) 
        : base(vehicleNumber, "Truck", rentalRate)
    {
        this.insurancePolicyNumber = insurancePolicyNumber;
    }

    public override double CalculateRentalCost(int days)
    {
        return days * RentalRate * 1.2;
    }

    public double CalculateInsurance()
    {
        return RentalRate * 10;
    }

    public void GetInsuranceDetails()
    {
        Console.WriteLine("Insurance Policy: " + insurancePolicyNumber);
        Console.WriteLine("Insurance Cost: " + CalculateInsurance());
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1. Add Vehicle");
            Console.WriteLine("2. Display Vehicles");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Select Vehicle Type:");
                    Console.WriteLine("1. Car");
                    Console.WriteLine("2. Bike");
                    Console.WriteLine("3. Truck");
                    Console.Write("Enter choice: ");
                    int vehicleType = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    Console.Write("Enter Vehicle Number: ");
                    string vehicleNumber = Console.ReadLine();
                    Console.Write("Enter Rental Rate: ");
                    double rentalRate = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Insurance Policy Number: ");
                    string insurancePolicyNumber = Console.ReadLine();
                    Console.WriteLine();

                    switch (vehicleType)
                    {
                        case 1:
                            vehicles.Add(new Car(vehicleNumber, rentalRate, insurancePolicyNumber));
                            break;
                        case 2:
                            vehicles.Add(new Bike(vehicleNumber, rentalRate, insurancePolicyNumber));
                            break;
                        case 3:
                            vehicles.Add(new Truck(vehicleNumber, rentalRate, insurancePolicyNumber));
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            Console.WriteLine();
                            break;
                    }
                    break;

                case 2:
                    Console.Write("Enter number of rental days: ");
                    int days = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    foreach (var vehicle in vehicles)
                    {
                        vehicle.DisplayDetails();
                        Console.WriteLine("Rental Cost for " + days + " days: " + vehicle.CalculateRentalCost(days));
                        Console.WriteLine();

                        if (vehicle is IInsurable insurableVehicle)
                        {
                            insurableVehicle.GetInsuranceDetails();
                        }
                    }
                    break;

                case 3:
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    Console.WriteLine();
                    break;
            }
        }
    }
}
