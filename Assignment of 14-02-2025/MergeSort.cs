using System;
class Program{
    public static void MergeSort(double[] prices, int left, int right){
        if (left < right){
            int mid = left + (right - left) / 2;
            MergeSort(prices, left, mid);
            MergeSort(prices, mid + 1, right);
            Merge(prices, left, mid, right);
        }
    }
    public static void Merge(double[] prices, int left, int mid, int right){
        int n1 = mid - left + 1;
        int n2 = right - mid;
        double[] leftArray = new double[n1];
        double[] rightArray = new double[n2];
        for (int i = 0; i < n1; i++)
            leftArray[i] = prices[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = prices[mid + 1 + j];
        int iIndex = 0, jIndex = 0, k = left;
        while (iIndex < n1 && jIndex < n2){
            if (leftArray[iIndex] <= rightArray[jIndex]){
                prices[k] = leftArray[iIndex];
                iIndex++;
            } else {
                prices[k] = rightArray[jIndex];
                jIndex++;
            }
            k++;
        }
        while (iIndex < n1){
            prices[k] = leftArray[iIndex];
            iIndex++;
            k++;
        }
        while (jIndex < n2){
            prices[k] = rightArray[jIndex];
            jIndex++;
            k++;
        }
    }
    public static void Display(double[] prices){
        foreach (var price in prices)
            Console.Write(price + " ");
        Console.WriteLine();
    }
    public static void Main(){
        Console.Write("Enter the number of books: ");
        int n = int.Parse(Console.ReadLine());
        double[] bookPrices = new double[n];
        Console.WriteLine("Enter the book prices:");
        for (int i = 0; i < n; i++)
            bookPrices[i] = double.Parse(Console.ReadLine());

        Console.WriteLine("\nBefore Sorting:");
        Display(bookPrices);
        MergeSort(bookPrices, 0, bookPrices.Length - 1);
        Console.WriteLine("\nAfter Sorting:");
        Display(bookPrices);
    }
}
