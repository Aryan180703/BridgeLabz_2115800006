using System;

class LCMAndGCD{
    static void Main(){
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int gcd = GCD(num1, num2);
        int lcm = LCM(num1, num2, gcd);
        Console.WriteLine("GCD of " + num1 + " and " + num2 + " is: " + gcd);
        Console.WriteLine("LCM of " + num1 + " and " + num2 + " is: " + lcm);
    }
    static int GCD(int a, int b){
        while (b != 0){
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    static int LCM(int a, int b, int gcd){
        return (a * b) / gcd;
    }
}
