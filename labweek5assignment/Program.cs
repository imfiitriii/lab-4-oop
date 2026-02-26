using System;
using System.Collections;

class Library
{
    private string libraryName;
    private List<Member> members = new List<Member>();
    private List<Book> books = new List<Book>();

    public string LibraryName
    {
        get { return libraryName; }
        set { libraryName = value; }
    }
    public Library(string name)
    {
        libraryName = name;
    }

    public void addMembers(Member newMember)
    {
        members.Add(newMember);
        Console.WriteLine("Member added.");
    }

    public void addBook(Book newBook)
    {
        books.Add(newBook);
        Console.WriteLine("Book added.");
    }
}

class Book
{
    private string bookTitle;
    private int bookId;

    public string BookTitle
    {
        get { return  bookTitle; }
        set { bookTitle = value; }
    }
    public int BookId
    {
        get { return bookId; }
        set { bookId = value; }
    }

    public Book(string title, int id)
    {
        bookTitle = title;
        bookId = id;
    }
}

class Member
{
    private string Name;
    private int Id;

    public string name
    {
        get { return Name; } 
        set { Name = value; } 
    }

    public int id
    {
        get { return Id; }
        set { Id = value; }
    }

    public Member(string name, int id)
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