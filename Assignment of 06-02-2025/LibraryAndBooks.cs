using System;
using System.Collections.Generic;
class Book {
    public string Title { get; set; }
    public string Author { get; set; }
    public Book(string title, string author) {
        Title = title;
        Author = author;
    }
    public void DisplayInfo() {
        Console.WriteLine("Book: " + Title + ", Author: " + Author);
    }
}
class Library {
    public string Name { get; set; }
    private List<Book> books;   
    public Library(string name) {
        Name = name;
        books = new List<Book>();
    }    
    public void AddBook(Book book) {
        books.Add(book);
    }    
    public void DisplayBooks() {
        Console.WriteLine("Library: " + Name + " contains:");
        foreach (var book in books) {
            book.DisplayInfo();
        }
    }
}
class Program {
    static void Main() {
        Book book1 = new Book("A Tale of Two Cities", "Charles Dickens");
        Book book2 = new Book("Happy Potter", "J.K Rowling");
        Book book3 = new Book("let us C", "Yashavant Kanetkar");
        Library library1 = new Library("GLA Library");
        Library library2 = new Library("Library Of Hathras");
        library1.AddBook(book1);
        library1.AddBook(book2);
        library2.AddBook(book2);
        library2.AddBook(book3);
        library1.DisplayBooks();
        Console.WriteLine();
        library2.DisplayBooks();
    }
}
