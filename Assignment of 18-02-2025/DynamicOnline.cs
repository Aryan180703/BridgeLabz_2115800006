using System;
using System.Collections.Generic;

abstract class Category {
    public string name { get; set; } 
    public int id { get; set; } 
    public float price { get; set; } 
    public abstract void displayDetails(); 
}

class Book : Category {
    public string Publisher { get; set; } 
    public override void displayDetails() { 
        Console.WriteLine("Category: Book\nName: " + name + "\nID: " + id + "\nPrice: " + price + "\nPublisher: " + Publisher); 
    }
}

class Clothing : Category {
    public string brand { get; set; } 
    public override void displayDetails() { 
        Console.WriteLine("Category: Clothing\nName: " + name + "\nID: " + id + "\nPrice: " + price + "\nBrand: " + brand); 
    }
}

class Product<T> where T : Category {
    List<T> list1 = new List<T>(); 
    public void ApplyDiscount(T product, double percentage) { 
        product.price = product.price - (product.price * (float)(percentage / 100)); 
    }
    public void add(T item) { 
        list1.Add(item); 
    }
    public void Display() { 
        foreach (T item in list1) { 
            item.displayDetails(); 
        } 
    }
}

class Program {
    static void Main(string[] args) { 
        Product<Book> bookProduct = new Product<Book>(); 
        Book book1 = new Book { 
            name = "hello", 
            id = 101, 
            price = 2000, 
            Publisher = "NCERT" 
        }; 
        bookProduct.add(book1); 
        Console.WriteLine("Before Discount:"); 
        bookProduct.Display(); 
        bookProduct.ApplyDiscount(book1, 10); 
        Console.WriteLine("\nAfter Discount:"); 
        bookProduct.Display(); 
    }
}
