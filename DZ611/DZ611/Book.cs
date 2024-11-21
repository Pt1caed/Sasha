using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DZ611
{
    internal class Book : IComparable, ICloneable
    {
        public Book(int pageCount, string author, string title, string desciption, double price)
        {
            PageCount = pageCount;
            Author = author;
            Title = title;
            Desciption = desciption;
            Price = price;
        }

        public int PageCount { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Desciption { get; set; }
        public double Price { get; set; }

        public int CompareTo(object? obj)
        {
            if (obj is Book)
            {
                return this.PageCount.CompareTo((obj as Book).PageCount);
            }
            throw new ArgumentException("Error type");
        }

        public object Clone()
        {
            return new Book(PageCount, Author, Title, Desciption, Price);   
        }

        public class SortAuthor : IComparer
        {
            public int Compare(object? x, object? y)
            {
                if (x is Book && y is Book)
                {
                    return (x as Book).Author.CompareTo((y as Book).Author);
                }
                throw new NotImplementedException();
            }
        }
        public class SortDescription : IComparer
        {
            public int Compare(object? x, object? y)
            {
                if (x is Book && y is Book)
                {
                    return (x as Book).Desciption.CompareTo((y as Book).Desciption);
                }
                throw new NotImplementedException();
            }

        }
        public class SortTitle : IComparer
        {
            public int Compare(object? x, object? y)
            {
                if (x is Book && y is Book)
                {
                    return (x as Book).Title.CompareTo((y as Book).Title);
                }
                throw new NotImplementedException();
            }
        }
        public class SortPrice : IComparer
        {
            public int Compare(object? x, object? y)
            {
                if (x is Book && y is Book)
                {
                    return (x as Book).Price.CompareTo((y as Book).Price);
                }
                throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
            return $"PageCount: {PageCount}; Author: {Author}; Title: {Title}; Description: {Desciption}; Price: {Price}; ";
        }
    }
}
