using System;
using System.Text;
class Program {
    static string ConcatenateStrings(string[] words) {
        StringBuilder sb = new StringBuilder();
        foreach (string word in words) {
            sb.Append(word);
        }
        return sb.ToString();
    }
    static void Main() {
        Console.WriteLine("Enter strings separated by space:");
        string[] words = Console.ReadLine().Split();
        string result = ConcatenateStrings(words);
        Console.WriteLine("Concatenated String: " + result);
    }
}
