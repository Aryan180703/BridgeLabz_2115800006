using System;
using System.IO;
class Program {
    static void ReadFileLineByLine(string filePath) {
        try {
            using (StreamReader sr = new StreamReader(filePath)) {
                string line;
                while((line = sr.ReadLine()) != null) {
                    Console.WriteLine(line);
                }
            }
        } catch (Exception e) {
            Console.WriteLine("Error : " + e.Message);
        }
    }
    static void Main() {
        Console.WriteLine("Enter file path:");
        string filePath = Console.ReadLine();
        ReadFileLineByLine(filePath);
    }
}
