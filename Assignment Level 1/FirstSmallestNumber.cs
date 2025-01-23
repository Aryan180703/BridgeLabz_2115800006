using System;
class FirstSmallestNumber{
    static bool ans;
    static void Main(string[] args){
        Console.Write("Enter first Number : ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second Number : ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third Number : ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        //giving input to method 
        IfFirstNumSmallest(num1,num2,num3);
        Console.WriteLine($"Is the first number the smallest? {ans}");
    }
    //returns bool value weather first number is smallest or not
    static bool IfFirstNumSmallest(int num1,int num2,int num3){
        if(num1<num2&&num1<num3){
            ans = true;
        }
        else{
            ans = false;
        }
        return ans;
    }
}