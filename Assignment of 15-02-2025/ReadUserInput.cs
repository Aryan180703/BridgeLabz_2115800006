using System;
using System.IO;
class Program {
    static void WriteUserInputToFile(string filePath) {
        try {
            using (StreamWriter sw = new StreamWriter(filePath)) {
                Console.WriteLine("Enter text to write to the file : ");           
                string line;
                while ((line = Console.ReadLine()) != "exit") {
                    sw.WriteLine(line);
                }
            }
            Console.WriteLine("Data successfully written to file.");
        } catch (Exception e) {
            Console.WriteLine("Error : " + e.Message);
        }
    }
    static void Main() {
        Console.WriteLine("Enter file path to save data : ");
        string filePath = Console.ReadLine();
        WriteUserInputToFile(filePath);
    }
}
