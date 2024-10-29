using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DZ2910
{
    internal class ListBook
    {
        private List<Book> books;

        public ListBook(Book book)
        {
            this.books = [book];
        }
        public ListBook(List<Book> books)
        {
            this.books = books;
        }
        public ListBook()
        {
            this.books = [];
        }

        public int Count
        {
            get { return books.Count; }
        }

        public Book Add
        {
            set
            {
                books.Add(value);
            }
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void DeleteBook(int index)
        {
            books.RemoveAt(index);
        }

        public void Clear() => books.Clear();
        
        public bool IsBook()
        {
            if(books.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void ReadBook(int index)
        {
            Console.WriteLine(books[index].ToString());
        }
        public void ReadRandomBook()
        {
            Console.WriteLine(books[new Random().Next(0, Count)].ToString());
        }

        public Book this[int index]
        {
            get
            {
                return books[index];
            }
            set
            {
                try
                {
                    if (index > books.Count || index < 0)
                    {
                        throw new ArgumentOutOfRangeException("index: " + index);
                    }
                    else
                    {
                        books[index] = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public static ListBook operator+(ListBook listbook, Book book)
        {
            ListBook listbook1 = listbook;
            listbook.Add = book;
            return listbook1;
        }
        public static ListBook operator -(ListBook listbook, Book book)
        {
            for (int i = 0; i < listbook.Count; i++)
            {
                if(listbook[i] == book)
                {
                    listbook.DeleteBook(i);
                }
            }
            return listbook;
        }
        public static bool operator ==(ListBook left, ListBook right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(ListBook left, ListBook right)
        {
            return !left.Equals(right);
        }
        
        public static bool operator <(ListBook left, ListBook right)
        {
            return left.Count < right.Count;
        }

        public static bool operator >(ListBook left, ListBook right)
        {
            return left.Count < right.Count;
        }

        public override string ToString()
        {
            List<string> string_book = new List<string>();

            for (int i = 0; i < books.Count; i++)
            {
                string_book.Add($"{i}. Title: {books[i].Title}  Author: {books[i].Author}\n");
            }
            return string.Join("", string_book);
        }

        public override bool Equals(object? obj)
        {
            return this.ToString() == obj?.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
