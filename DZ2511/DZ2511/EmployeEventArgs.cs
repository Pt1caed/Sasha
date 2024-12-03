using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2511
{
    internal class EmployeeEventArgs : EventArgs
    {
        public Employee? NewEmployee { get; set; }
    }
}
