using System;
using System.Text.RegularExpressions;

class SpaceReplacer {
    static void Main(string[] args) {
        if (args.Length == 0) {
            Console.WriteLine("Please provide a text as a command-line argument.");
            return;
        }
        string inputText = string.Join(" ", args);
        string pattern = "\\s{2,}";
        string result = Regex.Replace(inputText, pattern, " ");        
        Console.WriteLine("\nModified String:");
        Console.WriteLine(result);
    }
}
