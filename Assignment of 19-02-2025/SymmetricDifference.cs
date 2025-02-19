using System;
using System.Collections.Generic;

class SymmetricDiff{
    static HashSet<int> GetSymmetricDifference(HashSet<int> set1, HashSet<int> set2) {
        HashSet<int> result = new HashSet<int>(set1);
        result.SymmetricExceptWith(set2);
        return result;
    }
    static void PrintSet(HashSet<int> set) {
        foreach (int num in set) {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    static void Main() {
        HashSet<int> set1 = new HashSet<int> {1, 2, 3};
        HashSet<int> set2 = new HashSet<int> {3, 4, 5};
        PrintSet(GetSymmetricDifference(set1, set2));
    }
}
