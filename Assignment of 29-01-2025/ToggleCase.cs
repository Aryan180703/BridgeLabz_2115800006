using System;
using System.Text;
class ToggleCase{
    static void Main(string[] args){
        Console.Write("Enter a String : ");
        string str = Console.ReadLine();
        string ans = ToggleString(str);
        Console.WriteLine("Toggle ans : "+ ans);
    }
    public static string ToggleString(string str){
        StringBuilder answer = new StringBuilder();
        for(int i = 0;i<str.Length;i++){
            char cha = str[i];
            int ch = (int)cha;
            if((ch>=65)&&(ch<=90)){
                ch+=32;
                answer.Append((char)ch);

            }
            else if((ch>=97)&&(ch<=122)){
                ch-=32;
                answer.Append((char)ch);
            }
            else{
                answer.Append((char)ch);
            }

        }
        return answer.ToString();
    }
}