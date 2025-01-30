using System;
class CountVowelsAndConsonents{
    static void Main(string[] args){
        Console.WriteLine("Enter a string : ");
        string str = Console.ReadLine();
        CountVowelsAndConsonent(str);
    }
    public static void CountVowelsAndConsonent(string str){
        int vowelCount = 0;
        int consonentCount = 0;
        for(int i =0;i<str.Length;i++){
            char ch =str[i];
            if(ch=='a'||ch=='A'||ch=='e'||ch=='E'||ch=='i'||ch=='I'||ch=='o'||ch=='O'||ch=='u'||ch=='U'){
                vowelCount++;
            }
            else if(ch == ' '){
                continue;
            }
            else{
                consonentCount++;
            }
        }
        Console.WriteLine("vowel count : "+vowelCount);
        Console.WriteLine("consonent count : "+consonentCount);
    }
} 