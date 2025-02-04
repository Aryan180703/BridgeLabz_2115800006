using System;
class Employee{
    public static string CompanyName = "TechCorp";
    private static int totalEmployees = 0;
    public readonly int Id;
    public string Name { get; set; }
    public string Designation { get; set; }
    public Employee(int id, string name, string designation){
        this.Id = id;
        this.Name = name;
        this.Designation = designation;
        totalEmployees++;
    }
    public static void DisplayTotalEmployees(){
        Console.WriteLine("Total Employees: " + totalEmployees);
    }
    public void DisplayDetails(){
        if (this is Employee) {
            Console.WriteLine("ID : " + Id);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Designation : " + Designation);
            Console.WriteLine("Company : " + CompanyName);
        }
        else{
            Console.WriteLine("Invalid employee object.");
        }
    }
}
class Program{
    public static void Main(string []args){
        Employee emp1 = new Employee(101, "Hanuman", "Software Engineer");
        Employee emp2 = new Employee(102, "Rohit", "Data Analyst");
        emp1.DisplayDetails();
        Console.WriteLine();
        emp2.DisplayDetails();
        Console.WriteLine();
        Employee.DisplayTotalEmployees();
    }
}