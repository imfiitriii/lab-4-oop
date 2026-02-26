using System;
using System.Collections;

class Library
{
    private string libraryName; //library name
    private List<Member> members = new List<Member>();//list of members
    private List<Book> books = new List<Book>();//list of books

    public string LibraryName//property
    {
        get { return libraryName; }
        set { libraryName = value; }
    }
    public Library(string name)//constructor
    {
        libraryName = name;
    }

    public void addMembers(Member newMember)//method
    {
        members.Add(newMember);
        Console.WriteLine("Member added.");
    }

    public void addBook(Book newBook)//method
    {
        books.Add(newBook);
        Console.WriteLine("Book added.");
    }
}

class Book//class
{
    private string bookTitle;//property
    private int bookId;//property

    public string BookTitle//property
    {
        get { return  bookTitle; }
        set { bookTitle = value; }
    }
    public int BookId
    {
        get { return bookId; }
        set { bookId = value; }
    }

    public Book(string title, int id)//constructor
    {
        bookTitle = title;
        bookId = id;
    }
}

class Member//class
{
    private string Name;//property
    private int Id;//property

    public string name//getter and setter
    {
        get { return Name; } 
        set { Name = value; } 
    }

    public int id//getter and setter
    {
        get { return Id; }
        set { Id = value; }
    }

    public Member(string name, int id)//constructor
    {
        Name = name;
        Id = id;
    }
}

class Program
{
    public static void Main()
    {
        Library myLibrary = new Library("Library 1");
        myLibrary.LibraryName = "IRC";
        Console.WriteLine("Library name : " + myLibrary.LibraryName);

        Book myBook = new Book("textBook", 1);
        Console.WriteLine("Book name : " + myBook.BookTitle);
        myLibrary.addBook(myBook);

        Member newMember = new Member("Abu", 24002020);
        Console.WriteLine("New member name : " + newMember.name);
        myLibrary.addMembers(newMember);
    }
}