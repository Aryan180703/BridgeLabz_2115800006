using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
class Program {
    static void Main(string[] args) {
        string csvFilePath = "employees_encrypted.csv";
        string decryptedFilePath = "employees_decrypted.csv";
        string key = "E546C8DF278CD5931069B522E695D4F2";
        List<Employee> employees = new List<Employee>() {
            new Employee { ID = "101", Name = "Ravi", Email = "ravi@example.com", Salary = "80000" },
            new Employee { ID = "102", Name = "Meera", Email = "meera@example.com", Salary = "75000" },
            new Employee { ID = "103", Name = "Ayaan", Email = "ayaan@example.com", Salary = "90000" }
        };
        EncryptAndWriteToCsv(employees, csvFilePath, key);
        DecryptAndReadFromCsv(csvFilePath, decryptedFilePath, key);
    }
    static void EncryptAndWriteToCsv(List<Employee> employees, string filePath, string key) {
        List<string> lines = new List<string>();
        lines.Add("ID,Name,Email,Salary");
        foreach (var emp in employees) {
            string encryptedEmail = Encrypt(emp.Email, key);
            string encryptedSalary = Encrypt(emp.Salary, key);
            string line = emp.ID + "," + emp.Name + "," + encryptedEmail + "," + encryptedSalary;
            lines.Add(line);
        }
        File.WriteAllLines(filePath, lines);
        Console.WriteLine("Encrypted data written to: " + filePath);
    }
    static void DecryptAndReadFromCsv(string filePath, string outputFilePath, string key) {
        if (!File.Exists(filePath)) {
            Console.WriteLine("CSV file not found.");
            return;
        }
        string[] lines = File.ReadAllLines(filePath);
        List<string> decryptedLines = new List<string>();
        decryptedLines.Add(lines[0]); 
        for (int i = 1; i < lines.Length; i++) {
            string[] data = lines[i].Split(',');
            string decryptedEmail = Decrypt(data[2], key);
            string decryptedSalary = Decrypt(data[3], key);
            string line = data[0] + "," + data[1] + "," + decryptedEmail + "," + decryptedSalary;
            decryptedLines.Add(line);
        }
        File.WriteAllLines(outputFilePath, decryptedLines);
        Console.WriteLine("Decrypted data written to: " + outputFilePath);
    }
    static string Encrypt(string plainText, string key) {
        byte[] keyBytes = Encoding.UTF8.GetBytes(key);
        byte[] iv = new byte[16];
        byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
        using (Aes aes = Aes.Create()) {
            aes.Key = keyBytes;
            aes.IV = iv;
            using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV)) {
                byte[] encryptedBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
                return Convert.ToBase64String(encryptedBytes);
            }
        }
    }
    static string Decrypt(string encryptedText, string key) {
        byte[] keyBytes = Encoding.UTF8.GetBytes(key);
        byte[] iv = new byte[16];
        byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
        using (Aes aes = Aes.Create()) {
            aes.Key = keyBytes;
            aes.IV = iv;
            using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV)) {
                byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }
    }
}
class Employee {
    public string ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Salary { get; set; }
}
