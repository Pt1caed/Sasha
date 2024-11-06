using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ411
{
    internal class Ukulele : MusicalInstrument
    {
        public Ukulele(string name, string description, string history, double size) : base(name, description, history)
        {
            Size = size;
        }

        public double Size { get; set; }

        public override void Sound()
        {
            Console.WriteLine($"*Sound Ukulele {InstrumentName}*");
        }
        public override void History()
        {
            Console.WriteLine($"History Ukulele {InstrumentName}: ");
            base.History();
        }
        public override void Desc()
        {
            Console.WriteLine($"Description Ukulele {InstrumentName}: ");
            base.Desc();
        }

        public override string ToString()
        {
            return base.ToString() + $" Size: {Size}";
        }
    }
}
