using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DZ2810
{
    internal class City
    {
        public City(string name, string country, string phone_code, int count_peoples, List<string> districts )
        {
            Name = name;
            Country = country;
            PhoneCode = phone_code;
            CountPeoples = count_peoples;
            this.districts = districts;
        }
        public City(string name, string country, string phone_code, int count_peoples)
        {
            Name = name;
            Country = country;
            PhoneCode = phone_code;
            CountPeoples = count_peoples;
            this.districts = new List<string>();
        }
        private int count_peoples;
        private List<string> districts;
        private string? phone_code;
        public string? Name { get; set; }
        public string? Country { get; set; }
            
        public int CountPeoples
        {
            get { return count_peoples; }
            set
            {
                try
                {
                    if (value > 0)
                    {
                        count_peoples = value;
                    }
                    else
                    {
                        count_peoples = 0;
                    }
                }
                catch(Exception ex)
                { Console.WriteLine("Error: " + ex.Message); }
            }
        }
        public string? PhoneCode
        {
            get { return phone_code; }
            set
            {
                try
                {
                    if (int.TryParse(value, out count_peoples) == true)
                    {
                        phone_code = value;
                    }
                    else
                    {
                        throw new Exception("In Phone can't be symbols, only numeric");
                    }
                }
                catch (Exception ex) { Console.WriteLine("Error: " + ex.Message); }
            }
        }

        public static City operator +(City city, int plus_peoples)
        {
            City city1 = city;
            city1.CountPeoples += plus_peoples;
            return city1;
        }
        public static City operator -(City city, int plus_peoples)
        {
            City city1 = city;
            city1.CountPeoples -= plus_peoples;
            return city1;
        }
        public static bool operator == (City city1, City city2)
        {
            return city1.CountPeoples == city2.CountPeoples;
        }
        public static bool operator !=(City city1, City city2)
        {
            return !(city1.CountPeoples == city2.CountPeoples);
        }
        public static bool operator <(City city1, City city2)
        {
            return city1.CountPeoples < city2.CountPeoples;
        }
        public static bool operator >(City city1, City city2)
        {
            return city1.CountPeoples > city2.CountPeoples;
        }


        public override string ToString()
        {
            return $"Name: {Name} Country: {Country} \nPhoneCode: {PhoneCode} \nCountPeoples: {CountPeoples} \nDistricts: {string.Join(", ", districts)}";
        }
        public override bool Equals(object? obj)
        {
            return this.ToString() == obj?.ToString();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string this[int index]
        {
            get
            {
                return districts[index];
            }
            set
            {
                try
                {
                    if (index >= 0 && index < districts.Capacity)
                    {
                        districts[index] = value;
                    }
                    else
                    {
                        throw new IndexOutOfRangeException("Index > or < capacity list");
                    }
                }
                catch (Exception ex) { Console.WriteLine("Error: " + ex.Message); }
            }
        }
        public void PrintDistricts()
        {
            foreach(string district in districts)
            {
                Console.Write(district + ", ");
            }
            Console.WriteLine();
        }
    }
}
