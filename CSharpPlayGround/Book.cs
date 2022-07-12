using System;
namespace CSharpPlayGround
{
    public class Book
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int? Pages { get; set; }
        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
            Console.WriteLine("Book is created");
        }   
        
    }
}

