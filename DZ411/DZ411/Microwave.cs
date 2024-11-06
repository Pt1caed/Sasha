using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ411
{
    internal class Microwave : Device
    {
        public Microwave(string? name, string? description, double temperature) : base(name, description) { Temperature = temperature; }

        public double Temperature { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Bzzzzzz....");
        }

        public override string ToString()
        {
            return base.ToString() + $" Temperature: {Temperature}";
        }
    }
}
