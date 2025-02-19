using System;
using System.Collections.Generic;
class NthElementFromEnd{
    static char FindNthFromEnd(LinkedList<char> list, int n){
        LinkedListNode<char> first = list.First;
        LinkedListNode<char> second = list.First;
        for (int i = 0; i < n; i++) first = first.Next;
        while (first != null){
            first = first.Next;
            second = second.Next;
        }
        return second.Value;
    }

    static void Main(){
        LinkedList<char> list = new LinkedList<char>(new char[] {'A', 'B', 'C', 'D', 'E'});
        int n = 2;
        Console.WriteLine(FindNthFromEnd(list, n));
    }
}
