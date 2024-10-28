using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class CalculatorSystems
    {
        static private string ConvertUnit(int num, int convert_num)
        {

            List<char> tobin = new List<char>();
            char char_symbol;
            while (num != 0)
            {
                char_symbol = char.Parse(Convert.ToString(num % convert_num));

                tobin.Add(char_symbol);
                num /= convert_num;
            }

            tobin.Reverse();

            string tobin1 = string.Concat<char>(tobin);
            Console.WriteLine(tobin1);
            return tobin1;
        }

        static public void Play(int num)
        {
            Console.WriteLine("Choose.");

            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine($"{i - 1}. To {i}");
            }

            int choose = Convert.ToInt32(Console.ReadKey().Key) - 48;
            Console.WriteLine();
            try
            {
                if (choose >= 1 && choose <= 8)
                {
                    ConvertUnit(num, choose + 1);
                }
                else
                {
                    throw new Exception("No this choose");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
