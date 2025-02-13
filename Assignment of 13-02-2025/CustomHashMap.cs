using System;
class Node {
    public int Key;
    public int Value;
    public Node Next;
    
    public Node(int key, int value) {
        Key = key;
        Value = value;
        Next = null;
    }
}
class CustomHashMap {
    private int size;
    private Node[] buckets;
    public CustomHashMap(int capacity) {
        size = capacity;
        buckets = new Node[size];
    }
    private int GetHash(int key) {
        return Math.Abs(key) % size;
    }
    public void Put(int key, int value) {
        int index = GetHash(key);
        Node head = buckets[index];
        while (head != null) {
            if (head.Key == key) {
                head.Value = value;
                return;
            }
            head = head.Next;
        }
        Node newNode = new Node(key, value);
        newNode.Next = buckets[index];
        buckets[index] = newNode;
    }
    public int Get(int key) {
        int index = GetHash(key);
        Node head = buckets[index];
        while (head != null) {
            if (head.Key == key)
                return head.Value;
            head = head.Next;
        }
        return -1;
    }
    public void Remove(int key) {
        int index = GetHash(key);
        Node head = buckets[index];
        Node prev = null;
        while (head != null) {
            if (head.Key == key) {
                if (prev == null) {
                    buckets[index] = head.Next;
                } else {
                    prev.Next = head.Next;
                }
                return;
            }
            prev = head;
            head = head.Next;
        }
    }   
    public void Display() {
        for (int i = 0; i < size; i++) {
            Console.Write($"Bucket {i}: ");
            Node head = buckets[i];
            while (head != null) {
                Console.Write($"[{head.Key} -> {head.Value}] -> ");
                head = head.Next;
            }
            Console.WriteLine("NULL");
        }
    }
}
class Program {
    static void Main(string[] args) {
        CustomHashMap map = new CustomHashMap(10);
        map.Put(1, 100);
        map.Put(2, 200);
        map.Put(11, 300);
        Console.WriteLine("Value for key 1: " + map.Get(1));
        Console.WriteLine("Value for key 2: " + map.Get(2));
        Console.WriteLine("Value for key 11: " + map.Get(11));
        map.Remove(1);
        Console.WriteLine("After removing key 1, value: " + map.Get(1));
        map.Display();
    }
}
