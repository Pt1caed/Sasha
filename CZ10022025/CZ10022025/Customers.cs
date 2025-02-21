using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ10022025
{
    internal class Customers
    {
        public int Id { get; set; }
        public required string Surname { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public int GenderId { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} | Surname: {Surname} | Name: {Name} | Email: {Email} | GenderId: {GenderId}";
        }
    }
}
