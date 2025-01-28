using System;
class Roots
{
    // this method will find roots
    public static double[] FindRoots(double a, double b, double c)
    {
        double delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta > 0)
        {
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        else if (delta == 0)
        {
            double root = -b / (2 * a);
            return new double[] { root };
        }
        else
        {
            return new double[] { };
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter coefficient a : ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter coefficient b : ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter constant c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        double[] roots = FindRoots(a, b, c);
        // print roots
        if (roots.Length == 0)
        {
            Console.WriteLine("no real roots.");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine($"one real root: {roots[0]}");
        }
        else
        {
            Console.WriteLine($"two real roots : {roots[0]} and {roots[1]}");
        }
    }
}
