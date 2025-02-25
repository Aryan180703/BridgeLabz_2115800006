using System;
using System.IO;

class Program {
    static void Main(strings[] args) {
        string filePath = "employees.csv";
        string[] records = {
            "ID,Name,Department,Salary",
            "1,Aakash,HR,50000",
            "2,Neha,Finance,60000",
            "3,Rahul,IT,75000",
            "4,Priya,Marketing,55000",
            "5,Soham,Operations,62000"
        };
        File.WriteAllLines(filePath, records);
        Console.WriteLine("Employee details have been written to employees.csv");
    }
}
