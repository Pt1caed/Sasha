using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DZ411
{
    internal abstract class Device
    {
        public string? Description { get; set; }
        public string? Name { get; set; }

        public Device(string? name, string? description)
        {
            Name = name;
            Description = description;
        }

        public abstract void Sound();
        public virtual void Desc()
        {
            Console.WriteLine(Description);
        }
        public virtual void Show()
        {
            Console.WriteLine(Name);
        }

        public override string ToString()
        {
            return $"Name: {Name} Description: {Description}";
        }

        public override bool Equals(object? obj)
        {
            return this.ToString() == obj?.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator==(Device a, Device b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Device a, Device b)
        {
            return !a.Equals(b);
        }
    }
}
