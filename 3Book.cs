using System;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public Book()
    {
        Title = "sky";
        Author = "john";
        ISBN = "122-3895225642";
    }
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        ISBN = "000-0000000000";
    }
    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
    }
}
