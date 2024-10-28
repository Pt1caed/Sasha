using System;

namespace ConsoleApp8
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //int num = 120;
            //CalculatorSystems.Play(num);

            ForeignPassport obj = new ForeignPassport("Fasap", "Fapasovk", 123456, "Ekaterinenskaya 86", 1920, 12, 12, 1925, 12, 12);
            Console.WriteLine(obj.ToString());
        }
    }
}
