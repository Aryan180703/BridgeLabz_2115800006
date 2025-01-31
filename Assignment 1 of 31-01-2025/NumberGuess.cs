using System;
class NumberGuess{
    static void Main(string[] args){
        Console.WriteLine("Guess number : ");
        int s = 1, e = 100;
        int guess = Guess(s, e);
        Console.WriteLine("Number is : " + guess);
        int feedback = Feedback(s, e, guess);
        Console.WriteLine("Final guessed number: " + feedback);
    }
    static int Guess(int s, int e){
        Random r = new Random();
        return r.Next(s, e + 1);
    }
    static int Feedback(int s, int e, int r){
        while (true){
            Console.Write("Enter feedback (high, low, correct): ");
            string feedb = Console.ReadLine().ToLower();
            if (feedb == "high"){
                e = r - 1;
            }else if (feedb == "low")
            {
                s = r + 1;
            }else if (feedb == "correct")
            {
                return r;
            }else{
                Console.WriteLine("Invalid input. Please enter 'high', 'low', or 'correct'.");
                continue;
            }
            r = Guess(s, e);
            Console.WriteLine("New guess: " + r);
        }
    }
}
