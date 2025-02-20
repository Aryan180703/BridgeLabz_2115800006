using System;
using System.IO;
class FileReadWrite{
    static void Main(){
        string sourceFilePath = "source.txt";
        string destinationFilePath = "destination.txt";
        if (!File.Exists(sourceFilePath)){
            Console.WriteLine("Source file does not exist. Please check the file path.");
            return;
        }
        try{
            using (FileStream fsRead = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read)){
                using (FileStream fsWrite = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write)){
                    byte[] buffer = new byte[1024];
                    int bytesRead;

                    while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0){
                        fsWrite.Write(buffer, 0, bytesRead);
                    }
                }
            }
            Console.WriteLine("File copied successfully to " + destinationFilePath);
        }
        catch (IOException ex){
            Console.WriteLine("An error occurred while reading or writing the file.");
            Console.WriteLine("Error Details: " + ex.Message);
        }
        catch (UnauthorizedAccessException ex){
            Console.WriteLine("Access to the file is denied");
            Console.WriteLine("Error Details: " + ex.Message);
        }
        catch (Exception ex){
            Console.WriteLine("Unexpected Error");
            Console.WriteLine("Error Details: " + ex.Message);
        }
    }
}
