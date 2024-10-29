using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DZ2910
{
    internal class Book
    {
        private List<string>? pages;
        public string? Title { set; get; }
        public string? Author { set; get; }
        public Book(string title, string author, List<string> pages)
        {
            Title = title;
            Author = author;
            if(this.pages == null)
            {
                throw new ArgumentNullException(nameof(this.pages));
            }
            for(int i = 0; i < pages.Count; i++)
            {
                if (this.pages[i] == null)
                {
                    this.pages = pages[..(i - 1)];
                    throw new Exception($"Page {i} is null");
                }
            }
            this.pages = pages;
        }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            pages = new List<string>();

        }

        public string Add
        {
            set
            {
                if(this.pages != null)
                {
                    pages.Add(value);
                }
            }
        }

        public int Count
        {
            get
            {
                if(pages == null)
                {
                    throw new Exception("Page == null");
                }
                return pages.Count; 
            }
        }


        public string this[int index]
        {
            get
            {
                if (pages == null)
                {
                    throw new Exception("Pages collection is not initialized.");
                }
                return pages[index];
            }
            set
            {
                if(pages == null)
                {
                    throw new Exception("Page == null");
                }
                if(value == null)
                {
                    throw new Exception("Value == null");
                }
                else
                {
                    pages[index] = value;
                }
            }
        }

        public static Book operator +(Book book, string page)
        {
            Book book1 = book;
            book1.pages?.Add(page);
            return book1;
        }
        public static Book operator -(Book book, int index)
        {
            Book book1 = book;
            book1.pages?.RemoveAt(index);
            return book1;
        }
        public static bool operator <(Book book1, Book book2)
        {
            return book1.Count < book2.Count;
        }
        public static bool operator >(Book book1, Book book2)
        {
            return book1.Count > book2.Count;   
        }

        public static bool operator ==(Book book1, Book book2)
        {
            return book1.Equals(book2);
        }
        public static bool operator !=(Book book1, Book book2)
        {
            return !book1.Equals(book2);
        }

        public override string ToString()
        {
            
            if(pages != null)
            {
                List<string> pages_string = new List<string>();
                pages_string.Add("Title: " + Title + "\n");
                pages_string.Add("Author: " + Author + "\n");
                for(int i = 0; i < Count; i++)
                {
                    pages_string.Add("Page: " + i + "\n");
                    pages_string.Add(pages[i]);
                    pages_string.Add("\n");
                }
                return string.Join("", pages_string);
            }
            else
            {
                return string.Empty;
            }
        }
        public override bool Equals(object? obj)
        {
            return obj?.ToString() == this.ToString();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void ReadPage(int page)
        {
            if(pages != null && page >= 0 && page < Count)
            {
                Console.WriteLine("Page: " + page);
                Console.WriteLine(pages?[page]);
            }
        }
    }
}
