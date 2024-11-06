using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ411
{
    internal abstract class MusicalInstrument
    {
        public MusicalInstrument(string name, string description, string history) { InstrumentName = name; Description = description; InstrumentHistory = history; }

        public string? InstrumentName { get; set; }
        public string? Description { get; set; }
        public string? InstrumentHistory { get; set; }

        public abstract void Sound();
        public virtual void Desc()
        {
            Console.WriteLine(Description);
        }
        public virtual void History()
        {
            Console.WriteLine(InstrumentHistory);
        }

        public override string ToString()
        {
            return $"InstrumentName: {InstrumentName} Description: {Description} InstrumentHistory: {InstrumentHistory}";
        }
    }
}
