using System;
class Profit{
	static void Main(String[] args){
		double costPrice = Convert.ToDouble(129);
		double sellingPrice = Convert.ToDouble(191);
		ProfitPercentage(costPrice,sellingPrice);
	}
	static void ProfitPercentage(double costPrice , double sellingPrice){
		double profit = sellingPrice-costPrice;
		double profitPercentage =  (profit/costPrice)*100;
		Console.WriteLine($"The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice}\nThe Profit is INR {profit} and the Profit Percentage is {profitPercentage}");

	}
}	