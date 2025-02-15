using System;
using System.IO;
using System.Text;
class Program {
    static void ReadBinaryFile(string filePath) {
        try {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs, Encoding.UTF8)) {
                string content = sr.ReadToEnd();
                Console.WriteLine("File Content:\n" + content);
            }
        } catch (Exception e) {
            Console.WriteLine("Error: " + e.Message);
        }
    }
    static void Main() {
        Console.WriteLine("Enter binary file path:");
        string filePath = Console.ReadLine();
        ReadBinaryFile(filePath);
    }
}
