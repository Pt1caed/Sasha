using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ411
{
    internal class Security : Worker
    {
        public Security(string name, double salary, int id, string address, string name_gun) : base(name, salary, id, address)
        {
            Name = name;
        }

        public string? NameGun {  get; set; }

        public override void Print()
        {
            Console.WriteLine(this);
            Console.WriteLine();
        }

        public override void Work()
        {
            Console.WriteLine($"Work Security {NameGun}");
            Console.WriteLine();
        }

        public override string ToString()
        {
            return base.ToString() + $"\nNameGun: {NameGun}";
        }
    }
}
