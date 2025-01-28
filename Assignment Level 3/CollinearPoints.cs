using System;
class CollinearPoints{
    //this method will check collinear by using slope
    public static bool CollinearUsingSlope(double x1, double y1, double x2, double y2, double x3, double y3) {
        double slopeAB = (y2-y1)/(x2-x1);
        double slopeBC = (y3-y2)/(x3-x2);
        double slopeAC = (y3-y1)/(x3-x1);
        return (slopeAB == slopeBC && slopeBC == slopeAC);
    }
    //this method will check collinear by using area
    public static bool CollinearUsingArea(double x1, double y1, double x2, double y2, double x3, double y3) {
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        return (area == 0);
    }

    public static void Main() {
        double x1 = 2, y1 = 4, x2 = 4, y2 = 6, x3 = 6, y3 = 8;
        bool usingSlope = CollinearUsingSlope(x1,y1,x2,y2,x3,y3);
        bool usingArea = CollinearUsingArea(x1,y1,x2,y2,x3,y3);
        Console.WriteLine("using the slope, collinear points :   " + usingSlope);
        Console.WriteLine("using area, collinear points : " + usingArea);
    }
}
