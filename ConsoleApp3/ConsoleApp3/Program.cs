namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] massive = ["fafa", "gugu", "bibi"];
            City city = new City("Fafa", "USA", 1000, 123, massive);
            Employee employee = new Employee("Rubcov", "Alex", 1920, 10, 2, "+380123455567", "+380234566678", "fafa@i.ua", "Producer", "Hey hey");
            Plane plane = new Plane("Boing 636", "Boing", 2017, 11, 1, "Big");

            city.Info();
            employee.Info();
            plane.Info();

            plane.Info("Hello");
        }
    }
}
