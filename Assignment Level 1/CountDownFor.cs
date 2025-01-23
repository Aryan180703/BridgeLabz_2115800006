using System;
class CountDownFor{
    static void Main(String[] args){
        //taking user input
        Console.Write("Enter a number : ");
        int counter = Convert.ToInt32(Console.ReadLine());
        CountDown(counter);
    }
    //method to print count down using for loop
    static void CountDown(int counter){
        for(;counter>=1;counter--){
            Console.WriteLine(counter);
        }
    }
}