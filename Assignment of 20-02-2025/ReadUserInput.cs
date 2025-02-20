using System;
using System.IO;
class UserInputToFile{
    static void Main(){
        string filePath = "user_info.txt";
        try{
            Console.WriteLine("Enter your name : ");
            string name;
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput())){
                name = sr.ReadLine();
            }
            Console.WriteLine("Enter your age : ");
            string age;
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput())){
                age = sr.ReadLine();
            }
            Console.WriteLine("Enter your favorite language: ");
            string language;
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput())){
                language = sr.ReadLine();
            }
            using (StreamWriter sw = new StreamWriter(filePath)){
                sw.WriteLine("Name : " + name);
                sw.WriteLine("Age : " + age);
                sw.WriteLine("Favorite Language: " + language);
            }
            Console.WriteLine("User information saved to " + filePath);
        }
        catch (IOException ex){
            Console.WriteLine("An error occurred while saving the information.");
            Console.WriteLine("Error Details: " + ex.Message);
        }
    }
}
