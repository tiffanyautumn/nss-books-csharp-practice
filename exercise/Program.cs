using System;
using System.Collections.Generic;

namespace BooksAMillion
{
    class Program
    {
        static void Main(string[] args)
        {
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
            harryPotter.MaterialGenre.Add(yaFiction);
            Book hungerGames = new Book
            {
                Author = "Suzanne Collins",
                Title = "The Hunger Games",
                PublishDate = new DateTime(),
                NumOfPages = 300
            };
            hungerGames.MaterialGenre.Add(yaFiction);
            Book twilight = new Book
            {
                Author = "Stephenie Meyer",
                Title = "Twilight",
                PublishDate = new DateTime(),
                NumOfPages = 500
            };
            twilight.MaterialGenre.Add(yaFiction);
            twilight.MaterialGenre.Add(romance);

            List<Book> bookList = new List<Book>();
            bookList.Add(hungerGames);
            bookList.Add(twilight);
            bookList.Add(harryPotter);

            bookList.ForEach((book) => Console.WriteLine(book.DisplayName));

            Library myLibrary = new Library();
            myLibrary.AddMaterial(hungerGames);
            myLibrary.AddMaterial(new Magazine { Title = "Time Magazine", PublishDate = new DateTime(), NumOfPages = 65, IssueNum = 205 });
            myLibrary.AddMaterial(new AudioBook { Author = "J.R.R. Tolkein", Title = "The Hobbit", PublishDate = new DateTime(), PlaybackTime = 600 });
            Console.WriteLine("------------------");
            myLibrary.ListLibrary();
            myLibrary.ListBooks();

        }
    }
}



