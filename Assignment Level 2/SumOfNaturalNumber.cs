using System;
class SumOfNaturalNumbers{
    static void Main(string[] args){
        Console.WriteLine("Enter the value of n : ");
        int num = Convert.ToInt32(Console.ReadLine());
        //check for natural number
        if(num<=0){
            Environment.Exit(1);
        }
        if(RecursionSum(num)==FormulaSum(num)){
            Console.WriteLine("Both results are equal");
        }
        else{
            Console.WriteLine("Both results are different");
        }
        //print both the result
        Console.WriteLine("sum using recursion : "+RecursionSum(num));
        Console.WriteLine("sum using formula : "+FormulaSum(num));
    }
    //this method will calculate sum using recursion 
    static int RecursionSum(int n ){
        if(n==0){
            return 0;
        }
        return n+RecursionSum(n-1);
    }
    //this method will find sum using formula
    static int FormulaSum(int n){
        return (n*(n+1))/2;
    }
}