using System;
using System.Text;
class PalindromeChecker{
    static void Main(string[] args){
        Console.WriteLine("Enter a string to check for palindrome : ");
        string str = Console.ReadLine();
        CheckForPalindrome(str);
    }
    static void CheckForPalindrome(string str){
        StringBuilder strbul = new StringBuilder();
        for(int i = str.Length-1;i>=0;i--){
            strbul.Append(str[i]);
        }
        string str2 = strbul.ToString();
        if(str == str2){
            Console.WriteLine("yes, input string is palindrome");
        }
        else{
            Console.WriteLine("No, input string is not palindrome");
        }
    }
}