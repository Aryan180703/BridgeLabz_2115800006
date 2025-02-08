using System;
interface Worker {
    void PerformDuties();
}
class Person {
    public string Name { get; set; }
    public int Id { get; set; }
    public Person(string name, int id) {
        Name = name;
        Id = id;
    }
    public void DisplayInfo() {
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("ID : " + Id);
    }
}
class Chef : Person, Worker {
    public string Specialty { get; set; }
    public Chef(string name, int id, string specialty) : base(name, id) {
        Specialty = specialty;
    }
    public void PerformDuties() {
        Console.WriteLine("Preparing meal in kitchen");
    }
}

class Waiter : Person, Worker {
    public int TablesAssigned { get; set; }
    public Waiter(string name, int id, int tablesAssigned) : base(name, id) {
        TablesAssigned = tablesAssigned;
    }
    public void PerformDuties() {
        Console.WriteLine("Serving customer and taking order");
    }
}
