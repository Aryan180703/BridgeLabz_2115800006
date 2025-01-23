using System;class YoungestAndTallest {
    static void Main(string[] args) {
        // Taking user input ages
        Console.Write("Enter Amar's age: ");
        int amarAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Akbar's age: ");
        int akbarAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Anthony's age: ");
        int anthonyAge = Convert.ToInt32(Console.ReadLine());        
        // Finding the youngest friend
        int youngestAge = Math.Min(amarAge, Math.Min(akbarAge, anthonyAge));
        string youngest = (youngestAge == amarAge) ? "Amar" :
                          (youngestAge == akbarAge) ? "Akbar" : "Anthony";
        Console.WriteLine($"The youngest friend is {youngest} with age {youngestAge}.");
        //user input  heights
        Console.Write("Enter Amar's height in cm: ");
        int amarHeight = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Akbar's height in cm: ");
        int akbarHeight = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Anthony's height in cm: ");
        int anthonyHeight = Convert.ToInt32(Console.ReadLine());
        // Finding tallest friend
        int tallestHeight = Math.Max(amarHeight, Math.Max(akbarHeight, anthonyHeight));
        string tallest = (tallestHeight == amarHeight) ? "Amar" :
                         (tallestHeight == akbarHeight) ? "Akbar" : "Anthony";
        Console.WriteLine($"The tallest friend is {tallest} with height {tallestHeight} cm.");
    }
}
