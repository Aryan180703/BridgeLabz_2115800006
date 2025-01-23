using System;
class SumTillZero{
    static void Main(String[] args){
        double totalSum = 0.0;
        Console.Write("Enter number : ");
        double num = Convert.ToDouble(Console.ReadLine());
        //loop will add numbers until zero is entered by user
        while(num!=0){
            totalSum+=num;
            num = Convert.ToDouble(Console.ReadLine());
        }
        Console.Write("The total sum : "+totalSum);
    }
    
}