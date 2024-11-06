using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ411
{
    internal class Manager : Worker
    {
        public Manager(string name, double salary, int id, string address, int count_peoples) : base(name, salary, id, address)
        {
            CountPeoplesOnDay = count_peoples;
        }

        public int CountPeoplesOnDay { get; set; }

        public override void Print()
        {
            Console.WriteLine(this);
            Console.WriteLine();
        }

        public override void Work()
        {
            Console.WriteLine($"Work Manager {Name}");
            Console.WriteLine();
        }

        public override string ToString()
        {
            return base.ToString() + $"\nCountPeoplesOnDay: {CountPeoplesOnDay}";
        }
    }
}
