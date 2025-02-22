using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class FindRepeatingWords {
    static void Main(string[] args) {
        if (args.Length == 0) {
            Console.WriteLine("Please provide a sentence as a command-line argument.");
            return;
        }
        string inputText = string.Join(" ", args).Trim();
        string pattern = "\\b(\\w+)\\s+\\1\\b";
        MatchCollection matches = Regex.Matches(inputText, pattern, RegexOptions.IgnoreCase);
        HashSet<string> repeatingWords = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        foreach (Match match in matches) {
            repeatingWords.Add(match.Groups[1].Value);
        }        
        if (repeatingWords.Count > 0) {
            Console.WriteLine("\nRepeating Words:");
            Console.WriteLine(string.Join(", ", repeatingWords));
        } else {
            Console.WriteLine("\nNo repeating words found.");
        }
    }
}
