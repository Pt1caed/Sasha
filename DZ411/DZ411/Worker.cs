using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ411
{
    internal abstract class Worker
    {
        public Worker(string name, double salary, int id, string address) 
        {
            Name = name;
            Salary = salary;
            Id = id;
            Address = address;
        }

        public string? Name {  get; set; }
        public double Salary { get; set; }
        public int Id { get; set; }
        public string? Address { get; set; }

        public abstract void Print();
        public abstract void Work();

        public override string ToString()
        {
            return $"Name : {Name} \nSalary: {Salary} \nID: {Id} \nAddress: {Address}";
        }
    }
}
