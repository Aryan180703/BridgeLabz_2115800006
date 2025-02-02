using System;
public class Book{
    private string title;
    private string author;
    private double price;
    public Book(){
        title = "book";
        author = "auth";
        price = 200;
    }
    public Book(string t, string a, double p){
        title = t;
        author = a;
        price = p;
    }
    public void DisplayDetails(){
        Console.WriteLine("Title: " + title + ", Author: " + author + ", Price: " + price);
    }
}
