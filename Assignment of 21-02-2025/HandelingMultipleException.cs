using System;

class ArrayOperations {
    static void Main() {
        int[] num = null;

        try {
            Console.Write("Enter the number of elements in the array: ");
            int s = Convert.ToInt32(Console.ReadLine());

            if (s > 0) {
                num = new int[s];
                Console.WriteLine("Enter the elements of the array:");
                for (int i = 0; i < s; i++) {
                    Console.Write("Element [" + i + "]: ");
                    num[i] = Convert.ToInt32(Console.ReadLine());
                }
            } else {
                Console.WriteLine("Array size must be greater than zero");
                return;
            }
            Console.Write("Enter the index to retrieve the value: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value at index " + index + ": " + num[index]);
        } catch (IndexOutOfRangeException) {
            Console.WriteLine("Invalid index!");
        } catch (NullReferenceException) {
            Console.WriteLine("Array is not initialized");
        } catch (FormatException) {
            Console.WriteLine("Error : Please enter a valid int value");
        }
    }
}
