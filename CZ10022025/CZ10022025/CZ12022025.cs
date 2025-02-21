using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Z.Dapper.Plus;

namespace CZ10022025
{
    internal class CZ12022025
    {

        public static Customers CreateCustomer()
        {
            string? surname;
            string? name;
            string? mail;
            int genderId = 0;
            do
            {
                Console.WriteLine("Surname: ");
                surname = Console.ReadLine();
                Console.WriteLine("Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Mail: ");
                mail = Console.ReadLine();
                Console.WriteLine("genderId: ");
                int.TryParse(Console.ReadLine(), out genderId);
            } while ( string.IsNullOrEmpty(surname) && string.IsNullOrEmpty(name) && string.IsNullOrEmpty(mail) && genderId == 0);

            return new() { Name = name, Surname = surname, Email = mail, GenderId = genderId };
        }
        public static Cities CreateCity()
        {
            string? name;
            int CountryId = 0;
            do
            {
                Console.WriteLine("Name: ");
                name = Console.ReadLine();
                Console.WriteLine("CountryId: ");
                int.TryParse(Console.ReadLine(), out CountryId);
            } while (string.IsNullOrEmpty(name) && CountryId == 0);

            return new() { Name = name, CountryId = CountryId };
        }

        public static Countries CreateCountry()
        {
            string? name;
            do
            {
                Console.WriteLine("Name: ");
                name = Console.ReadLine();;
            } while (string.IsNullOrEmpty(name));

            return new() { Name = name };
        }

        public static Sections CreateSection()
        {
            string? name;
            do
            {
                Console.WriteLine("Name: ");
                name = Console.ReadLine(); ;
            } while (string.IsNullOrEmpty(name));

            return new() { Name = name };

        }

        public static Promotions CreatePromotion()
        {
            string? name;
            int sectionId = 0;

            int year1;
            int month1;
            int day1;

            int year2;
            int month2;
            int day2;
            int[] massive;

            do
            {
                Console.WriteLine("Name: ");
                name = Console.ReadLine();

                Console.WriteLine("start year: ");
                int.TryParse(Console.ReadLine(), out year1);
                Console.WriteLine("start month: ");
                int.TryParse(Console.ReadLine(), out month1);
                Console.WriteLine("start day: ");
                int.TryParse(Console.ReadLine(), out day1);

                Console.WriteLine("end year: ");
                int.TryParse(Console.ReadLine(), out year2);
                Console.WriteLine("end month: ");
                int.TryParse(Console.ReadLine(), out month2);
                Console.WriteLine("end day: ");
                int.TryParse(Console.ReadLine(), out day2);

                Console.WriteLine("SectionId: ");
                int.TryParse(Console.ReadLine(), out sectionId);

                massive = [year1, year2, month1, month2, day1, day2, sectionId];

            } while (string.IsNullOrEmpty(name) && massive.Sum() <= 0);

            return new() { Name = name, StartTime = new(year1,month1,day1), EndTime = new(year2,month2,day2), SectionId = sectionId};

        }

        //////////////////////////// Добавление

        public static void AddNewCustomer()
        {
            using(IDbConnection db = new SqlConnection(Program.connectionString))
            {
                db.BulkInsert(CreateCustomer());
            }
        }

        public static void AddNewCountry()
        {
            using (IDbConnection db = new SqlConnection(Program.connectionString))
            {
                db.BulkInsert(CreateCountry());
            }
        }
        public static void AddNewCity()
        {
            using (IDbConnection db = new SqlConnection(Program.connectionString))
            {
                db.BulkInsert(CreateCity());
            }
        }
        public static void AddNewPromotion()
        {
            using (IDbConnection db = new SqlConnection(Program.connectionString))
            {
                db.BulkInsert(CreatePromotion());
            }
        }

        //////////////// Обновление

        public static void UpdateCustomers()
        {
            using (IDbConnection db = new SqlConnection(Program.connectionString))
            {
                var list = db.Query<Customers>("select * from Customers").ToList();
                int id;
                do
                {
                    Console.WriteLine("Id Customer: ");

                    int.TryParse(Console.ReadLine(), out id);

                } while (id <= 0 && id < list.Count() && id >= list.Count());

                list[id] = CreateCustomer();

                db.BulkUpdate(list);
            }
        }

