using System;
using System.Collections.Generic;
abstract class Employee{
    private string name;
    private int id;
    private double baseSalary;
    public string Name{
        get{return name;}
        private set{name = value;}
    }
    public int Id{
        get{return id;}
        private set{id = value;}
    }
    public double BaseSalary{
        get{return baseSalary;}
        private set{baseSalary = value;}
    }
    public Employee(string name, double baseSalary, int id){
        Name = name;
        Id = id;
        BaseSalary = baseSalary;
    }
    public abstract double CalculateSalary();
    public virtual void DisplayDetails(){
        Console.WriteLine("Name of employee : " +Name);
        Console.WriteLine("Employee Id :" +Id);
        Console.WriteLine("Salary : " + BaseSalary);
    }
}
interface IDepartment{
    void AssignDepartment(string department);
    string GetDepartmentDetails();
}
class FullTimeEmployee : Employee, IDepartment{
    public override double CalculateSalary(){
        return BaseSalary;
    }
    private string department;
    public void AssignDepartment(string department){
        this.department = department;
    }
    public string GetDepartmentDetails(){
        return department;
    }
    public FullTimeEmployee(string Name, double BaseSalary, int Id ):base(Name , BaseSalary , Id){
    }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Employee type : Full Time");
        Console.WriteLine("Department : " + GetDepartmentDetails());
    }

}

class PartTimeEmployee: Employee , IDepartment{
    private double workHours; 
    private double payPerHour;
    private string department;
    public void AssignDepartment(string department){
        this.department = department;
    }
    public string GetDepartmentDetails(){
        return department;
    }
    public override double CalculateSalary(){
        return payPerHour*workHours;
    }
    public PartTimeEmployee(string Name, int Id , double workHours , double payPerHour) : base(Name,payPerHour*workHours,Id){
        
        this.payPerHour = payPerHour;
        this.workHours = workHours;
    }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Employee type : Part Time");
        Console.WriteLine("Department : " + GetDepartmentDetails());
    }
}

class Program{
    static void Main(string[] args){
    string department;
    List<Employee> employees = new List<Employee>();
    while(true){
    Console.WriteLine("1. Register Employee");
    Console.WriteLine("2. Display Employee Details");
    Console.WriteLine("3. Exit");
    Console.Write("Enter your choice : ");
    int choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine();
    
    switch (choice)
    {
        case 1:
            Console.WriteLine("Choose Employee Type : ");
            Console.WriteLine("1. Full Time Employee");
            Console.WriteLine("2. Part Time Employee");
            Console.Write("Enter your choice : ");
            int choice1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter employee name : ");
            string Name = Console.ReadLine();
            Console.Write("Enter employee id : ");
            int Id = Convert.ToInt32(Console.ReadLine());
            switch (choice1)
            {
            case 1:
            Console.Write("Enter Salary : ");
            double BaseSalary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Department : ");
            department = Console.ReadLine();
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(Name,BaseSalary,Id);
            fullTimeEmployee.AssignDepartment(department);
            employees.Add(fullTimeEmployee);
            Console.WriteLine();
            Console.WriteLine();
            break;
            case 2:
            Console.Write("Enter Work hours : ");
            double workHours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Salary per hour : ");
            double payPerHour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Department : ");
            department = Console.ReadLine();
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee(Name,Id,workHours,payPerHour);
            partTimeEmployee.AssignDepartment(department);
            employees.Add(partTimeEmployee);
            Console.WriteLine();
            Console.WriteLine();
            break;
            default:
            Console.WriteLine("Not Valid Choice");
            Console.WriteLine();
            Console.WriteLine();
            break;
            }
            break;
        case 2:
            foreach(var i in employees){
                i.DisplayDetails();
                Console.WriteLine();
                Console.WriteLine();
            }
            break;
        case 3:
        return;
        default:
        Console.WriteLine("Not valid Choice");
        break;
    }
    }
    }
}