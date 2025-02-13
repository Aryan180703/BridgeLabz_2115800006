using System;
class Node {
    public int Key;
    public bool Exists;
    public Node Next;   
    public Node(int key) {
        Key = key;
        Exists = true;
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
class LongestConsecutiveSequence {
    public static int FindLongestConsecutiveSequence(int[] nums) {
        if (nums.Length == 0) {
            return 0;
        }
        CustomHashMap map = new CustomHashMap(nums.Length);
        for (int i = 0; i < nums.Length; i++) {
            map.Put(nums[i]);
        }
        int longest = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (!map.Contains(nums[i] - 1)) {
                int currentNum = nums[i];
                int currentStreak = 1;
                while (map.Contains(currentNum + 1)) {
                    currentNum += 1;
                    currentStreak += 1;
                }
                if (currentStreak > longest) {
                    longest = currentStreak;
                }
            }
        }
        return longest;
    }
    static void Main(string[] args) {
        int[] nums = { 100, 4, 200, 1, 3, 2 };
        int result = FindLongestConsecutiveSequence(nums);
        Console.WriteLine("Longest Consecutive Sequence Length: " + result);
    }
}
