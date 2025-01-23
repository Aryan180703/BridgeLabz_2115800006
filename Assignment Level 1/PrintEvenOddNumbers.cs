using System;
class PrintEvenOdd{
    static void Main(String[] args){
        //user input 
        Console.WriteLine("Enter a number : ");
        int n = Convert.ToInt32(Console.ReadLine());
        PrintNumbers(n);
    }
    //this method will print numbers along with weather it is even or odd
    static void PrintNumbers(int n){
        for(int i = 1 ; i<=n;i++){
            if(i%2==0){
                Console.WriteLine($"{i} is Even");
            }
            else{
                Console.WriteLine($"{i} is Odd");
            }
        }
    }
}