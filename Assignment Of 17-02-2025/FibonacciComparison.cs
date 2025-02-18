using System;
class FibonacciComparison{
    public static int FibonacciRecursive(int n){
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }
    public static int FibonacciIterative(int n){
        int a = 0, b = 1, sum;
        for (int i = 2; i <= n; i++){
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }
    public static void Main(){
        int[] testCases = {10, 30, 50};

        foreach (int n in testCases){
            var start = DateTime.Now;
            Console.WriteLine("Recursive Fibonacci (" + n + "): " + FibonacciRecursive(n));
            var recursiveDuration = DateTime.Now - start;
            start = DateTime.Now;
            Console.WriteLine("Iterative Fibonacci (" + n + "): " + FibonacciIterative(n));
            var iterativeDuration = DateTime.Now - start;
            Console.WriteLine("Recursive Duration (" + n + "): " + recursiveDuration.TotalMilliseconds );
            Console.WriteLine("Iterative Duration (" + n + "): " + iterativeDuration.TotalMilliseconds );
            Console.WriteLine();
        }
    }
}
