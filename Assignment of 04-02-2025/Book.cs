using System;
class Book{
    private static string LibraryName = "Main Library";
    public readonly string ISBN;
    public string Title { get; private set; }
    public string Author { get; private set; }
    public Book(string title, string author, string isbn){
        this.Title = title;
        this.Author = author;
        this.ISBN = isbn;
    }
    public static void DisplayLibraryName(){
        Console.WriteLine("Library Name : " + LibraryName);
    }
    public void DisplayBookDetails(){
        if (this is Book){
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("ISBN: " + ISBN);
        }
        else{
            Console.WriteLine("Invalid Book Object");
        }
    }
    public static void Main(string []args){
        Book.DisplayLibraryName();
        Book book1 = new Book("Letting Go", "David R. Hawkins", "123456789");
        Book book2 = new Book("Atomic Habits", "James Clear", "4872683764");
        Console.WriteLine("\nBook 1 Details:");
        book1.DisplayBookDetails();
        Console.WriteLine("\nBook 2 Details:");
        book2.DisplayBookDetails();
    }
}