using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DZ17032025
{
    [DataContract]
    internal class Resume
    {
        private string text = null!;
        private int yearofexperience;
        private double salary;
        private City? city;
        public string Text { get; set; }
        public int YearOfExperience { get; set; }
        public double Salary { get; set; }
        public City? City { get; set; }

        public override string ToString()
        {
            return $"{text}";
        }
    }
}
