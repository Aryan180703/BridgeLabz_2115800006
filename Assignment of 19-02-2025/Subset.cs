using System;
using System.Collections.Generic;

class CheckSubset
{
    static bool IsSubset(HashSet<int> subset, HashSet<int> superset){
        return superset.IsSupersetOf(subset);
    }

    static void Main() {
        HashSet<int> subset = new HashSet<int> {2, 3};
        HashSet<int> superset = new HashSet<int> {1, 2, 3, 4};
        Console.WriteLine(IsSubset(subset, superset));
    }
}
