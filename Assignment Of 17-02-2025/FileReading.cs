using System;
using System.IO;
class FileReadingEfficiency{
    public static void Main(){
        string filePath = "path_to_large_file"; 
        var start = DateTime.Now;
        ReadWithStreamReader(filePath, 1 * 1024 * 1024);
        var streamReaderTime1MB = DateTime.Now - start;
        start = DateTime.Now;
        ReadWithFileStream(filePath, 1 * 1024 * 1024);
        var fileStreamTime1MB = DateTime.Now - start;
        Console.WriteLine("StreamReader (1MB): " + streamReaderTime1MB.TotalMilliseconds );
        Console.WriteLine("FileStream (1MB): " + fileStreamTime1MB.TotalMilliseconds );
        start = DateTime.Now;
        ReadWithStreamReader(filePath, 100 * 1024 * 1024);
        var streamReaderTime100MB = DateTime.Now - start;
        start = DateTime.Now;
        ReadWithFileStream(filePath, 100 * 1024 * 1024);
        var fileStreamTime100MB = DateTime.Now - start;
        Console.WriteLine("StreamReader (100MB): " + streamReaderTime100MB.TotalMilliseconds );
        Console.WriteLine("FileStream (100MB): " + fileStreamTime100MB.TotalMilliseconds );
        start = DateTime.Now;
        ReadWithStreamReader(filePath, 500 * 1024 * 1024);
        var streamReaderTime500MB = DateTime.Now - start;
        start = DateTime.Now;
        ReadWithFileStream(filePath, 500 * 1024 * 1024);
        var fileStreamTime500MB = DateTime.Now - start;
        Console.WriteLine("StreamReader (500MB): " + streamReaderTime500MB.TotalMilliseconds );
        Console.WriteLine("FileStream (500MB): " + fileStreamTime500MB.TotalMilliseconds );
    }
    public static void ReadWithStreamReader(string filePath, int bytesToRead){
        using (StreamReader reader = new StreamReader(filePath)){
            char[] buffer = new char[bytesToRead];
            reader.ReadBlock(buffer, 0, bytesToRead);
        }
    }
    public static void ReadWithFileStream(string filePath, int bytesToRead){
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read)){
            byte[] buffer = new byte[bytesToRead];
            fs.Read(buffer, 0, bytesToRead);
        }
    }
}
