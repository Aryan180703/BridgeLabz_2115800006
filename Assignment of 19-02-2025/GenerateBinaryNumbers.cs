using System;
using System.Collections.Generic;
class BinaryNumbers{
    static List<string> GenerateBinaryNumbers(int n){
        List<string> result = new List<string>();
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("1");
        for (int i = 0; i < n; i++) {
            string current = queue.Dequeue();
            result.Add(current);
            queue.Enqueue(current + "0");
            queue.Enqueue(current + "1");
        }
        return result;
    }

    static void Main(){
        int n = 5;
        List<string> binaryNumbers = GenerateBinaryNumbers(n);
        foreach (string num in binaryNumbers) {
            Console.Write(num + " ");
        }
    }
}
