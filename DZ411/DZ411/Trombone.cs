using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ411
{
    internal class Trombone : MusicalInstrument
    {
        public Trombone(string name, string description, string history, string typeTrombone) : base(name, description, history)
        {
            TypeTrombone = typeTrombone;
        }

        public string TypeTrombone {  get; set; }

        public override void Sound()
        {
            Console.WriteLine($"*Sound Trombone {InstrumentName}*");
        }
        public override void Desc()
        {
            Console.WriteLine($"Desc Trombone {InstrumentName}: ");
            base.Desc();
        }
        public override void History()
        {
            Console.WriteLine($"History Trombone {InstrumentHistory}");
            base.History();
        }

        public override string ToString()
        {
            return base.ToString() + $" TypeTrombone: {TypeTrombone}";
        }
    }
}
