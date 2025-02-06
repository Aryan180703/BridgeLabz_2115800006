using System;
using System.Collections.Generic;
class Company {
    public string Name { get; set; }
    private List<Department> departments = new List<Department>();
    public Company(string name) {
        Name = name;
    }
    public void AddDepartment(string departmentName) {
        departments.Add(new Department(departmentName));
        Console.WriteLine("Department " + departmentName + " added to " + Name );
    }
}
class Department {
    public string Name { get; }
    private List<Employee> employees = new List<Employee>();
    public Department(string name) {
        Name = name;
    }
    public void AddEmployee(string employeeName) {
        employees.Add(new Employee(employeeName));
        Console.WriteLine("Employee " + employeeName + " added to Department " + Name);
    }
}
class Employee {
    public string Name { get; }
    public Employee(string name) {
        Name = name;
    }
}
class Program {
    static void Main() {
        Company company = new Company("Tech Corp");
        company.AddDepartment("IT");
        company.AddDepartment("HR");
    }
}
