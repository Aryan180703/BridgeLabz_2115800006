using System;
using System.IO;
class Program {
    static int CountWordOccurrences(string filePath, string word) {
        int count = 0;
        try {
            using (StreamReader sr = new StreamReader(filePath)) {
                string line;
                while ((line = sr.ReadLine()) != null) {
                    string[] words = line.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string w in words) {
                        if (w.Equals(word, StringComparison.OrdinalIgnoreCase)) {
                            count++;
                        }
                    }
                }
            }
        } catch (Exception e) {
            Console.WriteLine("Error: " + e.Message);
        }
        return count;
    }
    static void Main() {
        Console.WriteLine("Enter file path:");
        string filePath = Console.ReadLine();
        Console.WriteLine("Enter the word to count:");
        string word = Console.ReadLine();
        int occurrences = CountWordOccurrences(filePath, word);
        Console.WriteLine($"The word '{word}' appears {occurrences} times in the file.");
    }
}
