using System;

public class StudentVoteChecker {
    //this method will tell if a student can vote or not
    public static bool CanStudentVote(int age) {
        if (age < 0) {
            return false;
        }
        return age >= 18;
    }

    public static void Main(string[] args) {
        int[] studentAges = new int[10];
        Console.WriteLine("Enter student age for 10 students : ");
        for (int i = 0; i < studentAges.Length; i++) {
            studentAges[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("can vote or not : ");
        for (int i = 0; i < studentAges.Length; i++) {
            bool canVote = CanStudentVote(studentAges[i]);
            if (canVote) {
                Console.WriteLine($"Student {i + 1} age is {studentAges[i]} and can vote" );
            } else if (studentAges[i] < 0) {
                Console.WriteLine($"Student {i + 1} age is {studentAges[i]} not valid");
            } else {
                Console.WriteLine($"Student {i + 1}: age is {studentAges[i]} and cannot vote");
            }
        }
    }
}
