using System;
using System.Text.RegularExpressions;

class CapitalizedWordsExtractor {
    static void Main() {
        Console.WriteLine("Enter the sentence : ");
        string inputText = Console.ReadLine();
        string pattern = "\\b[A-Z][a-z]*\\b";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(inputText);        
        Console.WriteLine("\nExtracted Capitalized Words : ");
        foreach (Match match in matches) {
            Console.WriteLine(match.Value);
        }
    }
}
