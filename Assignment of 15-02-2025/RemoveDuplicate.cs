using System;
using System.Text;
class Program {
    static string RemoveDuplicates(string input) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < input.Length; i++) {
            bool isDuplicate = false;
            for (int j = 0; j < sb.Length; j++) {
                if (input[i] == sb[j]) {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate) {
                sb.Append(input[i]);
            }
        }
        return sb.ToString();
    }
    static void Main() {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string result = RemoveDuplicates(input);
        Console.WriteLine("String after removing duplicates: " + result);
    }
}
