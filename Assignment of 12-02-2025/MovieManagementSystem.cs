using System;

public class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public int Year { get; set; }
    public double Rating { get; set; }
    public Movie Next { get; set; }
    public Movie Prev { get; set; }

    public Movie(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        Next = null;
        Prev = null;
    }
}

public class MovieManagement
{
    private Movie Head;
    private Movie Tail;

    public void AddMovieAtStart(Movie movie)
    {
        if (Head == null)
        {
            Head = Tail = movie;
        }
        else
        {
            movie.Next = Head;
            Head.Prev = movie;
            Head = movie;
        }
    }

    public void AddMovieAtEnd(Movie movie)
    {
        if (Head == null)
        {
            Head = Tail = movie;
        }
        else
        {
            Tail.Next = movie;
            movie.Prev = Tail;
            Tail = movie;
        }
    }

    public void AddMovieAtPosition(Movie movie, int position)
    {
        if (position == 1)
        {
            AddMovieAtStart(movie);
            return;
        }

        Movie temp = Head;
        int count = 1;
        while (temp != null && count < position - 1)
        {
            temp = temp.Next;
            count++;
        }

        if (temp == null)
        {
            AddMovieAtEnd(movie);
        }
        else
        {
            movie.Next = temp.Next;
            if (temp.Next != null)
                temp.Next.Prev = movie;
            temp.Next = movie;
            movie.Prev = temp;
        }
    }

    public void RemoveMovieByTitle(string title)
    {
        Movie temp = Head;
        while (temp != null && temp.Title != title)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Movie not found.");
            return;
        }

        if (temp == Head)
        {
            Head = Head.Next;
            if (Head != null)
                Head.Prev = null;
        }
        else if (temp == Tail)
        {
            Tail = Tail.Prev;
            Tail.Next = null;
        }
        else
        {
            temp.Prev.Next = temp.Next;
            temp.Next.Prev = temp.Prev;
        }

        Console.WriteLine("Movie removed successfully.");
    }

    public void SearchByDirector(string director)
    {
        Movie temp = Head;
        while (temp != null)
        {
            if (temp.Director == director)
            {
                Console.WriteLine("Title: " + temp.Title);
                Console.WriteLine("Year: " + temp.Year);
                Console.WriteLine("Rating: " + temp.Rating);
                Console.WriteLine();
            }
            temp = temp.Next;
        }
    }

    public void SearchByRating(double rating)
    {
        Movie temp = Head;
        while (temp != null)
        {
            if (temp.Rating == rating)
            {
                Console.WriteLine("Title: " + temp.Title);
                Console.WriteLine("Director: " + temp.Director);
                Console.WriteLine("Year: " + temp.Year);
                Console.WriteLine();
            }
            temp = temp.Next;
        }
    }

    public void UpdateMovieRating(string title, double newRating)
    {
        Movie temp = Head;
        while (temp != null)
        {
            if (temp.Title == title)
            {
                temp.Rating = newRating;
                Console.WriteLine("Rating updated successfully.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Movie not found.");
    }

    public void DisplayMovies()
    {
        Movie temp = Head;
        while (temp != null)
        {
            Console.WriteLine("Title: " + temp.Title);
            Console.WriteLine("Director: " + temp.Director);
            Console.WriteLine("Year: " + temp.Year);
            Console.WriteLine("Rating: " + temp.Rating);
            Console.WriteLine();
            Console.ReadLine();
            temp = temp.Next;
        }
    }

    public void DisplayMoviesReverse()
    {
        Movie temp = Tail;
        while (temp != null)
        {
            Console.WriteLine("Title: " + temp.Title);
            Console.WriteLine("Director: " + temp.Director);
            Console.WriteLine("Year: " + temp.Year);
            Console.WriteLine("Rating: " + temp.Rating);
            Console.WriteLine();
            Console.ReadLine();
            temp = temp.Prev;
        }
    }

    public static void Main(string[] args)
    {
        MovieManagement management = new MovieManagement();

        while (true)
        {
            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. Remove Movie");
            Console.WriteLine("3. Search by Director");
            Console.WriteLine("4. Search by Rating");
            Console.WriteLine("5. Update Movie Rating");
            Console.WriteLine("6. Display Movies Forward");
            Console.WriteLine("7. Display Movies Reverse");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter Director: ");
                    string director = Console.ReadLine();
                    Console.Write("Enter Year: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Rating: ");
                    double rating = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Where to add movie?");
                    Console.WriteLine("1. At Beginning");
                    Console.WriteLine("2. At End");
                    Console.WriteLine("3. At a specific position");
                    int position = Convert.ToInt32(Console.ReadLine());
                    if (position == 1)
                        management.AddMovieAtStart(new Movie(title, director, year, rating));
                    else if (position == 2)
                        management.AddMovieAtEnd(new Movie(title, director, year, rating));
                    else
                    {
                        Console.Write("Enter position: ");
                        int pos = Convert.ToInt32(Console.ReadLine());
                        management.AddMovieAtPosition(new Movie(title, director, year, rating), pos);
                    }
                    break;
                case 8:
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}