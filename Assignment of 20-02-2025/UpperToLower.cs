using System;
using System.IO;

class UpperToLowerConverter{
    static void Main(){
        string sourceFilePath = "text.txt";
        string destinationFilePath = "text2.txt";

        if (!File.Exists(sourceFilePath)){
            Console.WriteLine("file does not exist");
            return;
        }

        try{
            using (FileStream inputFileStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (BufferedStream bufferedInputStream = new BufferedStream(inputFileStream))
            using (StreamReader reader = new StreamReader(bufferedInputStream))
            using (FileStream outputFileStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
            using (BufferedStream bufferedOutputStream = new BufferedStream(outputFileStream))
            using (StreamWriter writer = new StreamWriter(bufferedOutputStream)){
                string line;
                while ((line = reader.ReadLine()) != null){
                    writer.WriteLine(line.ToLower());
                }
            }
            Console.WriteLine("Text converted to lowercase  " + destinationFilePath);
        }
        catch (IOException ex){
            Console.WriteLine("An error occurred ");
            Console.WriteLine("Error Details : " + ex.Message);
        }
    }
}
