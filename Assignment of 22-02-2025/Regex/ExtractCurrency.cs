using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class ExtractCurrency {
    static void Main(string[] args) {
        if (args.Length == 0) {
            Console.WriteLine("Please provide a text as a command-line argument.");
            return;
        }
        string inputText = string.Join(" ", args).Trim();
        string pattern = "\\$?\\s?\\d+(\\.\\d{2})?";
        MatchCollection matches = Regex.Matches(inputText, pattern);
        List<string> currencyValues = new List<string>();
        foreach (Match match in matches) {
            currencyValues.Add(match.Value.Trim());
        }        
        if (currencyValues.Count > 0) {
            Console.WriteLine("\nExtracted Currency Values:");
            Console.WriteLine(string.Join(", ", currencyValues));
        } else {
            Console.WriteLine("\nNo currency values found.");
        }
    }
}
