using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ611
{
    internal class Library : IEnumerable
    {
        private Book[] books;
        private int position = -1;

        public Library(int size)
        {
            books = new Book[size];
        }

        public bool MoveNext()
        {
            position++;
            return position < books.Length;
        }
        public void Reset()
        {
            position = -1;
        }

        public IEnumerator GetEnumerator() => books.GetEnumerator();

        public Book Current
        {
            get
            {
                try { return books[position]; }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current => books[position];


        public void Add(Book book,  int index)
        {
            if(index >= 0 && index < books.Length)
            {
                books[index] = book;
            }
        }
    }
}
