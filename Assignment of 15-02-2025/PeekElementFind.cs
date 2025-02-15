using System;
class PeakElementFinder {
    static int FindPeakElement(int[] arr, int left, int right) {
        int mid = left + (right - left) / 2;
        if ((mid == 0 || arr[mid] > arr[mid - 1]) && (mid == arr.Length - 1 || arr[mid] > arr[mid + 1])) {
            return mid;
        }
        if (mid > 0 && arr[mid - 1] > arr[mid]) {
            return FindPeakElement(arr, left, mid - 1);
        }
        
        return FindPeakElement(arr, mid + 1, right);
    }    
    static void Main(string[] args) {
        int[] arr = {1, 3, 20, 4, 1, 0};
        int peakIndex = FindPeakElement(arr, 0, arr.Length - 1);
        
        Console.WriteLine("Peak Element: " + arr[peakIndex]);
    }
}
