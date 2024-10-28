using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class ForeignPassport
    {
        private int number_passport;
        private string? issuing_authority;
        public ForeignPassport(string name, string full_name, int number_passport, string issuing_authority, int year, int month, int day, int year1, int month1, int day1)
        {
            this.Name = name;
            this.FullName = full_name;
            this.NumberPassport = number_passport;
            this.DateEnd = new DateOnly(year1, month1, day1);
            this.DateIssue = new DateOnly(year, month, day); 
            this.IssuingAuthority = issuing_authority;
        }
        public int NumberPassport
        {
            get { return number_passport; }
            set
            {
                try
                {
                    if (value.ToString().Length == 6)
                    {
                        number_passport = value;
                    }
                    else
                    {
                        throw new CountException("number passport lenght != 6", value.ToString().Length);
                    }
                }
                catch (CountException ex)
                {
                    Console.WriteLine("Error: " +  ex.Message);
                    Console.WriteLine("This lenght:" + ex.Count);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public string? IssuingAuthority
        {
            get
            {
                return issuing_authority;
            }
            set
            {
                try
                {
                    if (value?.Length <= 40 && value.Length > 0)
                    {
                        issuing_authority = value;
                    }
                    else
                    {
                        int lenght1;
                        if(value == null)
                        {
                            lenght1 = 0;
                        }
                        else
                        {
                            lenght1 = value.Length;
                        }
                        throw new CountException("Lenght is so big.", lenght1);
                    }
                }
                catch (CountException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    Console.WriteLine("This lenght:" + ex.Count);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        public string? Name { get; set; }
        public string? FullName { get; set; }
        public DateOnly DateEnd { get; set; }
        public DateOnly DateIssue { get; set; }

        public override string ToString()
        {
            return ($"Name: {Name} Fullname: {FullName} " +
                $"\nNumberPassword: {number_passport}, \nIssuingAuthority: {IssuingAuthority} \nDateIssue: {DateIssue} DateEnd: {DateEnd} ");
        }
        public override bool Equals(object? obj)
        {
            return (this.ToString() == obj?.ToString());
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
