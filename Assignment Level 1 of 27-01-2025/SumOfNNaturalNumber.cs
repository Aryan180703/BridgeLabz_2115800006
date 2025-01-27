using System;
class SumOfNaturalNumber{
    static void Main(string[] args){
        Console.Write("Enter the value of n to find sum of natural number : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = SumOfNumbers(n);
        Console.Write("Sum of N natural numbers is : "+sum);
    }
    static int SumOfNumbers(int n){
        return (n*(n+1))/2;
    }
}