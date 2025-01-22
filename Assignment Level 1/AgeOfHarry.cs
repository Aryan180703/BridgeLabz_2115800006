using System;
class HarryAge{
	static void Main(String[] args){
		HarryAge.AgeOfHarry();
	}
	//This method calculates the age of harry
	public static void AgeOfHarry(){
	int birthYear = 2000;
	int currentYear = 2024;
	int age = currentYear-birthYear; 
	Console.WriteLine("Harry's Age in 2024 is "+age); // Prints Harry's Age
	}
}	