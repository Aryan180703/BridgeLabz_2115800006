using System;
using System.Collections.Generic;
using System.IO;
class WordFrequencyCounter{
    static Dictionary<string, int> CountWords(string text){
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        string[] words = text.ToLower().Split(new char[] {' ', ',', '!', '.'}, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in words) {
            if (wordCount.ContainsKey(word)) {
                wordCount[word]++;
            } 
            else {
                wordCount[word] = 1;
            }
        }
        return wordCount;
    }

    static void Main(){
        string text = "Hello world, hello Java!";
        Dictionary<string, int> frequency = CountWords(text);
        foreach (var pair in frequency) {
            Console.Write(pair.Key + ":" + pair.Value + " ");
        }
    }
}
