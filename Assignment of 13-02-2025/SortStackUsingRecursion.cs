using System;
using System.Collections.Generic;
class SortStack {
    public static void Sort(Stack<int> stack) {
        if (stack.Count > 0) {
            int top = stack.Pop();
            Sort(stack);
            InsertSorted(stack, top);
        }
    }
    private static void InsertSorted(Stack<int> stack, int element) {
        if (stack.Count == 0 || stack.Peek() <= element) {
            stack.Push(element);
            return;
        }
        int temp = stack.Pop();
        InsertSorted(stack, element);
        stack.Push(temp);
    }
    static void Main(string[] args) {
        Stack<int> stack = new Stack<int>();
        stack.Push(30);
        stack.Push(10);
        stack.Push(50);
        stack.Push(20);
        stack.Push(40);
        Console.WriteLine("Original Stack:");
        PrintStack(stack);
        Sort(stack);
        Console.WriteLine("Sorted Stack:");
        PrintStack(stack);
    }
    private static void PrintStack(Stack<int> stack) {
        foreach (int item in stack) {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}
