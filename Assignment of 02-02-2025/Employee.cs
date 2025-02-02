using System;
public class Employee{
    public int employeeID;
    protected string department;
    private double salary;
    public void SetSalary(double sal){
        salary = sal;
    }
    public double GetSalary(){
        return salary;
    }
}
public class Manager : Employee{
    public void DisplayManagerDetails(){
        Console.WriteLine("Employee ID: " + employeeID);
        Console.WriteLine("Department: " + department);
    }
}
