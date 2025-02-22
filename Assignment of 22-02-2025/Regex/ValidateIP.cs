using System;
using System.Text.RegularExpressions;
class IPAddressValidator {
    static void Main(string[] args) {
        if (args.Length == 0) {
            Console.WriteLine("Please provide an IP address as a command-line argument.");
            return;
        }
        string inputIP = string.Join(" ", args).Trim();
        string pattern = "^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
        bool isValid = Regex.IsMatch(inputIP, pattern);
        string[] parts = inputIP.Split('.');
        foreach (string part in parts) {
            if (part.Length > 1 && part.StartsWith("0")) {
                isValid = false;
                break;
            }
        }        
        if (isValid) {
            Console.WriteLine("\n'" + inputIP + "' is a VALID IPv4 address.");
        } else {
            Console.WriteLine("\n'" + inputIP + "' is an INVALID IPv4 address.");
        }
    }
}
