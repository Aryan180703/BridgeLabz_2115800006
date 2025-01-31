using System;
class Factorial{
    static void Main(string[] args){
        Console.WriteLine("Enter a number : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int ans = Fact(n);
        Console.WriteLine(ans);
    }
    static int Fact(int n ){
        if(n == 0 || n == 1){
            return 1;
        }
        return n*Fact(n-1);
    }
}