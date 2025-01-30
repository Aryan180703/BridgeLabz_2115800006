using System;
using System.Text;
class RemoveAllOccurences{
    static void Main(string[] args){
        Console.WriteLine("Enter a String : ");
        string str = Console.ReadLine();
        Console.WriteLine("character to remove : ");
        char ch = Convert.ToChar(Console.ReadLine());
        string ans = RemoveAllOccurence(str,ch);
        Console.WriteLine("Modified String : "+ans);
    }
    public static string RemoveAllOccurence(string str,char ch){
        StringBuilder strbul = new StringBuilder();
        for(int i = 0;i<str.Length;i++){
            if(str[i]!=ch){
                strbul.Append(str[i]);
            }
        }
        return strbul.ToString();
    }
}