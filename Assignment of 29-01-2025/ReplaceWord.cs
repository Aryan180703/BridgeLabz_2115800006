using System;
using System.Text;
class ReplaceWord {
    static void Main(string[] args) {
        Console.WriteLine("Enter the str: ");
        string str = Console.ReadLine();
        Console.WriteLine("Enter word to replace: ");
        string word = Console.ReadLine();
        Console.WriteLine("Enter new word: ");
        string newWord = Console.ReadLine();
        string ans = Replacew(str, word, newWord);
        Console.WriteLine("Updated Sentence: " + ans);
    }
    static string Replacew(string str, string oldWord, string newWord) {
        if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(oldWord)) {
            return str;
        }
        StringBuilder result = new StringBuilder();
        string word = "";
        bool isWord = false;
        for (int i = 0; i < str.Length; i++) {
            if (str[i] != ' ') {
                word += str[i];
                isWord = true;
            } else {
                if (isWord) {
                    if (word == oldWord) {
                        result.Append(newWord);
                    } else {
                        result.Append(word); 
                    }
                    result.Append(' '); 
                    word = ""; 
                    isWord = false;
                }
                else {
                    result.Append(str[i]);
                }
            }
        }
        if (isWord) {
            if (word == oldWord) {
                result.Append(newWord);
            } else {
                result.Append(word);
            }
        }
        return result.ToString();
    }
}
