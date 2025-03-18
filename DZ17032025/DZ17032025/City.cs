using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ17032025
{
    internal class City
    {
        public required string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
