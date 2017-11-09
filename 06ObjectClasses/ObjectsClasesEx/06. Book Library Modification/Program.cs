using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _6.Book_Library_Modification

{
    class Program
    {
        static void Main(string[] args)
        {
            int numberBooks = int.Parse(Console.ReadLine());

            Library library = new Library("My first Library");
            for (int i = 0; i < numberBooks; i++)
            {
                string line = Console.ReadLine();
                string[] lineargs = line.Split(' ').ToArray();
                string title = lineargs[0];
                string author = lineargs[1];
                string publisher = lineargs[2];
                DateTime releasDate = DateTime.Parse(lineargs[3], new CultureInfo("en-GB"));
                string ISBN = lineargs[4];
                decimal price = decimal.Parse(lineargs[5]);

                Book book = new Book(title, author, publisher, releasDate, ISBN, price);
                library.BookList.Add(book);
            }

            DateTime dateAfter = DateTime.Parse(Console.ReadLine(), new CultureInfo("en-GB"));

            foreach (var book in library.BookList.Where(date => date.ReleasedDate > dateAfter).OrderBy(date => date.ReleasedDate).ThenBy(title => title.Title))
            {
                Console.WriteLine("{0} -> {1:dd.MM.yyyy}", book.Title, book.ReleasedDate);
            }
        }
    }
    class Book
    {
        public Book(string title, string author, string publisher, DateTime releasDate, string ISBN, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleasedDate = releasDate;
            this.ISBNNumber = ISBN;
            this.Price = price;
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleasedDate { get; set; }
        public string ISBNNumber { get; set; }
        public decimal Price { get; set; }
    }
    class Library
    {
        public Library(string name)
        {
            this.Name = name;
            this.BookList = new List<Book>();
        }
        public string Name { get; set; }
        public List<Book> BookList { get; set; }
    }
}
