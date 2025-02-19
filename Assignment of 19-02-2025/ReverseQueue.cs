using System;
using System.Collections.Generic;
class ReverseQueue
{
    static Queue<int> Reverse(Queue<int> queue){
        Stack<int> stack = new Stack<int>();
        while (queue.Count > 0) {
            stack.Push(queue.Dequeue());
        }
        while (stack.Count > 0) {
            queue.Enqueue(stack.Pop());
        }
        return queue;
    }
    static void Main(){
        Queue<int> queue = new Queue<int>(new int[] {10, 20, 30});
        Queue<int> reversedQueue = Reverse(queue);
        foreach (int num in reversedQueue) {
            Console.Write(num + " ");
        }
    }
}
