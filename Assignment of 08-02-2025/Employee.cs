using System;
public class Employee {
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }  
    public Employee(int Id, string Name, double Salary) {
        this.Id = Id;
        this.Name = Name;
        this.Salary = Salary;
    }
    public virtual void DisplayDetails() {
        Console.WriteLine("Id :" + Id);
        Console.WriteLine("Name :" + Name);
        Console.WriteLine("Salary :" + Salary);
    }
}
public class Manager : Employee {
    public int TeamSize;
    public Manager(int Id, string Name, double Salary, int TeamSize) : base(Id, Name, Salary) { 
        this.TeamSize = TeamSize;
    }
    public override void DisplayDetails() { 
        base.DisplayDetails();
        Console.WriteLine("TeamSize :" + TeamSize);
    }
}
public class Developer : Employee {
    public string ProgrammingLanguage;
    public Developer(int Id, string Name, double Salary, string ProgrammingLanguage) : base(Id, Name, Salary) {
        this.ProgrammingLanguage = ProgrammingLanguage;
    }
    public override void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine("Programming Language :" + ProgrammingLanguage);
    }
}
public class Intern : Employee {
    public string InternshipDuration;

    public Intern(int Id, string Name, double Salary, string InternshipDuration) : base(Id, Name, Salary) {
        this.InternshipDuration = InternshipDuration;
    }
    public override void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine("Internship Duration :" + InternshipDuration);
    }
}
