using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Plane
    {
        private string name;
        private string manufacturer;
        private DateOnly date_manufacturer;
        private string type;

        public Plane(string name, string manufacturer, DateOnly date_manufacturer, string type)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.date_manufacturer = date_manufacturer;
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
        public void SetDateManufacturer(DateOnly date_manufacturer)
        { this.date_manufacturer = date_manufacturer; }
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

        public void Info()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Manufacturer: " + this.manufacturer);
            Console.WriteLine("Date: " + this.date_manufacturer);
            Console.WriteLine("Type: " + this.type);
        }
        public void Info(string info)
        {
            Info();
            Console.WriteLine("info message: " + info);
        }
    }
}
