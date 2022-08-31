using System;
using System.Collections.Generic;
Genre horror = new Genre
{
    Name = "Horror"
};
Genre yaFiction = new Genre
{
    Name = "Y.A. Fiction"
};
Genre romance = new Genre
{
    Name = "Romance"
};

Book harryPotter = new Book
{
    Author = "J.K. Rowling",
    Title = "Harry Potter and the Philosophers Stone",
    PublishDate = new DateTime(),
    NumOfPages = 400
};
harryPotter.BookGenre.Add(yaFiction);
Book hungerGames = new Book
{
    Author = "Suzanne Collins",
    Title = "The Hunger Games",
    PublishDate = new DateTime(),
    NumOfPages = 300
};
hungerGames.BookGenre.Add(yaFiction);
Book twilight = new Book
{
    Author = "Stephenie Meyer",
    Title = "Twilight",
    PublishDate = new DateTime(),
    NumOfPages = 500
};
twilight.BookGenre.Add(yaFiction);
twilight.BookGenre.Add(romance);

List<Book> bookList = new List<Book>();
bookList.Add(hungerGames);
bookList.Add(twilight);
bookList.Add(harryPotter);

bookList.ForEach((book) => Console.WriteLine(book.DisplayName));

Library myLibrary = new Library();
myLibrary

public class Book
{
    public string Author { get; set; }
    public string Title { get; set; }
    public DateTime PublishDate { get; set; }
    public int NumOfPages { get; set; }
    public List<Genre> BookGenre { get; set; } = new List<Genre>();

    public string DisplayName
    {
        get
        {
            return $"{Title} -by {Author}";
        }
    }
    public Book()
    {

    }
}
public class Library
{
    public string Name { get; set; }
    private List<Book> _privateBookList = new List<Book>();


    public Library()
    {

    }
    public void AddBook(Book book)
    {
        _privateBookList.Add(book);
    }

    public void ListLibrary()
    {
        foreach (Book book in _privateBookList)
        {
            Console.WriteLine($"{book.DisplayName}");
        }

    }
}

public class Genre
{
    public string Name { get; set; }
}