        public static void UpdateCountries()
        {
            using (IDbConnection db = new SqlConnection(Program.connectionString))
            {
                var list = db.Query<Countries>("select * from Countries").ToList();
                int id;
                do
                {
                    Console.WriteLine("Id Country: ");

                    int.TryParse(Console.ReadLine(), out id);

                } while (id <= 0 && id-1 < list.Count() && id-1 > list.Count());

                list[id-1] = CreateCountry();

                db.BulkUpdate(list);
            }
        }
        public static void UpdateCities()
        {
            using (IDbConnection db = new SqlConnection(Program.connectionString))
            {
                var list = db.Query<Cities>("select * from Cities").ToList();
                int id;
                do
                {
                    Console.WriteLine("Id City: ");

                    int.TryParse(Console.ReadLine(), out id);

                } while (id <= 0 && id - 1 < list.Count() && id - 1 > list.Count());

                list[id - 1] = CreateCity();

                db.BulkUpdate(list);
            }
        }
        public static void UpdateSections()
        {
            using (IDbConnection db = new SqlConnection(Program.connectionString))
            {
                var list = db.Query<Sections>("select * from Sections").ToList();
                int id;
                do
                {
                    Console.WriteLine("Id Section: ");

                    int.TryParse(Console.ReadLine(), out id);

                } while (id <= 0 && id - 1 < list.Count() && id - 1 > list.Count());

                list[id - 1] = CreateSection();

                db.BulkUpdate(list);
            }
        }
        public static void UpdatePromotions()
        {
            using (IDbConnection db = new SqlConnection(Program.connectionString))
            {
                var list = db.Query<Promotions>("select * from Promotions").ToList();
                int id;
                do
                {
                    Console.WriteLine("Id promotion: ");

                    int.TryParse(Console.ReadLine(), out id);

                } while (id <= 0 && id - 1 < list.Count() && id - 1 > list.Count());

                list[id - 1] = CreatePromotion();

                db.BulkUpdate(list);
            }
        }


        //////// Удаление

        public static void DeleteCustomer()
        {
            using(IDbConnection db = new SqlConnection(Program.connectionString))
            {
                Console.WriteLine("Customer name: ");
                string? name = Console.ReadLine();

                Console.WriteLine("Customer surname: ");
                string? surname = Console.ReadLine();

                var list = db.Query<Customers>("select * from Customers");

                db.BulkDelete(list.Where(p => p.Name == name && p.Surname == surname));
            }
        }

        public static void DeleteCountry()
        {
            using (IDbConnection db = new SqlConnection(Program.connectionString))
            {
                Console.WriteLine("Country name: ");
                string? name = Console.ReadLine();

                var list = db.Query<Countries>("select * from Countries");

                db.BulkDelete(list.Where(p => p.Name == name));
            }
        }
        public static void DeleteCity()
        {
            using (IDbConnection db = new SqlConnection(Program.connectionString))
            {
                Console.WriteLine("City name: ");
                string? name = Console.ReadLine();

                var list = db.Query<Cities>("select * from Cities");

                db.BulkDelete(list.Where(p => p.Name == name));
            }
        }
        public static void DeleteSection()
        {
            using (IDbConnection db = new SqlConnection(Program.connectionString))
            {
                Console.WriteLine("Section name: ");
                string? name = Console.ReadLine();

                var list = db.Query<Sections>("select * from Sections");

                db.BulkDelete(list.Where(p => p.Name == name));
            }
        }
        public static void DeletePromotion()
        {
            using (IDbConnection db = new SqlConnection(Program.connectionString))
            {
                Console.WriteLine("Promotion name: ");
                string? name = Console.ReadLine();

                var list = db.Query<Promotions>("select * from Promotions");

                db.BulkDelete(list.Where(p => p.Name == name));
            }
        }

        ///// отображение
        
        public static void SelectCitiesThisCountry()
        {
            using (IDbConnection db = new SqlConnection(Program.connectionString))
            {
                Console.WriteLine("Country name: ");

                string? name = Console.ReadLine();
                string query = "select * from Cities C where C.Name = @Name";

                var list = db.Query<Cities>(query, new { Name = name });

                foreach(var item in list)
                {
                    Console.WriteLine($"Id: {item.Id} | Name: {item.Name} | CountryId: {item.CountryId}");
                }
            }

        }
        public static void SelectSectionsThisCustomer()
        {
            using (IDbConnection db = new SqlConnection(Program.connectionString))
            {
                Console.WriteLine("Section name: ");

                string? name = Console.ReadLine();
                string query = "select * from Sections S Join SectionCustomer SC on SC.SectionId = S.Id Join Customers C on C.Id = SC.CustomerId where C.Name = @Name";

                var list = db.Query<Sections>(query, new { Name = name });

                foreach (var item in list)
                {
                    Console.WriteLine($"Id: {item.Id} | Name: {item.Name}");
                }
            }
        }
        public static void SelectPromotionsThisSection()
        {
            using (IDbConnection db = new SqlConnection(Program.connectionString))
            {
                Console.WriteLine("Section name: ");

                string? name = Console.ReadLine();
                string query = "select * from Promotions P Join Sections S on P.SectionId = S.Id where S.Name = @Name";

                var list = db.Query<Promotions>(query, new { Name = name });

                foreach (var item in list)
                {
                    Console.WriteLine($"Id: {item.Id} | Name: {item.Name} | StartTime: {item.StartTime} | EndTime: {item.EndTime} | SectionId: {item.SectionId}");
                }
            }

        }
    }

}
