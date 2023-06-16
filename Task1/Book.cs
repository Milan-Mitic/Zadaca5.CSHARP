using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Isbn { get; set; }
        public int PublishYear { get; set; }
        public int NumberOfPages { get; set; }

        public void GetBookDetails()
        {
            Console.WriteLine($"The book's title is {Title}. Author is {Author}. International book's number is {Isbn}. The book published {PublishYear} year. The book has {NumberOfPages} pages.");
        }
    }
}
