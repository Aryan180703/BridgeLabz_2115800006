using System;
using System.Collections.Generic;
using System.IO;

class WordCounter{
    static void Main(){
        string filePath = "file.txt";

        if (!File.Exists(filePath)){
            Console.WriteLine("File not found:  " + filePath);
            return;
        }

        Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        char[] cou = { ' ', '\t', '\n', '\r', ',', '.', '!', '?', ';', ':', '-', '(', ')', '[', ']', '{', '}', '"', '\'' };
        try{
            using (StreamReader reader = new StreamReader(filePath)){
                string line;
                while ((line = reader.ReadLine()) != null){
                    string[] words = line.Split(cou, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words){
                        if (wordCount.ContainsKey(word)){
                            wordCount[word]++;
                        }
                        else{
                            wordCount[word] = 1;
                        }
                    }
                }
            }
            int totalWords = 0;
            foreach (var count in wordCount.Values){
                totalWords += count;
            }
            Console.WriteLine("Total number of Words : " + totalWords);
            List<KeyValuePair<string, int>> wordList = new List<KeyValuePair<string, int>>();
            foreach (var entry in wordCount){
                wordList.Add(entry);
            }

            for (int i = 0; i < wordList.Count - 1; i++){
                for (int j = i + 1; j < wordList.Count; j++){
                    if (wordList[j].Value > wordList[i].Value){
                        var temp = wordList[i];
                        wordList[i] = wordList[j];
                        wordList[j] = temp;
                    }
                }
            }

            Console.WriteLine("\nTop 5 Most Frequent Words:");
            for (int i = 0; i < 5 && i < wordList.Count; i++){
                Console.WriteLine(wordList[i].Key + ": " + wordList[i].Value + " times");
            }
        }
        catch (IOException ex){
            Console.WriteLine("An error occurred");
            Console.WriteLine("Error Details  : " + ex.Message);
        }
    }
}
