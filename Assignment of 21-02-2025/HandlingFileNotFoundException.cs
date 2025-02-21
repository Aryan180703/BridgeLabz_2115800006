using System;
using System.IO;

class FileReader {
    static void Main() {
        string filePath = "file.txt";

        try {
            string fileContents = File.ReadAllText(filePath);
            Console.WriteLine("File Contents:");
            Console.WriteLine(fileContents);
        } catch (FileNotFoundException) {
            Console.WriteLine("File not found");
        } catch (IOException ex) {
            Console.WriteLine("An error occurred ");
            Console.WriteLine("Error Details: " + ex.Message);
        }
    }
}
