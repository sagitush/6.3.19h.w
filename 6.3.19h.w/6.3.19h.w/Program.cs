using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3._19h.w
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLibrary library = new MyLibrary();
            Dictionary<string, Book> books = new Dictionary<string, Book>();
            Book book1 = new Book("theWinter", "the bbbbbbbbbbbbbbbbbb", "jon grishem", "Action");
            Book book2 = new Book("sun", "the bbbbbbbbbbbbbbbbbb", "mery", "Action");
            Book book3 = new Book("pylot", "the bbbbbbbbbbbbbbbbbb", "leny", "Action");
            books.Add("theWinter", book1);
            books.Add("sun",book2);
            books.Add("pylot",book3);
            Console.WriteLine( library.AddBook(book1));
            Console.WriteLine(library.AddBook(book2));
            Console.WriteLine(library.AddBook(book3));
            Console.WriteLine(library.RemoveBook("sun"));
            Console.WriteLine(library);

          



        }
    }
}
