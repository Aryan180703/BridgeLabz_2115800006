using System;
using System.IO;
class ImageToByteArray{
    static void Main(){
        string sourceImagePath = "image.jpg";
        string destinationImagePath = "image2.jpg";
        if (!File.Exists(sourceImagePath)){
            Console.WriteLine("image does not exist ");
            return;
        }
        try{
            byte[] imageBytes;
            using (FileStream fs = new FileStream(sourceImagePath, FileMode.Open, FileAccess.Read))
            using (MemoryStream ms = new MemoryStream()){
                fs.CopyTo(ms);
                imageBytes = ms.ToArray();
            }
            using (MemoryStream ms = new MemoryStream(imageBytes))
            using (FileStream fs = new FileStream(destinationImagePath, FileMode.Create, FileAccess.Write)){
                ms.CopyTo(fs);
            }
            Console.WriteLine("Image copied to " + destinationImagePath);
        }
        catch (IOException ex){
            Console.WriteLine("An error occurred ");
            Console.WriteLine("Error Details  : " + ex.Message);
        }
    }
}
