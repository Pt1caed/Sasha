namespace DZ2810
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <string> strings = new List <string> ();
            strings.Add("Fafa");
            strings.Add("Rara");
            strings.Add("Kuku");
            strings.Add("Cucu");

            City city1 = new City("Odessa", "Ukraine", "12323", 400000, strings);
            City city2 = new City("Kiev", "Ukraine", "12423", 501234);

            Console.WriteLine(city1);
            Console.WriteLine(city1 == city2);
            Console.WriteLine(city2 > city1);
            city1.PrintDistricts();
            city2.PrintDistricts();
            Console.WriteLine(city1[1]);

            Employee employee1 = new Employee("Gabe", "Newal", 2000, 12, 11, "Admin", "Good admin", 12000, "+380123333455", "+380125667889", "gaga@gmail.com");
            Employee employee2 = new Employee("Nadya", "Libran", 2002, 5, 6, "booker", "Hello!", 5000, "+380345677789", "+3809876544432", "booker@i.ua");
            Console.WriteLine(employee1);
            Console.WriteLine(employee2 == employee1);
            Console.WriteLine(employee1 > employee2);
            Console.WriteLine(employee1.Equals(employee2));

            Console.WriteLine(employee1.Salary);
            employee1 += 1000;
            Console.WriteLine(employee1.Salary);
           
        }
    }
}
