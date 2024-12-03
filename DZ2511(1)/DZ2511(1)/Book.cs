using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2511_1_
{
    internal class Book
    {
        public Book(string name, string author, string genre, int year, int month, int day)
        {
            Name = name;
            Author = author;
            Genre = genre;
            DateRelease = new(year, month, day);
        }
        public Book(string name, string author, string genre, DateOnly date)
        {
            Name = name;
            Author = author;
            Genre = genre;
            DateRelease = date;
        }

        public string? Name { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public DateOnly DateRelease { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} | Author: {Author} | Genre: {Genre} | Date Release: {DateRelease}";
        }
    }
}
