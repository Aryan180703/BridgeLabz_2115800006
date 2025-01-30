using System;
using System.Text;
class MostFrequentCharacters{
    static void Main(string[] args){
        Console.WriteLine("Enter a string : ");
        string str = Console.ReadLine();
        char ch = MostFrequent(str);
        Console.WriteLine("Most Frequent Characters : " + ch);

    }
    public static char MostFrequent(string str){
        //remove duplicate
        StringBuilder strbul = new StringBuilder();
        for(int i =0;i<str.Length;i++){
            bool duplicate = false;
            for(int j = 0; j<strbul.Length;j++){
                if(str[i]==strbul[j]){
                    duplicate = true;
                    break;
                }
            }
            if(duplicate == false){
                strbul.Append(str[i]);
            }
        }
        string answer = strbul.ToString();
        // int FrequencyCount = 0;
        int currentMaxfrequency = 0;
        char currentMaxFrequencyChar=str[0];
        for(int i = 0;i<answer.Length;i++){
            int FrequencyCount = 0 ;
            for(int j = 0;j<str.Length;j++){
                if(str[j]==answer[i]){
                    FrequencyCount++;
                }
                if(currentMaxfrequency<FrequencyCount){
                    currentMaxfrequency = FrequencyCount;
                    currentMaxFrequencyChar = answer[i];
                }
            }
        }
        return currentMaxFrequencyChar;
    }
}