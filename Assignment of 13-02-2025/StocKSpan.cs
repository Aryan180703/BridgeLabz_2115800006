using System;
using System.Collections.Generic;

class stack {
    public void span1(int[] arr, int[] span) {
        Stack<int> s1 = new Stack<int>();
        s1.Push(0);
        span[0] = 1;

        for (int i = 1; i < arr.Length; i++) {
            while (s1.Count > 0 && arr[s1.Peek()] <= arr[i]) {
                s1.Pop();
            }
            span[i] = (s1.Count == 0) ? (i + 1) : (i - s1.Peek());
            s1.Push(i);
        }
    }
}

class Mainn {
    static void Main(string[] args) {
        int[] arr = { 100, 80, 60, 70, 60, 75, 85 };
        int[] span = new int[arr.Length];
        stack ss = new stack();
        ss.span1(arr, span);
        foreach (var i in span) {
            Console.Write(i + " ");
        }
    }
}
