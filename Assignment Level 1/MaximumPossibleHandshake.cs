using System;
class HandshakeCalculator{
    static void Main(string[] args){
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());
        int maxHandshakes = CalculateMaxHandshakes(numberOfStudents);
		// Print the result
        Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is {maxHandshakes}");
    }
    // This method will calculate the maximum number of handshakes
    static int CalculateMaxHandshakes(int numberOfStudents){
        return (numberOfStudents * (numberOfStudents - 1)) / 2;
    }
}
