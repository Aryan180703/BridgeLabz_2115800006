using System;
class Book {
    public string Title { get; set; }
    public int PublicationYear { get; set; }

    public Book(string title, int publicationYear) {
        Title = title;
        PublicationYear = publicationYear;
    }
    public virtual void DisplayInfo() {
        Console.WriteLine();
        Console.WriteLine("Title : " + Title);
        Console.WriteLine("Publication Year : " + PublicationYear);
    }
}

class Author : Book {
    public string Name { get; set; }
    public string Bio { get; set; }
    public Author(string title, int publicationYear, string name, string bio) 
        : base(title, publicationYear) {
        Name = name;
        Bio = bio;
    }
    public override void DisplayInfo() {
        base.DisplayInfo();
        Console.WriteLine("Author : " + Name);
        Console.WriteLine("Bio : " + Bio);
    }
}

class Program {
    static void Main() {
        Console.Write("Book Title : ");
        string title = Console.ReadLine();
        Console.Write("Publication Year : ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Author Name : ");
        string name = Console.ReadLine();
        Console.Write("Author Bio : ");
        string bio = Console.ReadLine();
        Console.WriteLine();
        Author author = new Author(title, year, name, bio);
        author.DisplayInfo();
    }
}