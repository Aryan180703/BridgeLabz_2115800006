using System;
public class CarRental{
    private string customerName;
    private string carModel;
    private int rentalDays;
    private double dailyRate = 2000;  // Fixed daily rental rate
    public CarRental(){
        customerName = "Bugatti";
        carModel = "Chiron";
        rentalDays = 5;
    }
    public CarRental(string name, string model, int days){
        customerName = name;
        carModel = model;
        rentalDays = days;
    }
    public double CalculateTotalCost(){
        return rentalDays * dailyRate;
    }
    public void DisplayRentalDetails(){
        Console.WriteLine("Customer Name : " + customerName);
        Console.WriteLine("Car Model : " + carModel);
        Console.WriteLine("Rental Days : " + rentalDays);
        Console.WriteLine("Total Cost : " + CalculateTotalCost());
    }
}

