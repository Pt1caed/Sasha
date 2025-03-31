using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ31032025
{
    internal class ProcessAndName
    {
        public required Process Process { get; set; }
        public override string ToString()
        {
            return $"Name: {Process.ProcessName} | Id: {Process.Id} | BasePriority: {Process.BasePriority}";
            
        }

    }
}
