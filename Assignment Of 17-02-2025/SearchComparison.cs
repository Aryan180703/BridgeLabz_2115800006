using System;
class SearchComparison{
    public static int LinearSearch(int[] arr, int target){
        for (int i = 0; i < arr.Length; i++){
            if (arr[i] == target)
                return i;
        }
        return -1;
    }
    public static int BinarySearch(int[] arr, int target){
        int left = 0, right = arr.Length - 1;
        while (left <= right){
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
                return mid;
            if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }
    public static void Main(){
        int[] dataset = new int[1000000];
        for (int i = 0; i < dataset.Length; i++)
            dataset[i] = i;
        var start = DateTime.Now;
        Console.WriteLine(LinearSearch(dataset, 500000));
        var linearDuration = DateTime.Now - start;
        int[] sortedDataset = new int[1000000];
        Array.Copy(dataset, sortedDataset, dataset.Length);
        for (int i = 0; i < sortedDataset.Length - 1; i++){
            for (int j = i + 1; j < sortedDataset.Length; j++){
                if (sortedDataset[i] > sortedDataset[j]){
                    int temp = sortedDataset[i];
                    sortedDataset[i] = sortedDataset[j];
                    sortedDataset[j] = temp;
                }
            }
        }
        start = DateTime.Now;
        Console.WriteLine(BinarySearch(sortedDataset, 500000));
        var binaryDuration = DateTime.Now - start;
        Console.WriteLine("Linear Search Duration: " + linearDuration.TotalMilliseconds );
        Console.WriteLine("Binary Search Duration: " + binaryDuration.TotalMilliseconds );
    }
}
