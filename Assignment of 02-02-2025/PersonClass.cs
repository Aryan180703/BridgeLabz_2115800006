using System;
public class Person{
    private string name;
    private int age;
    public Person(){
        name = "Aryan";
        age = 21;
    }
    public Person(string n, int a){
        name = n;
        age = a;
    }
    public Person(Person other){
        name = other.name;
        age = other.age;
    }
    public void DisplayDetails(){
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Age : " + age);
    }
}