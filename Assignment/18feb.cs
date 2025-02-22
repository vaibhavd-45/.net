using System;
using System.Collections.Generic;

public class Book
{
    public int BookID { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; }

    public Book(int bookID, string title, string author)
    {
        BookID = bookID;
        Title = title;
        Author = author;
        IsAvailable = true;
    }

    public void DisplayBookDetails()
    {
        Console.WriteLine($"[ID: {BookID}, Title: \"{Title}\", Author: \"{Author}\"]");
    }

    public void DisplayBookDetails(bool includeAvailability)
    {
        DisplayBookDetails();
        if (includeAvailability)
        {
            Console.WriteLine($"Status: {(IsAvailable ? "Available" : "Not Available")}");
        }
    }
}

public class User
{
    public int UserID { get; set; }
    public string Name { get; set; }
    public int BorrowedBookID { get; set; }

    public User(int userID, string name)
    {
        UserID = userID;
        Name = name;
        BorrowedBookID = -1; // -1 indicates no book borrowed
    }

    public void DisplayUserDetails()
    {
        Console.WriteLine($"[ID: {UserID}, Name: \"{Name}\"]");
    }
}

public class PremiumUser : User
{
    public string MembershipLevel { get; set; }

    public PremiumUser(int userID, string name, string membershipLevel) : base(userID, name)
    {
        MembershipLevel = membershipLevel;
    }

    public override void DisplayUserDetails()
    {
        base.DisplayUserDetails();
        Console.WriteLine($"Membership Level: {MembershipLevel}");
    }
}


public class Library
{
    public List<Book> Books { get; set; }
    public List<User> Users { get; set; }

    public Library()
    {
        Books = new List<Book>();
        Users = new List<User>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"Book Added: [ID: {book.BookID}, Title: \"{book.Title}\", Author: \"{book.Author}\"]");

    }

    public void AddUser(User user)
    {
        Users.Add(user);
        Console.WriteLine($"User Added: [ID: {user.UserID}, Name: \"{user.Name}\"]");
    }

    public void BorrowBook(int userID, int bookID)
    {
        Book book = Books.Find(b => b.BookID == bookID);
        User user = Users.Find(u => u.UserID == userID);

        if (book != null && user != null && book.IsAvailable)
        {
            book.IsAvailable = false;
            user.BorrowedBookID = bookID;
            Console.WriteLine($"{user.Name} borrowed \"{book.Title}\".");
        }
        else if (book == null)
        {
            Console.WriteLine("Book not found.");
        }
        else if (user == null)
        {
            Console.WriteLine("User not found.");
        }
        else if (!book.IsAvailable)
        {
            Console.WriteLine("Book is not available.");
        }

    }

    public void ReturnBook(int userID)
    {
        User user = Users.Find(u => u.UserID == userID);
        if (user != null && user.BorrowedBookID != -1)
        {
            Book book = Books.Find(b => b.BookID == user.BorrowedBookID);
            if (book != null)
            {
                book.IsAvailable = true;
                Console.WriteLine($"{user.Name} returned \"{book.Title}\".");
                user.BorrowedBookID = -1; // Reset BorrowedBookID
            }
        }
        else if (user == null)
        {
            Console.WriteLine("User not found.");
        }
        else
        {
            Console.WriteLine("User has not borrowed any book.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        Book book1 = new Book(101, "C# Basics", "John Doe");
        Book book2 = new Book(102, "Advanced C#", "Jane Smith");

        library.AddBook(book1);
        library.AddBook(book2);

        User user1 = new User(1, "Alice");
        PremiumUser user2 = new PremiumUser(2, "Bob", "Gold");

        library.AddUser(user1);
        library.AddUser(user2);


        book1.DisplayBookDetails(true);
        library.BorrowBook(1, 101);
        book1.DisplayBookDetails(true);
        library.ReturnBook(1);
        book1.DisplayBookDetails(true);

        user1.DisplayUserDetails();
        user2.DisplayUserDetails();


        Console.ReadKey();
    }
}