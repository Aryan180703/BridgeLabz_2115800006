using System;
using System.Collections.Generic;
class University {
    public string Name { get; set; }
    private List<Department> departments = new List<Department>();
    private List<Faculty> faculties = new List<Faculty>();
    public University(string name) {
        Name = name;
    }
    public void AddDepartment(string departmentName) {
        departments.Add(new Department(departmentName));
        Console.WriteLine("Department " + departmentName + " added to " + Name );
    }
    public void AddFaculty(Faculty faculty) {
        faculties.Add(faculty);
        Console.WriteLine("Faculty " + faculty.Name + " added to " + Name );
    }
}
class Department {
    public string Name { get; }
    public Department(string name) {
        Name = name;
    }
}
class Faculty {
    public string Name { get; }
    public Faculty(string name) {
        Name = name;
    }
}
class Program {
    static void Main() {
        University university = new University("GLA University");
        university.AddDepartment("Computer Science");
        university.AddDepartment("CIvil Engineering");
        Faculty faculty1 = new Faculty("Abhishek Sharma");
        Faculty faculty2 = new Faculty("Sahil Kumar");        
        university.AddFaculty(faculty1);
        university.AddFaculty(faculty2);
    }
}
