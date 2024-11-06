using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ411
{
    internal class Engineer : Worker
    {
        public Engineer(string name, double salary, int id, string address) : base(name, salary, id, address) { }

        public string? TypeEngineer {  get; set; }

        public override void Print()
        {
            Console.WriteLine(this);
            Console.WriteLine();
        }
        public override void Work()
        {
            Console.WriteLine($"Work Engineer {Name}");
            Console.WriteLine();
        }

        public override string ToString()
        {
            return base.ToString() + $"\nTypeEngineer: {TypeEngineer}";
        }

    }
}
