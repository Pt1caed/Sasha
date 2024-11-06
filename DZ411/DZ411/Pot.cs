using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ411
{
    internal class Pot : Device
    {
        public Pot(string? name, string? description) : base(description, name) { }

        public string? TypeMaterial { get; set; }

        public override void Sound()
        {
            Console.WriteLine("$Sound: Fuuuuuu!");
        }

        public override string ToString()
        {
            return base.ToString() + $" TypeMaterial: {TypeMaterial}";
        }
    }
}
