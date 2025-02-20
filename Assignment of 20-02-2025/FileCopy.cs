using System;
using System.Diagnostics;
using System.IO;

class BufferedFileCopy{
    static void Main(){
        string sourceFilePath = "largefile.txt";
        string destinationFilePathBuffered = "copied_with_buffer.txt";
        string destinationFilePathUnbuffered = "copied_with_unbuffe.txt";
        if (!File.Exists(sourceFilePath)){
            Console.WriteLine("file does not exist, check the file path.");
            return;
        }
        Console.WriteLine("Starting file copy using BufferedStream");
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        try{
            using (FileStream fsRead = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(destinationFilePathBuffered, FileMode.Create, FileAccess.Write))
            using (BufferedStream bsRead = new BufferedStream(fsRead))
            using (BufferedStream bsWrite = new BufferedStream(fsWrite)){
                byte[] buffer = new byte[4096];
                int bytesRead;

                while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0){
                    bsWrite.Write(buffer, 0, bytesRead);
                }
            }
            stopwatch.Stop();
            Console.WriteLine("BufferedStream copy completed in : " + stopwatch.ElapsedMilliseconds);
        }
        catch (IOException ex){
            Console.WriteLine("An error occurred during BufferedStream copy");
            Console.WriteLine("Error Details : " + ex.Message);
        }
        Console.WriteLine("\nStarting file copy using unbuffered FileStream");
        stopwatch.Restart();
        try{
            using (FileStream fsRead = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(destinationFilePathUnbuffered, FileMode.Create, FileAccess.Write)){
                byte[] buffer = new byte[4096];
                int bytesRead;

                while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0){
                    fsWrite.Write(buffer, 0, bytesRead);
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Unbuffered FileStream copy completed in : " + stopwatch.ElapsedMilliseconds );
        }
        catch (IOException ex){
            Console.WriteLine("An error occurred  ");
            Console.WriteLine("Error Details: " + ex.Message);
        }

        Console.WriteLine("\nFile copy comparison completed.");
    }
}
