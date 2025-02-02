using System;
public class Circle{
    private double radius;
    public Circle(){
        radius = 1.0;
    }
    public Circle(double r){
        radius = r;
    }
    public double GetArea(){
        return Math.PI * radius * radius;
    }
    public void DisplayDetails(){
        Console.WriteLine("Radius : " + radius);
        Console.WriteLine("Area : " + GetArea());
    }
}