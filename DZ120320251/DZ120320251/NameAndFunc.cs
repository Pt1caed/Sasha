using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ120320251
{
    internal class NameAndFunc
    {
        public required string Name { get; set; }   
        public required Func<Task> Action { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
