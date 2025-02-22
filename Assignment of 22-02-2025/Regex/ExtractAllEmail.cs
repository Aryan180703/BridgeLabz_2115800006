using System;
using System.Text.RegularExpressions;

class EmailExtractor {
    static void Main() {
        Console.WriteLine("Enter the text : ");
        string inputText = Console.ReadLine();
        string pattern = "[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(inputText);        
        Console.WriteLine("\nExtracted Email Addresses:");
        foreach (Match match in matches) {
            Console.WriteLine(match.Value);
        }
    }
}
