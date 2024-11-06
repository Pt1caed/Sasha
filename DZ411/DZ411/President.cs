using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ411
{
    internal class President : Worker
    {
        public President(string name, double salary, int id, string address, int yearsServiceNow) : base(name, salary, id, address)
        {
            YearsServiceNow = yearsServiceNow;
        }

        public int YearsServiceNow { get; set; }

        public override void Print()
        {
            Console.WriteLine(this);
            Console.WriteLine();
        }

        public override void Work()
        {
            Console.WriteLine($"Work President {Name}");
            Console.WriteLine();
        }

        public override string ToString()
        {
            return base.ToString() + $"\nYearsServiceNow: {YearsServiceNow}";
        }
    }
}
