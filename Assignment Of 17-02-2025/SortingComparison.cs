using System;
class SortingComparison{
    public static void BubbleSort(int[] arr){
        for (int i = 0; i < arr.Length - 1; i++){
            for (int j = 0; j < arr.Length - i - 1; j++){
                if (arr[j] > arr[j + 1]){
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
    public static void MergeSort(int[] arr){
        if (arr.Length <= 1)
            return;
        int mid = arr.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];
        Array.Copy(arr, left, mid);
        Array.Copy(arr, mid, right, 0, arr.Length - mid);
        MergeSort(left);
        MergeSort(right);
        Merge(arr, left, right);
    }
    public static void Merge(int[] arr, int[] left, int[] right){
        int i = 0, j = 0, k = 0;
        while (i < left.Length && j < right.Length){
            if (left[i] <= right[j]){
                arr[k] = left[i];
                i++;
            }else{
                arr[k] = right[j];
                j++;
            }
            k++;
        }
        while (i < left.Length){
            arr[k] = left[i];
            i++;
            k++;
        }
        while (j < right.Length){
            arr[k] = right[j];
            j++;
            k++;
        }
    }
    public static void QuickSort(int[] arr, int low, int high){
        if (low < high){
            int pi = Partition(arr, low, high);
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }
    public static int Partition(int[] arr, int low, int high){
        int pivot = arr[high];
        int i = low - 1;
        for (int j = low; j < high; j++){
            if (arr[j] < pivot){
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;
        return i + 1;
    }
    public static void Main(){
        int[] dataset1k = new int[1000];
        int[] dataset10k = new int[10000];
        int[] dataset1m = new int[1000000];
        for (int i = 0; i < dataset1k.Length; i++)
            dataset1k[i] = dataset10k[i] = dataset1m[i] = i;
        var start = DateTime.Now;
        BubbleSort(dataset1k);
        var bubble1k = DateTime.Now - start;
        start = DateTime.Now;
        MergeSort(dataset1k);
        var merge1k = DateTime.Now - start;
        start = DateTime.Now;
        QuickSort(dataset1k, 0, dataset1k.Length - 1);
        var quick1k = DateTime.Now - start;
        Console.WriteLine("Bubble Sort (1000): " + bubble1k.TotalMilliseconds + " ms");
        Console.WriteLine("Merge Sort (1000): " + merge1k.TotalMilliseconds + " ms");
        Console.WriteLine("Quick Sort (1000): " + quick1k.TotalMilliseconds + " ms");
        start = DateTime.Now;
        BubbleSort(dataset10k);
        var bubble10k = DateTime.Now - start;
        start = DateTime.Now;
        MergeSort(dataset10k);
        var merge10k = DateTime.Now - start;
        start = DateTime.Now;
        QuickSort(dataset10k, 0, dataset10k.Length - 1);
        var quick10k = DateTime.Now - start;
        Console.WriteLine("Bubble Sort (10000): " + bubble10k.TotalMilliseconds + " ms");
        Console.WriteLine("Merge Sort (10000): " + merge10k.TotalMilliseconds + " ms");
        Console.WriteLine("Quick Sort (10000): " + quick10k.TotalMilliseconds + " ms");
        start = DateTime.Now;
        BubbleSort(dataset1m);
        var bubble1m = DateTime.Now - start;
        start = DateTime.Now;
        MergeSort(dataset1m);
        var merge1m = DateTime.Now - start;
        start = DateTime.Now;
        QuickSort(dataset1m, 0, dataset1m.Length - 1);
        var quick1m = DateTime.Now - start;
        Console.WriteLine("Bubble Sort (1000000): " + bubble1m.TotalMilliseconds );
        Console.WriteLine("Merge Sort (1000000): " + merge1m.TotalMilliseconds );
        Console.WriteLine("Quick Sort (1000000): " + quick1m.TotalMilliseconds);
    }
}
