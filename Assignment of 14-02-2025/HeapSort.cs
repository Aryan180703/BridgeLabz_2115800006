using System;
class Program{
    public static void HeapSort(int[] salaries){
        int n = salaries.Length;
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(salaries, n, i);
        for (int i = n - 1; i > 0; i--){
            Swap(salaries, 0, i);
            Heapify(salaries, i, 0);
        }
    }
    public static void Heapify(int[] salaries, int n, int root){
        int largest = root;
        int left = 2 * root + 1;
        int right = 2 * root + 2;
        if (left < n && salaries[left] > salaries[largest])
            largest = left;

        if (right < n && salaries[right] > salaries[largest])
            largest = right;

        if (largest != root){
            Swap(salaries, root, largest);
            Heapify(salaries, n, largest);
        }
    }
    public static void Swap(int[] arr, int a, int b){
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }
    public static void Display(int[] salaries){
        foreach (var salary in salaries)
            Console.Write(salary + " ");
        Console.WriteLine();
    }
    public static void Main(){
        Console.Write("Enter the number of applicants: ");
        int n = int.Parse(Console.ReadLine());
        int[] salaryDemands = new int[n];
        Console.WriteLine("Enter the expected salaries:");
        for (int i = 0; i < n; i++)
            salaryDemands[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("\nBefore Sorting:");
        Display(salaryDemands);
        HeapSort(salaryDemands);
        Console.WriteLine("\nAfter Sorting:");
        Display(salaryDemands);
    }
}
