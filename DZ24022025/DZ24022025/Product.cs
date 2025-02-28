using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ24022025
{
    internal class Product
    {
        public required string Name { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
