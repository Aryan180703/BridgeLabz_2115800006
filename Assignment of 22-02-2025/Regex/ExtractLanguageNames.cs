using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
class ExtractLanguages {
    static void Main(string[] args) {
        if (args.Length == 0) {
            Console.WriteLine("Please provide a text as a command-line argument.");
            return;
        }
        string inputText = string.Join(" ", args).Trim();
        string pattern = "\\b[A-Z][a-zA-Z]+\\b";
        MatchCollection matches = Regex.Matches(inputText, pattern);
        List<string> languages = new List<string>();
        foreach (Match match in matches) {
            languages.Add(match.Value);
        }        
        if (languages.Count > 0) {
            Console.WriteLine("\nExtracted Programming Languages:");
            Console.WriteLine(string.Join(", ", languages));
        } else {
            Console.WriteLine("\nNo programming languages found.");
        }
    }
}
