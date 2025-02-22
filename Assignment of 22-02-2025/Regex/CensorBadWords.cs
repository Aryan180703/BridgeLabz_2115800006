using System;
using System.Text.RegularExpressions;
class CensorBadWords {
    static void Main(string[] args) {
        if (args.Length == 0) {
            Console.WriteLine("Please provide a sentence as a command-line argument.");
            return;
        }
        string inputText = string.Join(" ", args);
        string[] badWords = { "damn", "stupid" };
        string pattern = "\\b(" + string.Join("|", badWords) + ")\\b";
        string result = Regex.Replace(inputText, pattern, "****", RegexOptions.IgnoreCase);        
        Console.WriteLine("\nCensored Sentence:");
        Console.WriteLine(result);
    }
}
