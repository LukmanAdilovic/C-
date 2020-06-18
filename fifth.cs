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
}
