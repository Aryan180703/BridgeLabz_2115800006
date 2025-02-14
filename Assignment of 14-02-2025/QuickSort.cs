using System;
class Program{
    public static void QuickSort(double[] prices, int low, int high){
        if (low < high){
            int partitionIndex = Partition(prices, low, high);
            QuickSort(prices, low, partitionIndex - 1);
            QuickSort(prices, partitionIndex + 1, high);
        }
    }
    public static int Partition(double[] prices, int low, int high){
        double pivot = prices[high]; 
        int i = low - 1; 
        for (int j = low; j < high; j++){
            if (prices[j] < pivot){ 
                i++;
                Swap(prices, i, j);
            }
        }   
        Swap(prices, i + 1, high);  
        return i + 1; 
    }
    public static void Swap(double[] arr, int a, int b){
        double temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }
    public static void Display(double[] prices){
        foreach (var price in prices)
            Console.Write(price + " ");
        Console.WriteLine();
    }
    public static void Main(){
        Console.Write("Enter the number of products: ");
        int n = int.Parse(Console.ReadLine());
        double[] productPrices = new double[n];
        Console.WriteLine("Enter the product prices:");
        for (int i = 0; i < n; i++)
            productPrices[i] = double.Parse(Console.ReadLine());

        Console.WriteLine("\nBefore Sorting:");
        Display(productPrices);
        QuickSort(productPrices, 0, productPrices.Length - 1);
        Console.WriteLine("\nAfter Sorting:");
        Display(productPrices);
    }
}
