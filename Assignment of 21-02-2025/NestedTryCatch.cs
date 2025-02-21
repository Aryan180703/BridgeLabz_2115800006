using System;

class NestedTryCatchExample {
    static void Main() {
        try {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < size; i++) {
                Console.Write("Element [" + i + "]: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter the index of the element you want to access : ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the divisor : ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            try {
                int element = numbers[index];

                try {
                    int result = element / divisor;
                    Console.WriteLine("Result of division : " + result);
                } catch (DivideByZeroException) {
                    Console.WriteLine("Cannot divide by zero ");
                }
            } catch (IndexOutOfRangeException) {
                Console.WriteLine("Invalid array index");
            }
        } catch (FormatException) {
            Console.WriteLine("Invalid input! Please enter numeric values only");
        }
    }
}
