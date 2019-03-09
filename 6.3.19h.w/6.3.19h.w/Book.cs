using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3._19h.w
{
    class Book:IComparable<Book>
    {
        public string Title { get;private set; }
        public string Content { get;private set; }
        public string Author { get; private set; }
        public string Category { get; private set; }

        public Book(string title, string content, string author, string category)
        {
            Title = title;
            Content = content;
            Author = author;
            Category = category;
        }

        public override string ToString()
        {
            return $"Book {this.Title},author{this.Author},content:{this.Content},category{this.Category}";
        }

        public int CompareTo(Book other)
        {
            return this.Title.CompareTo(other.Title);
        }
    }
    class BookCompareByAuthorName : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Author.CompareTo(y.Author);
        }
    }
}
