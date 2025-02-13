using System;
class Node {
    public int Key;
    public Node Next;
    public Node(int key) {
        Key = key;
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
    public void Put(int key) {
        int index = GetHash(key);
        Node head = buckets[index];
        while (head != null) {
            if (head.Key == key) {
                return;
            }
            head = head.Next;
        }
        Node newNode = new Node(key);
        newNode.Next = buckets[index];
        buckets[index] = newNode;
    }
    public bool Contains(int key) {
        int index = GetHash(key);
        Node head = buckets[index];
        while (head != null) {
            if (head.Key == key)
                return true;
            head = head.Next;
        }
        return false;
    }
}
class PairSum {
    public static bool HasPairWithSum(int[] arr, int target) {
        CustomHashMap map = new CustomHashMap(arr.Length);
        for (int i = 0; i < arr.Length; i++) {
            int complement = target - arr[i];
            if (map.Contains(complement)) {
                return true;
            }
            map.Put(arr[i]);
        }
        return false;
    }
    static void Main(string[] args) {
        int[] arr = { 3, 5, 9, 2, 8, 10, 11 };
        int target = 17;
        bool result = HasPairWithSum(arr, target);
        Console.WriteLine("Pair with given sum exists: " + result);
    }
}
