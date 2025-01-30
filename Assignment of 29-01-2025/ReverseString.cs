using System;
class StringReverse{
    static void Main(string[] args){
        Console.WriteLine("Enter a String : ");
        string str = Console.ReadLine();
        string answer = ReverseString(str);
        Console.WriteLine("reversed string : "+ answer);
    }
    public static string ReverseString(string str){
        string answer = null;
        for(int i=str.Length-1;i>=0;i--){
            char ch = str[i];
            answer+=ch;
        }
        return answer;
    }
}