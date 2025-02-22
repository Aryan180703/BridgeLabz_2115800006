using System;
using System.Text.RegularExpressions;

class ValidateSSN {
    static void Main(string[] args) {
        if (args.Length == 0) {
            Console.WriteLine("Please provide a Social Security Number (SSN) as a command-line argument.");
            return;
        }
        string inputText = string.Join(" ", args).Trim();
        string pattern = "^\\d{3}-\\d{2}-\\d{4}$";
        bool isValid = Regex.IsMatch(inputText, pattern);        
        if (isValid) {
            Console.WriteLine("\"" + inputText + "\" is a valid SSN.");
        } else {
            Console.WriteLine("\"" + inputText + "\" is an invalid SSN.");
        }
    }
}
