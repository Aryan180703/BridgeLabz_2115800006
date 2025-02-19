using System;
using System.Collections.Generic;

class UnionIntersection{
    static HashSet<int> GetUnion(HashSet<int> set1, HashSet<int> set2) {
        HashSet<int> result = new HashSet<int>(set1);
        result.UnionWith(set2);
        return result;
    }

    static HashSet<int> GetIntersection(HashSet<int> set1, HashSet<int> set2) {
        HashSet<int> result = new HashSet<int>(set1);
        result.IntersectWith(set2);
        return result;
    }

    static void DisplaySet(HashSet<int> set) {
        foreach (int num in set) {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void Main() {
        HashSet<int> set1 = new HashSet<int> {1, 2, 3};
        HashSet<int> set2 = new HashSet<int> {3, 4, 5};
        DisplaySet(GetUnion(set1, set2));
        DisplaySet(GetIntersection(set1, set2));
    }
}
