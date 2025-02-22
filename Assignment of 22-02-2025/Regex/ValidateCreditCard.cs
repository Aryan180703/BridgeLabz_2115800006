using System;
using System.Text.RegularExpressions;

class CreditCardValidator {
    static void Main(string[] args) {
        if (args.Length == 0) {
            Console.WriteLine("Please provide a credit card number as a command-line argument.");
            return;
        }
        string cardNumber = string.Join(" ", args).Trim();
        string visaPattern = "^4[0-9]{15}$";
        string masterCardPattern = "^5[0-9]{15}$";
        bool isVisa = Regex.IsMatch(cardNumber, visaPattern);
        bool isMasterCard = Regex.IsMatch(cardNumber, masterCardPattern);        
        if (isVisa) {
            Console.WriteLine("\n'" + cardNumber + "' is a VALID Visa card number.");
        } 
        else if (isMasterCard) {
            Console.WriteLine("\n'" + cardNumber + "' is a VALID MasterCard number.");
        } 
        else {
            Console.WriteLine("\n'" + cardNumber + "' is an INVALID credit card number.");
        }
    }
}
