using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ10022025
{
    internal class Promotions
    {
        public int Id {  get; set; }
        public required string Name { get; set; }
        public int SectionId { get; set; }
        public DateOnly StartTime { get; set; }
        public DateOnly EndTime { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} | Name: {Name} | SectionId: {SectionId} | StartTime: {StartTime} | EndTime {EndTime}";
        }
    }
}
