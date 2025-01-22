using System;
class TotalPriceCalculator{
    static void Main(string[] args){
        Console.Write("Enter the unit price of the item (INR): ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the quantity to be bought: ");
        int quantity = Convert.ToInt32(Console.ReadLine());
        double totalPrice = CalculateTotalPrice(unitPrice, quantity);
		//Print the result
        Console.WriteLine($"The total purchase price is INR {totalPrice} if the quantity is {quantity} and the unit price is INR {unitPrice}");
    }
    // this method will calculate the total price
    static double CalculateTotalPrice(double unitPrice, int quantity){
        return unitPrice * quantity;
    }
}
