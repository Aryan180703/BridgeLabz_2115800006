using System;
using System.Text.RegularExpressions;

class UsernameValidator {
    static void Main(string[] args) {
        Console.WriteLine("Enter a username:");
        string username = Console.ReadLine();
        string pattern = "^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
        Regex regex = new Regex(pattern);
        if (regex.IsMatch(username)) {
            Console.WriteLine("Valid Username");
        } else {
            Console.WriteLine("Invalid Username");
        }
    }
}
