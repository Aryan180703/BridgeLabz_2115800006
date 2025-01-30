using System;
class AnagramCheck{
    static void Main(string[] args){
        Console.WriteLine("Enter a string : ");
        string str1 = Console.ReadLine();
        Console.WriteLine("Enter second string : ");
        string str2 = Console.ReadLine();
        bool ans = Anagram(str1,str2);
        Console.WriteLine(ans);
    }
    static bool Anagram(string str1 , string str2){
        if(str1.Length != str2.Length){
            return false;
        }
        char[] char1 = new char[str1.Length];
        char[]  char2 = new char[str2.Length];
        for(int i = 0 ; i < str1.Length;i++){
            char1[i] = str1[i];
            char2[i] = str2[i];
        }
        for (int i = 0; i < char1.Length - 1; i++) {
            for (int j = i + 1; j < char1.Length; j++) {
                if (char1[i] > char1[j]) {
                char temp = char1[i];
                char1[i] = char1[j];
                char1[j] = temp;
            }
            if (char2[i] > char2[j]) {
            char temp = char2[i];
            char2[i] = char2[j];
            char2[j] = temp;
            }
        } 
    }
    for(int i =0 ; i<char1.Length;i++){
            if(char1[i]!=char2[i]){
                return false;
            }       
        }
    return true;
}
}