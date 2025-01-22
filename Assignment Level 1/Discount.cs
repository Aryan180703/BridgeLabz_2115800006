using System;
class Discount{
	static double discountAmount;
	static double discountFee;
	static void Main(String[] args){
		double fee = 125000;
		double discountPercentage = 10;
		DiscountFee(fee,discountPercentage);
		Console.WriteLine($"The discount amount is INR {discountAmount} and final discounted fee is INR {discountFee}");
	}
	//this method calculates discount amount and discount fee 
	static void DiscountFee(double fee, double discountPercentage){
		discountAmount = (fee*discountPercentage)/100;
		discountFee = fee - discountAmount;
	}
}