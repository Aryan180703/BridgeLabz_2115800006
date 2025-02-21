using System;
using System.IO;

class FileReader {
    static void Main() {
        string fileName = "file.txt";

        try {
            using (StreamReader reader = new StreamReader(fileName)) {
                string firstLine = reader.ReadLine();

                if (firstLine != null) {
                    Console.WriteLine("First line of the file : " + firstLine);
                } else {
                    Console.WriteLine("The file is empty");
                }
            }
        } catch (IOException) {
            Console.WriteLine("Error reading file");
        }
    }
}
