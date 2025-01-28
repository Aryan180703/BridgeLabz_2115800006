using System;
class Factors{
    static void Main(string[] args){
        Console.WriteLine("Enter a Number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        int[] result = FactorsOfNumber(num);
        Console.Write($"Factors of {num} : ");
        //print the factors 
        foreach(int i in result){
            Console.Write(i + " ");
        }
        Console.WriteLine();
        int sumOfFactors = SumOfFactors(result);
        //print the sum of factors
        Console.WriteLine("The sum of Factors is " + sumOfFactors);
        //print the sum of square of factors
        int sumOfSquareOfFactors = SumOfSquareOfFactors(result);
        Console.Write("The sum of square of Factors is " + sumOfSquareOfFactors);
    }
    //this method will retuen the array of factors of a number
    static int[] FactorsOfNumber(int num){
        int factorCount = 0;
        int index = 0;
        // loop to count the number of factors
        for(int i = 2 ; i<num ; i++){
            if(num%i == 0){
              factorCount++; 
            }
        }
        //initialize array of size of count of factors
        int[] factor = new int[factorCount]; 
        //this loop will enter factors in the array of factors
        for(int i = 2; i < num ; i++){
            if(num%i == 0){
              factor[index] = i;
              index++;
            }
        }
        return factor;
    }
    // this method will return the sum of factors
    static int SumOfFactors(int[] factors){
        int sum = 0;
        for(int i = 0 ; i < factors.Length ; i ++){
            sum += factors[i];
        }
        return sum;
    }
    //method will return the sum of square of factors.
    static int SumOfSquareOfFactors(int[] factors){
        int sumOfSquare = 0;
        for(int i = 0 ; i<factors.Length;i++){
            sumOfSquare += (int)Math.Pow(factors[i], 2);
        }
        return sumOfSquare;
    }
}