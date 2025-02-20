using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Employee{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class EmployeeManagement{
    static string filePath = "employees.json";

    static void Main(){
        List<Employee> employees = new List<Employee>();

        while (true){
            Console.WriteLine("\nEmployee Management System");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Save Employees to File");
            Console.WriteLine("3. Load Employees from File");
            Console.WriteLine("4. Display Employees");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            switch (choice){
                case "1":
                    AddEmployee(employees);
                    break;
                case "2":
                    SaveEmployeesToFile(employees);
                    break;
                case "3":
                    employees = LoadEmployeesFromFile();
                    break;
                case "4":
                    DisplayEmployees(employees);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
    static void AddEmployee(List<Employee> employees){
        Employee emp = new Employee();
        Console.Write("Enter Employee ID: ");
        emp.Id = int.Parse(Console.ReadLine());
        Console.Write("Enter Employee Name: ");
        emp.Name = Console.ReadLine();
        Console.Write("Enter Employee Department: ");
        emp.Department = Console.ReadLine();
        Console.Write("Enter Employee Salary: ");
        emp.Salary = double.Parse(Console.ReadLine());
        employees.Add(emp);
        Console.WriteLine("Employee added successfully.");
    }
    static void SaveEmployeesToFile(List<Employee> employees){
        try{
            string jsonData = JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonData);
            Console.WriteLine("Employees saved to file successfully.");
        }
        catch (IOException ex){
            Console.WriteLine("An error occurred while saving employees.");
            Console.WriteLine("Error Details : " + ex.Message);
        }
    }
    static List<Employee> LoadEmployeesFromFile(){
        try{
            if (File.Exists(filePath)){
                string jsonData = File.ReadAllText(filePath);
                List<Employee> employees = JsonSerializer.Deserialize<List<Employee>>(jsonData);
                Console.WriteLine("Employees loaded from file successfully.");
                return employees;
            }
            else{
                Console.WriteLine("No saved employee data found.");
                return new List<Employee>();
            }
        }
        catch (IOException ex){
            Console.WriteLine("An error occurred ");
            Console.WriteLine("Error Details : " + ex.Message);
            return new List<Employee>();
        }
    }
    static void DisplayEmployees(List<Employee> employees){
        if (employees.Count == 0){
            Console.WriteLine("No employees to display.");
        }
        else{
            Console.WriteLine("\nEmployee List:");
            foreach (var emp in employees){
                Console.WriteLine("ID: " + emp.Id + ", Name: " + emp.Name + ", Department: " + emp.Department + ", Salary: " + emp.Salary);
            }
        }
    }
}
