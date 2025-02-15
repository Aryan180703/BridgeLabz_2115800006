using System;
class SearchAlgorithms {
    static int FindFirstMissingPositive(int[] arr) {
        int n = arr.Length;
        for (int i = 0; i < n; i++) {
            while (arr[i] > 0 && arr[i] <= n && arr[arr[i] - 1] != arr[i]) {
                int temp = arr[i];
                arr[i] = arr[temp - 1];
                arr[temp - 1] = temp;
            }
        }
        
        for (int i = 0; i < n; i++) {
            if (arr[i] != i + 1) 
            {
                return i + 1;
            }
        }
        
        return n + 1;
    }
    static int BinarySearch(int[] arr, int target) {
        int left = 0, right = arr.Length - 1;
        while (left <= right){
            int mid = left + (right - left) / 2;
            
            if (arr[mid] == target){
                return mid;
            } 
            else if (arr[mid] < target){
                left = mid + 1;
            } 
            else {
                right = mid - 1;
            }
        }
        
        return -1;
    }    
    static void Main(string[] args) {
        int[] arr = {3, 4, -1, 1};
        int missing = FindFirstMissingPositive(arr);
        Console.WriteLine("First Missing Positive: " + missing);
        
        int[] sortedArr = {1, 2, 3, 4, 5, 6, 7};
        int target = 4;
        int index = BinarySearch(sortedArr, target);
        Console.WriteLine("Target Index: " + index);
    }
}
