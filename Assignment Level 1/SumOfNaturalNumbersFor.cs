using System;
class SumOfNaturalNumbersFor{
    static void Main(String[] args){
        Console.WriteLine("Enter a number : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sumUsingLoop = UsingLoop(n);
        int sumUsingFormula = UsingFormula(n);\
        //comparison of the results
        if(sumUsingLoop == sumUsingFormula){
            Console.WriteLine("Both results match : "+sumUsingLoop);
        }
        else{
            Console.WriteLine($"Both results do not match, sum using looop is {sumUsingLoop} and sumUsingFormula is {sumUsingFormula}");
        }
    }
    //method to calculate sum using loop
    static int UsingLoop(int num){
        int sum = 0;
        for(;num>0;num--){
            sum+=num;
        }
        return sum;
    }
    //method to calculate sum using formula
    static int UsingFormula(int n){
        return (n*(n+1))/2;
    }
    
}