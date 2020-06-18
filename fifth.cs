using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace project.cs
{
    class fifth
    {
        //classes and constructors
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord of the Ring", "Tolkein", 700);
            

            Console.WriteLine(book2.author);
            Console.ReadLine();
        }
    }
    
    
        class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
