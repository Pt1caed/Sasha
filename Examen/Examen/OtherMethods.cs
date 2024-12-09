using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal static class OtherMethods
    {
        public static int GetValidatedIndex(int minValue, int maxValue)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int tryChoice) && tryChoice >= minValue && tryChoice < maxValue)
                {
                    return tryChoice;
                }
                Console.WriteLine("Вы ввели несуществующий индекс!");
                Console.ReadKey();
                return -1;
            }
        }
    }
}
