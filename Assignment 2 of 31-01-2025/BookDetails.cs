using System;
class Book
{
    private string title;
    private string author;
    private double price;
    public Book(string title, string author, double price){
        this.title = title;
        this.author = author;
        this.price = price;
    }
    public void showDetails(){
        Console.WriteLine("Book Details:");
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
}
class Program{
    static void Main(){
        Book book = new Book("The Alchemist", "Paulo Coelho", 15.99);
        book.showDetails();
    }
}
