using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DZ2810
{
    internal class Employee
    {
        private string? phone;
        private string? work_phone;
        private string? mail;
        private double salary;
        public string? Name { get; set; }
        public string? FullName { get; set; }
        public DateOnly Birthday { get; set; }
        public string? JobTitle { get; set; }
        public string? JobTitleDescription { get; set; }

        public Employee(string? name, string? fullname, int year, int month, int day, string? job_title, string? job_title_description, double salary, string? phone, string? work_phone, string? mail)
        {
            Name = name;
            FullName = fullname;
            Birthday = new DateOnly(year, month, day);
            JobTitle = job_title;
            JobTitleDescription = job_title_description;
            Phone = phone;
            WorkPhone = work_phone;
            Mail = mail;
            Salary = salary;
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
                else
                {
                    salary = 0;
                }
            }
        }

        public string? Phone
        {
            get { return phone; }
            set
            {
                try
                {
                    if (value?.Length < 11 || value?.Length > 16)
                    {
                        throw new Exception("Lenght phone < 11 or > 16");
                    }
                    else if (value?[0] != '+')
                    {
                        throw new Exception("No plus in first symbol");
                    }

                    for (int i = 1; i < value.Length; i++)
                    {
                        if(Char.IsDigit(value[i]) == false)
                        {
                            throw new Exception("Phone number after \"+\" is not numeric or more than one \"+\"");
                        }
                    }

                    phone = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " +  ex.Message);
                }
            }
        }
        public string? WorkPhone
        {
            get { return work_phone; }
            set
            {
                try
                {
                    if (value?.Length < 11 || value?.Length > 16)
                    {
                        throw new Exception("Lenght phone < 11 or > 16");
                    }
                    else if (value?[0] != '+')
                    {
                        throw new Exception("No plus in first symbol");
                    }

                    for (int i = 1; i < value.Length; i++)
                    {
                        if (Char.IsDigit(value[i]) == false)
                        {
                            throw new Exception("Work Phone number after \"+\" is not numeric or more than one \"+\"");
                        }
                    }

                    work_phone = value;
                }
                catch (Exception ex)
                {
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }

        public string? Mail
        {
            get { return mail; }
            set
            {
                try
                {

                    ArgumentNullException.ThrowIfNull(value); // мне это предложил Visual Studio

                    int count_dog = 0;
                    int count_dot = 0;
                    foreach (char a in value)
                    {
                        if (a == '@')
                        {
                            count_dog++;
                        }
                        else if (a == '.')
                        {
                            count_dot++;
                        }
                    }

                    if (count_dot > 1)
                    {
                        throw new Exception("Dot > 1 in mail");
                    }
                    else if (count_dog > 1)
                    {
                        throw new Exception("Dog > 1 in mail");
                    }
                    else
                    {
                        mail = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public static Employee operator +(Employee employee, double plus_salary)
        {
            Employee employee1 = employee;
            employee.Salary += plus_salary;

            return employee1;
        }
        public static Employee operator -(Employee employee, double minus_salary)
        {
            Employee employee1 = employee;

            employee.Salary -= minus_salary;

            if(employee1.Salary < 0)
                employee.Salary = 0;

            return employee1;
        }
        public static bool operator ==(Employee left, Employee right)
        {
            return left.Salary == right.Salary;
        }
        public static bool operator !=(Employee left, Employee right)
        {
            return !(left.Salary == right.Salary);
        }
        public static bool operator <(Employee left, Employee right)
        {
            return left.Salary < right.Salary;
        }
        public static bool operator >(Employee left, Employee right)
        {
            return left.Salary > right.Salary;
        }
        public static bool operator <=(Employee left, Employee right)
        {
            return left.Salary <= right.Salary;
        }
        public static bool operator >=(Employee left, Employee right)
        {
            return left.Salary >= right.Salary;
        }

        public override string ToString()
        {
            return ($"Name: {Name} FullName: {FullName} \nPhone: {Phone} WorkPhone: {WorkPhone} " +
                $"\nBirthday: {Birthday} \nJobTitle: {JobTitle} JobTitleDescription: {JobTitleDescription} \nSalary: {Salary} ");
        }
        public override bool Equals(object? obj)
        {
            return this.ToString() == obj?.ToString();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }       
}
