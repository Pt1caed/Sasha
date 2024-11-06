using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ411
{
    internal class Cello : MusicalInstrument
    {
        public Cello(string name, string description, string history, string type_big_bow) : base(name, description, history)
        {
            TypeBigBow = type_big_bow;
        }

        public string TypeBigBow { get; set; }

        public override void Sound()
        {
            Console.WriteLine($"*Sound Big Cello {InstrumentName}");
        }
        public override void History()
        {
            Console.WriteLine($"History Cello {InstrumentName}: ");
            base.History();
        }
        public override void Desc()
        {
            Console.WriteLine($"Description Cello {InstrumentName}: ");
            base.Desc();
        }

        public override string ToString()
        {
            return base.ToString() + $" TypeBigBow: {TypeBigBow}";
        }
    }
}
