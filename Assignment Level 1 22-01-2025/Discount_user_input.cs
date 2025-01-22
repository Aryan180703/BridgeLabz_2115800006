using System;
class Discount{
	static double discountAmount;
	static double discountFee;
	static void Main(String[] args){
		Console.Write("Enter fee : ");
		double fee = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter Discount Percentage : ");
		double discountPercentage = Convert.ToDouble(Console.ReadLine());
		DiscountFee(fee,discountPercentage);
		Console.WriteLine($"The discount amount is INR {discountAmount} and final discounted fee is INR {discountFee}");
	}
	//this method calculates discount amount and discount fee 
	static void DiscountFee(double fee, double discountPercentage){
		discountAmount = (fee*discountPercentage)/100;
		discountFee = fee - discountAmount;
	}
}