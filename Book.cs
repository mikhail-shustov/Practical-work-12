using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Book
    {
        private readonly string ISBN;

        public string Title { get; set; }
        public string Author { get; set; }
        public Book(string isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
        }

        public void BookInfo()
        {
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Название: {Title}");
            Console.WriteLine($"Автор: {Author}");
        }
    }
}
