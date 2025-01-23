using System;
class FizzBuzz{
    static void Main(string[] args){
        // Taking user input
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());
         // check for positive integer
        if (number <= 0){
            Console.WriteLine("Enter positive integer.");
            return;
        }
        // Loop --0 to the number
        int i = 0;
        while (i <= number){
            // Check for multiple of 3 and 5
            if (i % 3 == 0 && i % 5 == 0){
                Console.WriteLine("FizzBuzz");
            }
            // Check for multiples of 3
            else if (i % 3 == 0){
                Console.WriteLine("Fizz");
            }
            // Check for multiples of 5
            else if (i % 5 == 0){
                Console.WriteLine("Buzz");
            }
            // print number if no conditions met
            else{
                Console.WriteLine(i);
            }
            i++;
        }
    }
}
