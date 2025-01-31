using System;
class FibonnaciSequence{
    static void Main(string[] args){
        Console.Write("Enter number of term to print the fabonacci : ");
        int n = Convert.ToInt32(Console.ReadLine());
        fibonacci(n);

    }
    static void fibonacci( int n ){
        int first = 0 ;
        int second = 1 ;
        int next = 0;
        for(int i = 0 ; i <n ; i++){
        Console.Write(first + " ");
        next = first + second;
        first = second;
        second = next;
        }
    }
}