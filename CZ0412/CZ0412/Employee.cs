using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ0412
{
    internal class Employee
    {
        public Employee(string name, string fullname, int age, string job_title, string contact_telephonel, string mail, double salary)
        {
            Name = name;
            Fullname = fullname;
            Age = age;
            JobTitle = job_title;
            ContactTelephone = contact_telephonel;
            Mail = mail;
            Salary = salary;
        }

        double salary;
        string? mail;

        public string? Name { get; set; }
        public string? Fullname { get; set; }
        public int Age { get; set; }
        public string? JobTitle { get; set; }
        public string? ContactTelephone {  get; set; }


        public string? Mail
        {
            get { return mail; }
            set
            {
                if (!value.Contains("@"))
                {
                    throw new ArgumentException();
                }
                else
                {
                    mail = value;
                }
            }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    salary = 0;
                }
                else { salary = value; }
            }
        }

        public override string ToString()
        {
            return $"Name: {Name} | FullName: {Fullname} | Age: {Age} | JobTitle: {JobTitle} | ContactTelephone: {ContactTelephone} | Mail: {Mail} | Salary: {Salary}";
        }
    }
}
