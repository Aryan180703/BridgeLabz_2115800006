using System;
using System.Collections.Generic;
abstract class Warehouse{
    public string name{get; set;}
    public int id{get; set; }
    public float price {get; set; }
    public abstract void displayDetails();
}
class Eletronics : Warehouse{
    public string brand{get; set;}
    public override void displayDetails()
    {
        Console.WriteLine("Elelctronic item : ID  = "+id+ " Name : "+name+" Price : "+price +" Brand : "+brand);
    }

}
class Groceries : Warehouse{
    public string expiryDate{get; set;}
    public override void displayDetails()
    {
        Console.WriteLine("Grocerie item : ID  = "+id+ " Name : "+name+" Price : "+price +" Expiry Date : "+expiryDate);
    }

}
class Furniture : Warehouse{
    public string materialUsed{get; set;}
    public override void displayDetails()
    {
        Console.WriteLine("Furniture item : ID  = "+id+ " Name : "+name+" Price : "+price +" Material Used : "+materialUsed);
    }
}
class Storage<T> where T:Warehouse{
    List<T> itemlist = new List<T>();
    public void add(T item){
        itemlist.Add(item);
    }
    public void Display(){
        foreach(T i in itemlist){
            i.displayDetails();
        }
    }
}
class Program{
    static void Main(string[] args){
        Eletronics s1 = new Eletronics();
        Storage<Warehouse> s11 = new Storage<Warehouse>();
        s1.name = "Laptop";
        s1.price = 20000;
        s1.id = 101;
        s1.brand = "Samsung";
        s11.add(s1);
        Eletronics s2 = new Eletronics();
        s2.name = "Smartphone";
        s2.price = 10000;
        s2.id = 102;
        s2.brand = "Realme";
        s11.add(s2);
        Groceries g1 = new Groceries();
        g1.name = "Parle G";
        g1.price = 10;
        g1.id = 1;
        g1.expiryDate = "15-03-2025";
        s11.add(g1);
        Furniture f1 = new Furniture();
        f1.name = "Sofa";
        f1.id = 10001;
        f1.price = 26000;
        f1.materialUsed = "Wooden";
        s11.add(f1);
        s11.Display();

    }
}