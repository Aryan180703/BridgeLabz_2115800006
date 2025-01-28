using System;

class EuclideanDistance
{
    //this method will calculate euclidean distance
    public static double CalculateDistance(double x1,double y1,double x2,double y2) {
        return Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
    }
    //this method will calculate line eqn
    public static double[] CalculateLineEquation(double x1, double y1, double x2, double y2) {
        double[] equation = new double[2];
        double m = (y2-y1)/(x2-x1);
        double b = y1-m*x1;
        equation[0] = m;
        equation[1] = b;
        return equation;
    }
    public static void Main() {
        double x1 =1,y1 =2,x2 = 4,y2= 6;
        double distance = CalculateDistance(x1,y1,x2,y2);
        double[] equation = CalculateLineEquation(x1,y1,x2, y2);
        Console.WriteLine("euclidean distance : " + distance);
        Console.WriteLine("equation of line : y = " + equation[0] + " x +  " + equation[1]);
    }
}
