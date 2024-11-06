using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ411
{
    internal class Violin : MusicalInstrument
    {
        public Violin(string name, string description, string history , string bow) : base(name, description, history) { NameBow = bow; }

        public string NameBow { get; set; }

        public override void Sound()
        {
            Console.WriteLine($"*Sound Violin {InstrumentName}*");
        }
        public override void Desc()
        {
            Console.WriteLine($"Desc violin {InstrumentName}: ");
            base.Desc();
        }
        public override void History()
        {
            Console.WriteLine($"History violin {InstrumentName}: ");
            base.History();
        }

        public override string ToString()
        {
            return base.ToString() + $" NameBow: {NameBow}";
        }
    }
}
