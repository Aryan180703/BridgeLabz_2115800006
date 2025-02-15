using System;
class FirstLastOccurrence {
    static int FindFirst(int[] arr, int target) {
        int left = 0, right = arr.Length - 1, result = -1;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            
            if (arr[mid] == target) {
                result = mid;
                right = mid - 1;
            } 
            else if (arr[mid] < target) {
                left = mid + 1;
            } 
            else {
                right = mid - 1;
            }
        }
        
        return result;
    }
    static int FindLast(int[] arr, int target) {
        int left = 0, right = arr.Length - 1, result = -1;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            
            if (arr[mid] == target) {
                result = mid;
                left = mid + 1;
            } 
            else if (arr[mid] < target) {
                left = mid + 1;
            } 
            else {
                right = mid - 1;
            }
        }
        return result;
    }
    
    static void Main(string[] args) {
        int[] arr = {1, 2, 2, 2, 3, 4, 5};
        int target = 2;
        int first = FindFirst(arr, target);
        int last = FindLast(arr, target);        
        Console.WriteLine("First Occurrence: " + first);
        Console.WriteLine("Last Occurrence: " + last);
    }
}
