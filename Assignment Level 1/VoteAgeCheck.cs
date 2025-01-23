using System;
class VoteAgeCheck{
    static void Main(string[] args){
        //user input age
        Console.Write("Enter age : ");
        int age = Convert.ToInt32(Console.ReadLine());
        EligibleToVote(age);
    }
    //this mehod checks if a person can vote or not
    static void EligibleToVote(int age){
        //conditionals to check if a person can vote or not
        if(age>=18){
            Console.WriteLine($"The person's age is {age} and can vote.");
        }
        else{
            Console.WriteLine($"The person's age is {age} and cannot vote.");
        }
    }
}