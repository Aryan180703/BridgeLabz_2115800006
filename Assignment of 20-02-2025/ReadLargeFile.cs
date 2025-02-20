using System;
using System.IO;

class LargeFileReader{
    static void Main(){
        string filePath = "largefile.txt";

        if (!File.Exists(filePath)){
            Console.WriteLine("File not found : " + filePath);
            return;
        }

        try{
            using (StreamReader reader = new StreamReader(filePath)){
                string line;
                while ((line = reader.ReadLine()) != null){
                    if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0){
                        Console.WriteLine(line);
                    }
                }
            }
        }
        catch (IOException ex){
            Console.WriteLine("An error occurred ");
            Console.WriteLine("Error Details : " + ex.Message);
        }
    }
}
