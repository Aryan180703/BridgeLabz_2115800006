using System;
class LargestNumber{
    static void Main(string[] args){
        Console.Write("Enter first Number : ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second Number : ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third Number : ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        //check for first number to be largest
        bool answer = IfLargestNumber(num1,num2,num3);
        Console.WriteLine($"Is the first number the largest? {answer}");
        answer = IfLargestNumber(num2,num1,num3);
        //check for second number to be largest
        Console.WriteLine($"Is the second number the largest? {answer}");
        answer = IfLargestNumber(num3,num2,num1);
        //check for third number to be largest
        Console.WriteLine($"Is the third number the largest? {answer}");
    }
    //return bool value by checking weather a number is largest or not
    static bool IfLargestNumber(int checkForLargest,int numberA,int numberB){
        return checkForLargest > numberA && checkForLargest > numberB;
    }
}