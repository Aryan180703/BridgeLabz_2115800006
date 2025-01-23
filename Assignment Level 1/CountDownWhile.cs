using System;
class CountDownWhile{
    static void Main(String[] args){
        //taking user input
        Console.Write("Enter a number : ");
        int counter = Convert.ToInt32(Console.ReadLine());
        CountDown(counter);
    }
    //count down using while loop
    static void CountDown(int counter){
        while(counter>=1){
            //prints the numbers
            Console.WriteLine(counter);
            counter--;
        }
    }
}