using System;
class PrimeNumberChecker{
    static void Main(string[] args){
        Console.WriteLine("Enter a number : ");
        int n = Convert.ToInt32(Console.ReadLine());
        bool ans = PrimeOrNot(n);
        Console.WriteLine("Is "+n+" prime ? " + ans);
    }
    static bool PrimeOrNot(int n){
        for(int i = 2 ; i<n ; i++){
            if(n%i==0){
                return false;
            }
        }
        return true;
    }
}