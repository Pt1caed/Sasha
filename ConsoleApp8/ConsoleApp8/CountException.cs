using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class CountException : Exception
    {
        public int Count { get; set; }
        public CountException(string message, int count) : base(message) 
        {
            Count = count;
        }
    }
}
