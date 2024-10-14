using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class City
    {
        private string name;
        private string country_name;
        private int count_peoples;
        private int number_code_city;
        private string[] names_districts;

        public City(string name, string country_name, int count_peoples, int number_code_city, string[] names_districts)
        {
            this.name = name;
            this.country_name = country_name;
            this.count_peoples = count_peoples;
            this.number_code_city = number_code_city;
            this.names_districts = names_districts;
        }
        public City()
        {
            this.name = "N/A";
            this.country_name = "N/A";
            this.count_peoples = 0;
            this.number_code_city = 0;
            this.names_districts = new string[1];
        }

        public string GetName()
        { return this.name; }
        public string GetCountryName()
            { return this.country_name; }
        public int GetCountPeoples()
        { return this.count_peoples; }
        public int GetNumberCodeCity()
        { return this.number_code_city; }
        public string NamesDistrictsIndex(int index)
        {
            if(index < 0 || index >= this.names_districts.Length)
            {
                return "";
            }
            return names_districts[index];
        }

        public void SetName(string name)
        {  this.name = name; }
        public void SetCountryName(string country_name)
        {  this.country_name = country_name;}
        public void SetCountPeoples(int count_peoples)
        { this.count_peoples = count_peoples; }
        public void SetNumberCityCode(int number_code)
        { this.number_code_city = number_code; }
        public void SetNamesDistrictsIndex(int index, string name_district)
        {
            names_districts[index] = name_district;
        }
        public void PushBack(string name_district)
        {
            var temp = new string[names_districts.Length];

            for(int i = 0; i < temp.Length; i++)
            {
                temp[i] = names_districts[i];
            }

            temp[names_districts.Length - 1] = name_district;
            names_districts = temp;
        }

        public void Info()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Country name: " + this.country_name);
            Console.WriteLine("Number Code City: " + this.number_code_city);
            Console.Write("Names districts: ");
            foreach(var i in this.names_districts)
            {
                Console.Write(i + ",  ");
            }
            Console.WriteLine();
        }
    }
}
