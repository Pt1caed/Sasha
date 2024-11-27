using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2711
{
    internal class Piecse : IDisposable
    {
        public Piecse(string name, string author, string genre, int year, int month, int day)
        {
            Name = name;
            Author = author;
            Genre = genre;
            Date = new(year, month, day);
        }

        ~Piecse()
        {
            Console.WriteLine($"Деструктор {Name}");
            EndPiecse();

        }

        public void PlayPiecse()
        {
            Console.WriteLine(this);
            Console.WriteLine(Text);
        }

        public void EndPiecse()
        {
            Console.WriteLine("Пьеса окончена...\n");
        }

        public string? Text { get; set; }
        public string? Name {  get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public DateOnly Date { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} Author: {Author} Genre: {Genre} Date: {Date}";
        }

        public void Dispose()
        {
            Console.WriteLine($"Dispose {Name}");
            EndPiecse();
        }
    }
}
