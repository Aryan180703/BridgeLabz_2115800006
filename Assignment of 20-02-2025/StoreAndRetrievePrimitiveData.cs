using System;
using System.IO;

class StudentDetails{
    static string filePath = "student.txt";

    static void Main(){
        while (true){
            Console.WriteLine("\nStudent Data Management");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display Students");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice){
                case "1":
                    AddStudent();
                    break;
                case "2":
                    DisplayStudents();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    static void AddStudent(){
        try{
            using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fs)){
                Console.Write("Enter Roll Number  : ");
                int rollNumber = int.Parse(Console.ReadLine());

                Console.Write("Enter Name : ");
                string name = Console.ReadLine();

                Console.Write("Enter GPA : ");
                double gpa = double.Parse(Console.ReadLine());

                writer.Write(rollNumber);
                writer.Write(name);
                writer.Write(gpa);

                Console.WriteLine("Student details saved successfully.");
            }
        }
        catch (IOException ex){
            Console.WriteLine("An error occurred ");
            Console.WriteLine("Error Details : " + ex.Message);
        }
    }

    static void DisplayStudents(){
        if (!File.Exists(filePath)){
            Console.WriteLine("No student data found");
            return;
        }
        try{
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs)){
                Console.WriteLine("\nStudent List:");
                while (fs.Position < fs.Length){
                    int rollNumber = reader.ReadInt32();
                    string name = reader.ReadString();
                    double gpa = reader.ReadDouble();

                    Console.WriteLine("Roll Number: " + rollNumber + ", Name: " + name + ", GPA: " + gpa);
                }
            }
        }
        catch (IOException ex){
            Console.WriteLine("An error occurred ");
            Console.WriteLine("Error Details: " + ex.Message);
        }
    }
}
