using System;
class SmallestAndLargestNumber{
    static void Main(string[] args){
        Console.Write("Enter first number : ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number : ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number : ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        int[] ans = FindSmallestAndLargest(num1,num2,num3);
        Console.WriteLine("Smallest Number : "+ ans[0]);
        Console.WriteLine ("Largest Number : "+ ans[1]);
    }
    public static int[] FindSmallestAndLargest(int number1, int number2, int number3){
        int[] result = new int[2];
        int smallestNumber = Math.Min(Math.Min(number1,number2),number3);
        int largestNumber = Math.Max(Math.Max(number1,number2),number3);
        result[0] = smallestNumber;
        result[1] = largestNumber;
        return result;
    }
}