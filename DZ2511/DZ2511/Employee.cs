using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DZ2511
{
    internal class Employee : IComparable<Employee>, ICloneable
    {
        public Employee(string name, string job_title, double salary, string mail)
        {
            FullName = name;
            JobTitle = job_title;
            Salary = salary;
            Mail = mail;
        }
        public Employee()
        {
            FullName = string.Empty;
            JobTitle = string.Empty;
            Salary = 0;
            Mail = string.Empty;
        }

        public string? FullName { get; set; }
        public string? JobTitle { get; set; }
        public double Salary {  get; set; }
        public string? Mail { get; set; }

        public override string ToString()
        {
            return $"FullName: {FullName} JobTitle: {JobTitle} Salary: {Salary} Mail: {Mail}";
        }

        public int CompareTo(Employee? other)
        {
            if (other == null)
                return 1;

            return Salary.CompareTo(other.Salary);
        }

        public object Clone()
        {
            if(FullName != null && JobTitle != null && Mail != null)
            {
                return new Employee(FullName, JobTitle, Salary, Mail);
            }
            throw new ArgumentException();
        }
    }


    class SortFullName : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return string.Compare(x?.FullName, y?.FullName);
        }
    }


    class SortJobTitle : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return string.Compare(x?.JobTitle, y?.JobTitle);
        }
    }

    class SortSalary : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            if(x == null) return 1;
            return x.Salary.CompareTo(y?.Salary);
        }
    }

    class SortMail : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return string.Compare(x?.Mail, y?.Mail);
        }
    }

}
