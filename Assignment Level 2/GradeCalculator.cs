using System;
class GradeCalculator
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());
        double[,] marks = new double[numberOfStudents, 3]; // [students, subjects]
        double[] percentage = new double[numberOfStudents];
        string[] grades = new string[numberOfStudents];
        // user input marks 
        for (int i = 0; i < numberOfStudents; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                string subject = j == 0 ? "Physics" : j == 1 ? "Chemistry" : "Maths";
                do
                {
                    Console.Write($"Enter marks for {subject} of student {i + 1}: ");
                    marks[i, j] = double.Parse(Console.ReadLine());

                    // Ensure marks are positive
                    if (marks[i, j] < 0)
                        Console.WriteLine("Marks cannot be negative. Please enter positive marks.");
                } while (marks[i, j] < 0);
            }
        }
        // this loop will calculate percentage and grade
        for (int i = 0; i < numberOfStudents; i++)
        {
            double totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentage[i] = (totalMarks / 300) * 100; // Assuming full marks per subject is 100
            // Determine grade
            if (percentage[i] >= 80)
                grades[i] = "A";
            else if (percentage[i] >= 70)
                grades[i] = "B";
            else if (percentage[i] >= 60)
                grades[i] = "C";
            else if (percentage[i] >= 50)
                grades[i] = "D";
            else if (percentage[i] >= 40)
                grades[i] = "E";
            else
                grades[i] = "R";
        }
        //print marks, percentage, and grade
        Console.WriteLine("\nResults:");
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"Student {i + 1}:");
            Console.WriteLine($"  Physics: {marks[i, 0]}  Chemistry: {marks[i, 1]}  Maths: {marks[i, 2]}");
            Console.WriteLine($"  Percentage: {percentage[i]:F2}%  Grade: {grades[i]}");
            Console.WriteLine();
        }
    }
}
