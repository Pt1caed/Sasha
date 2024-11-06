using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ411
{
    internal class Vehicle : Device
    {
        private double km_hour;

        public double KmHour
        {
            get { return km_hour; }
            set
            {
                if (value < 0)
                {
                    km_hour = 0;
                }
                else
                {
                    km_hour = value;
                }
            }
        }

        public Vehicle(string? name, string? description) : base(name, description) { }
        public override void Sound()
        {
            Console.WriteLine("Wrum! Wru-u-u-m!");
        }

        public override string ToString()
        {
            return base.ToString() + $" KmHour: {KmHour}"; 
        }
    }
}
