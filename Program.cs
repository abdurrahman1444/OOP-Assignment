using System;
class Person
{
    protected int id;
    protected string name;

    // Constructor
    public Person()
    {
        id = 0;
        name = "Unknown";
    }
    public Person(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    // Method Overloading
    public void ShowInfo()
    {
        Console.WriteLine("Name: " + name);
    }

    public void ShowInfo(bool showId)
    {
        if (showId)
            Console.WriteLine("ID: " + id + ", Name: " + name);
    }
}

// Inheritance
class Member : Person
{
    public Member() : base() { }

    public Member(int id, string name) : base(id, name) { }

    public void BorrowBook()
    {
        Console.WriteLine(name + " borrowed a book.");
    }
}

class Book
{
    string title;
    string author;
    double price;

    // Constructor
    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
        price = 0;
    }

    // Constructor Overloading
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // Method Overloading
    public void Display()
    {
        Console.WriteLine("Title: " + title + ", Author: " + author);
    }

    public void Display(bool showPrice)
    {
        if (showPrice)
            Console.WriteLine("Title: " + title + ", Author: " + author + ", Price: $" + price);
    }

    // Destructor
    ~Book()
    {
        Console.WriteLine("Book object destroyed: " + title);
    }
}


class Program
{
    static void Main(string[] args)
    {
       
        Book b1 = new Book("Clean Code", "Robert Martin");
        Book b2 = new Book("Design Patterns", "Eric Freeman", 45);

        b1.Display();
        b2.Display(true);

        Console.WriteLine();

        
        Member m1 = new Member(101, "Abdur Rahman");
        Member m2 = new Member(102, "Mehrab");

        m1.ShowInfo(true);
        m2.ShowInfo();

        Console.WriteLine();

        m1.BorrowBook();
        m2.BorrowBook();

        Console.ReadKey();
    }
}
