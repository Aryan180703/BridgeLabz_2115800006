using System;
class SumTillNegative{
    static void Main(String[] args){
        double totalSum = 0.0;
        Console.Write("Enter number : ");
        //loop to add numbers untill zero or negative number is entered 
        while(true){
            double num = Convert.ToDouble(Console.ReadLine());
            //checking if number is zero or negative
            if(num<=0){
                break;
            }
            totalSum+=num;
        }
        Console.Write("The total sum : "+totalSum);
    }
    
}