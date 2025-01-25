using System;
class StudentAge
{
    static void Main(String[] args)
    {
        int[] age = new int[10];
        //Loop to take user input of age of student
        for (int i = 0; i < age.Length; i++)
        {
            Console.Write($"Write age of {i+1}th student : ");
            age[i] = Convert.ToInt32(Console.ReadLine());
        }
        //this loop will print the output
        for (int i = 0; i < age.Length; i++)
        {
            //check if the age is a negative number
            if (age[i] < 0)
            {
                //print error of invalid age
                Console.Error.WriteLine("Invalid Age");
            }
            else
            {
                // print if the student can vote or not 
                Console.WriteLine(age[i] >= 18 ?
                    $"The student with the age {age[i]} can vote."
                    : $"The student with the age {age[i]} cannot vote.");

            }
        }
    }
}