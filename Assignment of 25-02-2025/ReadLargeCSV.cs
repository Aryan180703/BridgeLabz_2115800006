using System;
using System.IO;
class Program {
    static void Main(string[] args) {
        string filePath = "large_students.csv";
        int chunkSize = 100;
        int totalRecords = 0;
        if (!File.Exists(filePath)) {
            Console.WriteLine("CSV file not found.");
            return;
        }
        using (StreamReader reader = new StreamReader(filePath)) {
            reader.ReadLine();
            string line;
            int lineCount = 0;
            while ((line = reader.ReadLine()) != null) {
                lineCount++;
                totalRecords++;

                if (lineCount == chunkSize) {
                    Console.WriteLine("Processed " + totalRecords + " records.");
                    lineCount = 0;
                }
            }
            if (lineCount > 0) {
                Console.WriteLine("Processed " + totalRecords + " records.");
            }
        }
        Console.WriteLine("Total Records Processed: " + totalRecords);
    }
}
