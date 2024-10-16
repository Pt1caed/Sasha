using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Journal
    {
        private string? name;
       
        private string? telephone_number;
        private string? mail;

        public DateOnly Date {  get; set; }

        public string? Description { get; set; }

        public string? Name
        {
            set
            {
                if(value?.Length > 0)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Your name is short");
                }
            }
            get { return name; }
        }


        public string? TelephoneNumber
        {
            set
            {
                if(value?.Contains('+') == true && value?.Any(char.IsAsciiDigit) == true)
                {
                    telephone_number = value;
                }
                else
                {
                    Console.WriteLine("This is not telephone number");
                }
            }
            get { return telephone_number; }
        }

        public string? Mail
        {
            set
            {
                if(value?.Contains("@") == true)
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

        public override string ToString() => $"Name: {Name}, Date: {Date}, Telephone Number: {TelephoneNumber}, Mail: {Mail}, \n Description: {Description} \n";
    }
}
