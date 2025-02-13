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
}
class TwoSumSolution {
    public static int[] TwoSum(int[] nums, int target) {
        CustomHashMap map = new CustomHashMap(nums.Length);
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            int complementIndex = map.Get(complement);
            if (complementIndex != -1) {
                return new int[] { complementIndex, i };
            }
            map.Put(nums[i], i);
        }
        return new int[] { -1, -1 };
    }
    static void Main(string[] args) {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = TwoSum(nums, target);
        Console.WriteLine("Index: " + result[0] + ", " + result[1]);
    }
}
