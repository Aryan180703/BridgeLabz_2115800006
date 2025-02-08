using System;

public class Animal {
    private string name;
    private int age;
    public Animal(string name, int age) {
        this.name = name;
        this.age = age;
    }
    public string GetName() {
        return name;
    }
    public void SetName(string name) {
        this.name = name;
    }
    public int GetAge() {
        return age;
    }
    public void SetAge(int age) {
        this.age = age;
    }
    public virtual void MakeSound() {
        Console.WriteLine("Animal makes a sound");
    }
}
public class Dog : Animal {
    public Dog(string name, int age) : base(name, age) { }   
    public override void MakeSound() {
        Console.WriteLine("Dog barks");
    }
}
public class Cat : Animal {
    public Cat(string name, int age) : base(name, age) { }
    
    public override void MakeSound() {
        Console.WriteLine("Cat meows");
    }
}

public class Bird : Animal {
    public Bird(string name, int age) : base(name, age) { }   
    public override void MakeSound() {
        Console.WriteLine("Bird chirps");
    }
}