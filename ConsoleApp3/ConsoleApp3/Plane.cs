using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Plane : Creature
    {
        private string name;
        private string manufacturer;
        private DateOnly date_manufacturer;
        private string type;

        public Plane(string name, string manufacturer, int year, int month, int day, string type)
        {
            if (month <= 0 || month > 12)
            {
                month = 1;
            }
            this.name = name;
            this.manufacturer = manufacturer;
            this.date_manufacturer = new DateOnly(year, month, day);
            this.type = type;
        }
        public Plane()
        {
            this.name = "N/A";
            this.manufacturer = "N/A";
            this.date_manufacturer = new DateOnly();
            this.type = "N/A";
        }

        public void SetName(string name)
        { this.name = name; }
        public void SetManufacturer(string manufacturer)
        { this.manufacturer = manufacturer; }
        public void SetDateManufacturer(int year, int month, int day)
        { this.date_manufacturer = new DateOnly(year, month, day); }
        public void SetType(string type)
        { this.type = type; }

        public string GetName()
        { return this.name; }
        public string GetManufacturer() 
        { return this.manufacturer; }
        public DateOnly GetDateManufacturer()
        { return this.date_manufacturer; }
        public string GetPlaneType()
        { return this.type; }

        public override void Info()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Manufacturer: " + this.manufacturer);
            Console.WriteLine("Date: " + this.date_manufacturer);
            Console.WriteLine("Type: " + this.type);
            Console.WriteLine();
        }
        public void Info(string info)
        {
            Info();
            Console.WriteLine("info message: " + info);
            Console.WriteLine();
        }
    }
}
