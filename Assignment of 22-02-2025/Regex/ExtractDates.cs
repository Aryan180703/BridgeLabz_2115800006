using System;
using System.Text.RegularExpressions;
class DateExtractor {
    static void Main(string[] args) {
        if (args.Length == 0) {
            Console.WriteLine("Please provide a text containing dates as a command-line argument.");
            return;
        }
        string inputText = string.Join(" ", args);
        string pattern = "\\b(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/([0-9]{4})\\b";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(inputText);        
        Console.WriteLine("\nExtracted Dates:");
        foreach (Match match in matches) {
            Console.WriteLine(match.Value);
        }
    }
}
