using System;
using System.Text;
class Program {
    static string ReverseString(string input) {
        StringBuilder sb = new StringBuilder();
        for (int i = input.Length - 1; i >= 0; i--) {
            sb.Append(input[i]);
        }
        return sb.ToString();
    }
    static void Main() {
        Console.WriteLine("Enter a string to reverse:");
        string input = Console.ReadLine();
        string reversed = ReverseString(input);
        Console.WriteLine("Reversed String: " + reversed);
    }
}
