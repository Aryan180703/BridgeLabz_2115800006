using System;
class LongestWord{
    static void Main(string[] args){
        Console.Write("Enter a sentence : ");
        string str = Console.ReadLine();
        string longestWord = LongestWordFind(str);  
        Console.WriteLine("Longest Word : "+longestWord);
    }
    public static string LongestWordFind(string str){
        //word count
        int wordCount = 0;
        for(int i=0;i<str.Length;i++){
            if(str[i]==' '){
                wordCount++;
            }
        }
        string[] wordStore = new string[wordCount+1];
        string eachChar = null;
        int index = 0;
        for(int i=0;i<str.Length;i++){
            if(str[i]!=' '  ){
                eachChar+=str[i];
            }
            else{
                wordStore[index] = eachChar;
                eachChar = null;
                index++;
            }
        }
        wordStore[index] = eachChar;
        int longestCharcount = 0;
        string answer = null;
        foreach(string i in wordStore){
            int currentLongest = i.Length;
            if(currentLongest>longestCharcount){
                longestCharcount = currentLongest;
                answer = i;
            }
        }
        return answer;
    }

}