using System;
class Circle{
    private double radius;
    public Circle(double radius){
        this.radius = radius;
    }
    public double CalculateArea(){
        return Math.PI * radius * radius;
    }
    public double CalculateCircumference(){
        return 2 * Math.PI * radius;
    }
    public void show(){
        Console.WriteLine("Area: " + CalculateArea());
        Console.WriteLine("Circumference: " + CalculateCircumference());
    }
}
class class2{
    static void Main(){
        Circle circle = new Circle(5);
        circle.show();
    }
}
