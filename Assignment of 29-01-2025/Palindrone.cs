using System;
class PalindromeCheck{
    static void Main(String[] args){
        Console.WriteLine("Enter a String : ");
        string str = Console.ReadLine();
        bool ans = Palindrome(str);
        Console.WriteLine("is String palindrome ? : " + ans);
    }
    //method to check palindrome
    public static bool Palindrome(string str){
        int i = 0;
        int j = str.Length-1;
        while (i<j){
            if(str[i] != str[j]){
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}