using System;

namespace Library
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public string Genre { get; set; }

        public Book(string title, string author, DateTime publishDate, string genre)
        {
            Title = title;
            Author = author;
            PublishDate = publishDate;
            Genre = genre;
        }
    }
}