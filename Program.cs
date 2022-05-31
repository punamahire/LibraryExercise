using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryManager libMgr = new LibraryManager("Knowledge Space");
            Console.WriteLine($"Welcome to the {libMgr.Name} Library Management System!");

            Book book1 = new Book("The Shining", "Stephen King", new DateTime(2012, 1, 18), "suspense");
            // Console.WriteLine($"{book1.Title} by {book1.Author}");
            // Console.WriteLine();

            Book book2 = new Book("The Bell Jar", "Sylvia Plath", new DateTime(2009, 6, 26), "drama");
            Book book3 = new Book("Refactoring", "Martin Fowler", new DateTime(2007, 1, 11), "science");
            
            List<Book> books = new List<Book>();
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);

            // foreach (var book in books)
            // {
            //     Console.WriteLine($"{book.Title} by {book.Author}");
            // }
            
            libMgr.AddBook(book1);
            libMgr.AddBook(book2);
            libMgr.AddBook(book3);

            libMgr.DisplayBooks();
        }
    }
}
