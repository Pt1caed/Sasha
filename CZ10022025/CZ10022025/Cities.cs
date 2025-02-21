using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ10022025
{
    internal class Cities
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public required string Name { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} | Name: {Name} | CountryId: {CountryId}";
        }
    }
}
