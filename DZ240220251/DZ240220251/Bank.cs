using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ240220251
{
    internal class Bank
    {
        private int money;
        private int percent;
        public int Money
        {
            get 
            {
                return money; 
            }
            set
            {
                Interlocked.Exchange(ref money, value);
                ToStringFile();
            }
        }
        public int Percent
        {
            get
            {
                return percent;
            }
            set
            {
                Interlocked.Exchange(ref percent, value);
                ToStringFile();
            }
        }
        public string? Name { get; set; }

        public void ToStringFile()
        {
            using (StreamWriter sw = new($"{Path.Combine(Directory.GetCurrentDirectory(), "banks.txt")}", true))
            {
                sw.WriteLine($"{Name} | {Money} | {Percent}");
            }
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
