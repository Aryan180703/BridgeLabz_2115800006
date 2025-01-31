using System;
class Employee{
    private string name;
    private int id;
    private double salary;
    public Employee(string name, int id, double salary){
        this.name = name;
        this.id = id;
        this.salary = salary;
    }
    public void ShowDetails(){
        Console.WriteLine("Employee Details:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Salary: $" + salary);
    }
}

class DetailsOfEmployee{
    static void Main(){
        Employee emp = new Employee("John Doe", 101, 50000);
        emp.ShowDetails();
    }
}
