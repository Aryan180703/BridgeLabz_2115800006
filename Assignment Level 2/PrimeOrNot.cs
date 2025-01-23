using System;
class PrimeOrNot{
    static void Main(String[] args){
    Console.WriteLine("Enter a number to check if prime or not : ");
    int n = Convert.ToInt32(Console.ReadLine());
    // calling method to check for prime
    bool isPrime = CheckPrime(n);
    Console.WriteLine(isPrime);
    }
    //this method checks for prime number and returns true or false
    static bool CheckPrime(int n){
        bool isPrime = true;
        int i =2;
        while(isPrime&&i<n){
            if(n%i == 0){
                isPrime = false;
                break;
            }
            i++;
        }
        return isPrime;
    }

}