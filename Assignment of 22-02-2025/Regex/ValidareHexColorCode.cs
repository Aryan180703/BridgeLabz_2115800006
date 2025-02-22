using System;
using System.Text.RegularExpressions;

class HexColorValidator {
    static void Main() {
        Console.WriteLine("Enter a hex color code:");
        string hexColor = Console.ReadLine();
        string pattern = "^#([A-Fa-f0-9]{6})$";
        Regex regex = new Regex(pattern);        
        if (regex.IsMatch(hexColor)) {
            Console.WriteLine("Valid Hex Color Code");
        } else {
            Console.WriteLine("Invalid Hex Color Code");
        }
    }
}
