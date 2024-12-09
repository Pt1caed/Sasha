using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class NameAndMethodMenu
    {

        public NameAndMethodMenu(string name, Action method)
        {
            Name = name;
            Method = method;
        }
        public string? Name { get; set; }
        public Action? Method { get; set; }
    }
}
