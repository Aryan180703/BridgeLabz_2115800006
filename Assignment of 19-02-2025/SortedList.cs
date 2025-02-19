using System;
using System.Collections.Generic;
using System.Linq;

class ConvertSortedList{
    static List<int> ConvertToSortedList(HashSet<int> set) {
        List<int> sortedList = set.ToList();
        sortedList.Sort();
        return sortedList;
    }
    static void Display(List<int> list) {
        foreach (int num in list) {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void Main(){
        HashSet<int> setToSort = new HashSet<int> {5, 3, 9, 1};
        Display(ConvertToSortedList(setToSort));
    }
}
