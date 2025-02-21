using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace CZ10022025
{
    internal class Program
    {
        public static string? connectionString;
        static void Main(string[] args)
        {
             var builder = new ConfigurationBuilder();
            string path = Directory.GetCurrentDirectory();
            builder.SetBasePath(path);
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            connectionString = config.GetConnectionString("DefaultConnection");

            var a = typeof(CZ12022025).GetMethods(BindingFlags.Static | BindingFlags.Public);

            foreach(var item in a)
            {
                Console.WriteLine('\n' + item.Name + '\n');
                item.Invoke(null, null);
            }
            
        }

        public static void ViewAllCustomers()
        {
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                var list_customers = db.Query<Customers>("select * from Customers");
                foreach(var customer in list_customers)
                {
                    Console.WriteLine(customer);
                }
            }
        }
        public static void ViewAllCustomersEmails()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var list_emails = db.Query<string>("select C.Email from Customers C");
                foreach (var email in list_emails)
                {
                    Console.WriteLine(email);
                }
            }
        }
        public static void ViewAllSections()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var list_sections = db.Query<Sections>("select * from Sections");
                foreach (var section in list_sections)
                {
                    Console.WriteLine(section);
                }
            }
        }
        public static void ViewAllPromotions()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var list_promotions = db.Query<Promotions>("select * from Promotions");
                foreach (var promotion in list_promotions)
                {
                    Console.WriteLine(promotion);
                }
            }
        }
        public static void ViewAllCountries()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var list_countries = db.Query<Countries>("select * from Countries");
                foreach (var country in list_countries)
                {
                    Console.WriteLine(country);
                }
            }
        }
        public static void ViewAllCities()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var list_cities = db.Query<Cities>("select * from Cities");
                foreach (var city in list_cities)
                {
                    Console.WriteLine(city);
                }
            }
        }
        public static void ViewAllCustomersThisCity()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                Console.WriteLine("City: ");

                string? city;
                do
                {
                    city = Console.ReadLine();
                } while(string.IsNullOrEmpty(city));

                string Query = "select *\r\nfrom Customers Cus\r\nJoin Cities Cit on Cit.Id = Cus.CityId\r\nJoin Countries Cou on Cou.Id = Cit.CountryId\r\nwhere Cit.Name = @Name";
                var CityName = new { Name =  city };

                var customers = db.Query<Cities>(Query, CityName);

                foreach(var customer in customers)
                {
                    Console.WriteLine(customer);
                }
            }
        }
        public static void ViewAllCustomersThisCountry()
        {
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                Console.WriteLine("Country: ");

                string? country;
                do
                {
                    country = Console.ReadLine();
                } while (string.IsNullOrEmpty(country));


                string Query = "select *\r\nfrom Customers Cus\r\nJoin Cities Cit on Cit.Id = Cus.CityId\r\nJoin Countries Cou on Cou.Id = Cit.CountryId\r\nwhere Cou.Name = @Name";

                var CountryName = new { Name = country };

                var customers = db.Query<Customers>(Query, CountryName);

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer);
                }
            }
        }
        public static void ViewsAllPromotionsThisCountry()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                string query = "select *\r\nfrom Promotions P\r\nJoin Sections S on S.Id = P.SectionId\r\nJoin SectionCustomer SC on SC.SectionId = S.Id\r\nJoin Customers C on C.Id = SC.CustomerId\r\nJoin Cities Cit on  Cit.Id = C.CityId\r\nJoin Countries Cou on Cou.Id = Cit.CountryId\r\nwhere Cou.Name = @Name";
             
                string? country;
                do
                {
                    country = Console.ReadLine();
                } while (string.IsNullOrEmpty(country));

                var CountryName = new { Name = country };   

                var promotions = db.Query<Promotions>(query, CountryName);

                foreach(var item in promotions)
                {
                    Console.WriteLine(item);
                }

            }
        }
    }

    
}
