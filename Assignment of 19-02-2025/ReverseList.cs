using System;
using System.Collections;
using System.Collections.Generic;
class ReverseList{
    static ArrayList ReverseArrayList(ArrayList list) {
        int left = 0;
        int right = list.Count - 1;
        while (left < right) {
            object temp = list[left];
            list[left] = list[right];
            list[right] = temp;
            left++;
            right--;
        }
        return list;
    }
    static LinkedList<int> ReverseLinkedList(LinkedList<int> list) {
        LinkedList<int> reversedList = new LinkedList<int>();
        foreach (int item in list) {
            reversedList.AddFirst(item);
        }
        return reversedList;
    }
    static void Main() {
        ArrayList arrayList = new ArrayList {1, 2, 3, 4, 5};
        LinkedList<int> linkedList = new LinkedList<int>(new int[] {1, 2, 3, 4, 5});
        arrayList = ReverseArrayList(arrayList);
        linkedList = ReverseLinkedList(linkedList);
        for (int i = 0; i < arrayList.Count; i++) {
            Console.Write(arrayList[i] + " ");
        }
        Console.WriteLine();
        foreach (int item in linkedList) {
            Console.Write(item + " ");
        }
    }
}
