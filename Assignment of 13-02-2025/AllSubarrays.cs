using System;
using System.Collections.Generic;
class SubarrayZeroSum {
    public static void FindZeroSumSubarrays(int[] arr) {
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        int sum = 0;
        Console.WriteLine("Zero Sum Subarrays:");
        for (int i = 0; i < arr.Length; i++) {
            sum += arr[i];
            if (sum == 0) {
                Console.WriteLine("Subarray found from index 0 to " + i);
            }
            if (map.ContainsKey(sum)) {
                foreach (int start in map[sum]) {
                    Console.WriteLine("Subarray found from index " + (start + 1) + " to " + i);
                }
            }
            if (!map.ContainsKey(sum)) {
                map[sum] = new List<int>();
            }
            map[sum].Add(i);
        }
    }
    static void Main(string[] args) {
        int[] arr = { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 };
        FindZeroSumSubarrays(arr);
    }
}
