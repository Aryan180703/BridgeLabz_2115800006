using System;
class MaximumOfThree{
    static void Main(string[] args){
        int num1 = UserInput("Enter first number: ");
        int num2 = UserInput("Enter second number: ");
        int num3 = UserInput("Enter third number: ");
        MaxOfThree(num1,num2,num3);
    }
    static int UserInput(string str){
        Console.Write(str);
        int n = Convert.ToInt32(Console.ReadLine());
        return n;
    }
    static void MaxOfThree(int a , int b, int c){
        int maxNum = Math.Max(a,Math.Max(b,c));
        Console.WriteLine("Max of three number is : " + maxNum);
    }
}