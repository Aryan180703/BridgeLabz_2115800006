using System;
class GradeCalculatorUsing2D
{
    static void Main(string[] args)
    {
        //user input number of student
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());
        int[,] marks = new int[numberOfStudents, 3];
        double[] percentages = new double[numberOfStudents];
        string[] grades = new string[numberOfStudents];
        //user input marks for each student
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"Enter marks for student {i + 1}:");
            for (int j = 0; j < 3; j++)
            {
                string subject = j == 0 ? "Physics" : j == 1 ? "Chemistry" : "Maths";
                Console.Write($"Enter marks for {subject}: ");
                marks[i, j] = int.Parse(Console.ReadLine());
                if (marks[i, j] < 0)  // Ensure marks are positive
                {
                    Console.WriteLine("Marks can't be negative, please enter again.");
                    j--;
                }
            }
        }
        // this loop will calculate percentage and grade
        for (int i = 0; i < numberOfStudents; i++)
        {
            int totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentages[i] = (double)totalMarks / 3;
            //determine grade
            if (percentages[i] >= 80)
                grades[i] = "A";
            else if (percentages[i] >= 70)
                grades[i] = "B";
            else if (percentages[i] >= 60)
                grades[i] = "C";
            else if (percentages[i] >= 50)
                grades[i] = "D";
            else if (percentages[i] >= 40)
                grades[i] = "E";
            else
                grades[i] = "R";
        }
        //prints the result
        Console.WriteLine("\nResults:");
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"Student {i + 1}: Physics: {marks[i, 0]}, Chemistry: {marks[i, 1]}, Maths: {marks[i, 2]}, Percentage: {percentages[i]:F2}%, Grade: {grades[i]}");
        }
    }
}
