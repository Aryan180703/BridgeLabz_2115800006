using System;
class TwoDToOneDArray
{
    static void Main(string[] args)
    {
        //user input for row and column
        Console.Write("Enter the number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[rows, columns];
        Console.WriteLine("\nEnter the elements of the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        // Copy elements from 2D to 1D array
        int[] singleArray = new int[rows * columns];
        int index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                singleArray[index] = matrix[i, j];
                index++;
            }
        }
        // print the 2d array
        Console.Writeine("\nThe 2D Array (Matrix) is:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        // print 1d array
        Console.WriteLine("\nThe 1D Array is:");
        foreach (int element in singleArray)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
