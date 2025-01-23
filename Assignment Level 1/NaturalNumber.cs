using System;
class NaturalNumber{
    static void Main(string[] args){
        //user input
        Console.Write("Enter a number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        NaturalNum(num);
    }
    //checks if a number is natural or nor
    //if yes, then finds the sum
    //prints the result
    static void NaturalNum(int n){
        if(n>0){
            int sum =  (n*(n+1))/2;
            Console.WriteLine($"The sum of {n} natural numbers is {sum}");
        }
        else{
            Console.WriteLine($"The number {n} is not a natural number");
        }
    }
}