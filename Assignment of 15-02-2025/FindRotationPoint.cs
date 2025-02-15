using System;
class Program {
    static int FindRotationPoint(int[] arr) {
        int left = 0, right = arr.Length - 1;
        if (arr[left] < arr[right]) {
            return 0;
        }
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (mid < right && arr[mid] > arr[mid + 1]) {
                return mid + 1;
            }
            if (mid > left && arr[mid] < arr[mid - 1]) {
                return mid;
            }
            if (arr[mid] > arr[right]) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        return left;
    }

    static void Main() {
        Console.WriteLine("Enter rotated sorted array (space-separated):");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int rotationIndex = FindRotationPoint(arr);
        Console.WriteLine("Rotation Point Index: " + rotationIndex);
        Console.WriteLine("Smallest Element: " + arr[rotationIndex]);
    }
}