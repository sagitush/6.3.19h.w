using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3._19h.w
{
    class MyLibrary
    {
        private Dictionary<string, Book> books = new Dictionary<string, Book>();

        public MyLibrary()
        {
                
        }

        public Boolean AddBook (Book book)
        {
            if (this.books.TryGetValue(book.Title, out book))
            {

                return false;
            }
            else
            {
                this.books.Add(book.Title, book);
                return false;
            }  
        }

        public Boolean RemoveBook(string title)
        {
            if (this.books.TryGetValue(title, out Book book))
            {
                this.books.Remove(title);
                return true;
            }
            else
                return false;
        }

        public Boolean HaveThisBook(string title)
        {
            if (this.books.TryGetValue(title, out Book book))
            {
                return true;
            }
            else
                return false;
        }

        public Book GetBook(string title)
        {
            if (this.books.TryGetValue(title, out Book book))
            {
                return book;
            }
            else
                return null;
        }

        public Book GetBookByAuthor(string author)
        {
            Dictionary<string, Book> books1 = new Dictionary<string, Book>();
            foreach (KeyValuePair<string, Book> item in this.books)
            {
                books1.Add(item.Value.Author, item.Value);
            }
                if (books1.TryGetValue(author, out Book book))
            {
                return book;
            }
            else
            {
                return null;
            }
        }

        public void Clear()
        {
            this.books.Clear();
        }

        public List<string> GetAuthors()
        {
            List<string> listOfAuthors = new List<string>();
            foreach (KeyValuePair<string,Book> item in this.books)
            {
               listOfAuthors.Add(item.Value.Author);
            }
            return listOfAuthors;
        }

        public List<Book> GetBooksSortedByAuthorsName()
        {
            List<Book> listOfboooks = new List<Book>();
            foreach (KeyValuePair<string, Book> item in this.books)
            {
                listOfboooks.Add(item.Value);
            }
            listOfboooks.Sort(new BookCompareByAuthorName());
            return listOfboooks;
        }

        public List<string> GetBooksTitleSorted()
        {
            List<string> listOfTitle = new List<string>();
            List<Book> listOfboooks = new List<Book>();
            foreach (KeyValuePair<string, Book> item in this.books)
            {
                listOfboooks.Add(item.Value);
            }
            listOfboooks.Sort();
            foreach (Book item in listOfboooks)
            {
                listOfTitle.Add(item.Title);
            }
            return listOfTitle;
        }

        public int Count
        {
            get
            {
                return this.books.Count;
            }
        }

        public override string ToString()
        {
            string result = "";
            foreach(KeyValuePair<string,Book> item in this.books)
            {
                result=result+$"{item.Key},{item.Value}\n";
            }
            return result;
        }
    }
}
