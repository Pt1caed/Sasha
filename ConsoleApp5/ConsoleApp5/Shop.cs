using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Shop
    {
        private string? name;
        private string? address;

        public string? Description {  get; set; }

        private string? telephone;
        private string? mail;

        public string? Name
        {
            set
            {
                if (value?.Length > 0)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("This name is short");
                }
            }
            get { return name; }
        }

        public string? Address
        {
            set
            {
                if (value != null)
                {
                    if (value.Contains("street"))
                    {
                        address = value;
                    }
                    else
                    {
                        Console.WriteLine("I dont see word \"street\" in address");
                    }
                }
                else
                {
                    Console.WriteLine("Stroke = null");
                }
            }
            get { return address; }
        }
        public string? Mail
        {
            set
            {
                if (value?.Contains("@") == true)
                {
                    mail = value;
                }
                else
                {
                    Console.WriteLine("This is not mail");
                }
            }
            get { return mail; }
        }


        public override string ToString() => $"Name: {Name}, Address: {Address}, Telephone: {telephone}, Mail: {Mail} \n Description: {Description} \n";
    }
}
