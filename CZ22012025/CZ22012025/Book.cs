using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CZ22012025
{
    internal class Book
    {
        public int Id { get; set; }
        public string? Author { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public string? PublishingHouse { get; set; }
        public int CountPages {  get; set; }
        public int YearPublishingHouse { get; set; }


        public override string ToString()
        {
            return $"Id: {Id} | Author: {Author} | Name: {Name} | Category: {Category} | PublishingHouse: {PublishingHouse} | CountPages: {CountPages} | YearPublishingHouse: {YearPublishingHouse}";
        }
    }
}
