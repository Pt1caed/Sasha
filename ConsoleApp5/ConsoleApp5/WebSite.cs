using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class WebSite
    {
        string? name;
        public string? ip;

        private string? url;
        public string? Url
        {
            set
            {
                if(value?.Contains("https://") == true)
                {
                    url = value;
                }
                else
                {
                    Console.WriteLine("This is not site");
                }
            }
            get
            {
                return url;
            }
        }
     
        public string? Description { get; set; }

        public string? Ip
        {
            set
            {
                if(value?.Length <= 50)
                {
                    ip = value;
                }
                else
                {
                    Console.WriteLine("Size is big.");
                }
            }
            get { return ip; }
        }

        public string? Name
        {
            set
            {
                if(value?.Length >= 2)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Write some longer name");
                }
            }
            get { return name; }
        }

        public override string ToString() => $"Name: {Name}, Url: {Url}, Ip: {Ip} \n Description: {Description} \n";
    }
}
