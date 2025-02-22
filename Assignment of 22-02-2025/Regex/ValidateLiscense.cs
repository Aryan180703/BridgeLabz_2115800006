using System;
using System.Text.RegularExpressions;

class LicensePlateValidator {
    static void Main() {
        Console.WriteLine("Enter a license plate number:");
        string licensePlate = Console.ReadLine();
        string pattern = "^[A-Z]{2}[0-9]{4}$";
        Regex regex = new Regex(pattern);        
        if (regex.IsMatch(licensePlate)) {
            Console.WriteLine("Valid License Plate Number");
        } else {
            Console.WriteLine("Invalid License Plate Number");
        }
    }
}
