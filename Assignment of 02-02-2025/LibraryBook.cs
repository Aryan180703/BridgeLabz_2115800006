using System;
public class Book{
    public string ISBN;
    protected string title;
    private string author;
    public void SetAuthor(string auth){
        author = auth;
    }
    public string GetAuthor(){
        return author;
    }
}
public class EBook : Book{
    public void DisplayBookDetails(){
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + title);
    }
}
