using System;
public class Book{
    private string title;
    private string author;
    private double price;
    private bool availability;
    public Book(){
        title = "titlee";
        author = "aryan";
        price = 600;
        availability = true;
    }
    public Book(string t, string a, double p, bool avail){
        title = t;
        author = a;
        price = p;
        availability = avail;
    }
    public void BorrowBook(){
        if (availability){
            availability = false;
            Console.WriteLine("book '" + title + "' borrowed ");
        }
        else{
            Console.WriteLine("book '" + title + "' is already borrowed ");
        }
    }
    public void DisplayDetails(){
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Availability: " + (availability ? "Available" : "Not Available"));
    }
}
