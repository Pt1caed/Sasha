namespace CZ0412
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 задание
            Firma firma1 = new("Google", "Marketing", new(2014, 4, 30), "Grigoriy", 123, "London");
            Firma firma2 = new("Amazon", "Marketing", new(2025, 1, 13), "Alex", 2000, "Odessa");
            Firma firma3 = new("Adidas", "IT", new(2000, 3, 25), "Roma", 3154, "Mariupol");
            Firma firma4 = new("GUCCI", "Games", new(2003, 5, 11), "Vova", 2324, "New-York");

            List<Firma> list = [firma1, firma2, firma3, firma4];


            Console.WriteLine("Инфа: ");


            var Info = list.Select(x => x.ToString()).ToList();

            foreach (var val in Info)
            { Console.WriteLine(val); }


            Console.WriteLine("Где Food в имени: ");

            var FoodInfo = list.Where(x => x.NameFirma.Contains("Food"));

            foreach (var val in FoodInfo)
            { Console.WriteLine(val); }

            Console.WriteLine("Marketing: ");

            var MarketingInfo = from i in list
                                where i?.ProfileBussines?.ToLower() == "marketing"
                                select i;

            Console.WriteLine("Marketing and IT: ");

            foreach (var val in MarketingInfo)
            { Console.WriteLine(val); }

            var MarketingItInfo = from i in list
                                  where i?.ProfileBussines?.ToLower() == "marketing" || i?.ProfileBussines?.ToLower() == "IT"
                                  select i;


            Console.WriteLine(">100 employees: ");

            var EmployeesInfo = from i in list
                                where i?.CountEmployees > 100
                                select i;

            foreach (var val in EmployeesInfo)
            { Console.WriteLine(val); }

            Console.WriteLine(">100 && <400 employees: ");

            var EmployeesDiaposoneInfo = from i in list
                                where i?.CountEmployees > 100 && i?.CountEmployees < 300
                                select i;

            foreach (var val in EmployeesInfo)
            { Console.WriteLine(val); }

            Console.WriteLine("London city: ");

            var CityInfo = from i in list
                           where i?.WhatCity == "London"
                           select i;

            foreach (var val in CityInfo)
            { Console.WriteLine(val); }

            Console.WriteLine("Name White:");

            var NameInfo = from i in list
                           where i?.NameDirector == "White"
                           select i;

            foreach (var val in NameInfo)
            { Console.WriteLine(val); }

            Console.WriteLine(">=2 years ago: ");

            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var DateSoonInfo = list.Where(t => (epoch - DateTime.Now).TotalSeconds - (epoch - t.Date.ToDateTime(TimeOnly.MinValue)).TotalSeconds >= 63072000).ToList();
            
            foreach(var val in DateSoonInfo)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine(">=123 days from the create");


            DateTime epoch1 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var DateSoonInfo1 = list.Where(t => (epoch - DateTime.Now).TotalSeconds - (epoch - t.Date.ToDateTime(TimeOnly.MinValue)).TotalSeconds == 10627200).ToList();
            foreach (var val in DateSoonInfo1)
            {
                Console.WriteLine(val);
            }
            #endregion
            #region 3 задание

            Firma firma01 = new("Google", "Good", new(2000, 12, 5), "President", 3000, "Arhitect 11");
            Firma firma02= new("Zoo", "", new(2000, 12, 5), "President", 3000, "Arhitect 11");

            firma01.Employees.Add(new("Richard", "Suilan", 21, "Admin", "+380684321280", "Richard@gmail.com", 10000));
            firma01.Employees.Add(new("Roma", "Rubcov", 33, "Buhgalter", "+230123467893", "Rom111@ukr.net", 3000));

            firma02.Employees.Add(new("Zigmut", "Freid", 43, "Frilancer", "+380347837423", "Fried@i.ua", 13000));
            firma02.Employees.Add(new("Sara", "Nair", 18, "Admin_two", "+230741237584", "Sara123@gmail.com", 1000));

            List<Firma> list_firms = [firma01, firma02];

            // 1

            Console.WriteLine("Get all employees from firma01: ");

            var list_all_employees = list_firms[0].Employees.Select(i => i).ToList();
            list_all_employees.ForEach(i => Console.WriteLine(i));

            // 2

            Console.WriteLine("Write salary: ");
            int salary = int.Parse(Console.ReadLine());

            var list_employees_salary = list_firms[1].Employees.Select(i => i.Salary > salary).ToList();
            list_employees_salary.ForEach(i => Console.WriteLine(i));

            // 3

            Console.WriteLine("Get all employees firms admin: ");

            var list_employees_admin = list_firms.SelectMany(i => i.Employees).Where(employee => employee.JobTitle == "Admin").ToList();
            list_employees_admin.ForEach(i => Console.WriteLine(i));

            // 4

            Console.WriteLine("phone starts with +23");

            var list_employees_phone = list_firms.SelectMany(i => i.Employees).Where(employee => employee.ContactTelephone?[..2] == "+23").ToList();
            list_employees_phone.ForEach(i => Console.WriteLine(i));
            #endregion
        }
    }
}
