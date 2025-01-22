using System;

class IntOperation{
    static void Main(string[] args){
        Console.Write("Enter value for a: ");
        int a = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter value for b: ");
        int b = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter value for c: ");
        int c = Convert.ToInt32(Console.ReadLine());
		int result1 = a + b * c;
        int result2 = a * b + c;
        int result3 = c + a / b;
		int result4 = a % b + c;
        // Print the results
        Console.WriteLine($"The results of Int Operations are {result1}, {result2}, {result3} and {result4}");
    }
}
