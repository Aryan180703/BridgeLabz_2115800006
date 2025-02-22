using System;
using System.Text.RegularExpressions;
class LinkExtractor {
    static void Main(string[] args) {
        if (args.Length == 0) {
            Console.WriteLine("Please provide a text containing links as a command-line argument.");
            return;
        }
        string inputText = string.Join(" ", args);
        string pattern = "https?://[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}(/[a-zA-Z0-9._~:/?#\\[\\]@!$&'()*+,;=%-]*)?";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(inputText);        
        Console.WriteLine("\nExtracted Links:");
        foreach (Match match in matches) {
            Console.WriteLine(match.Value);
        }
    }
}
