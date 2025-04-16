using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class CurrencyRate
    {
        public static Dictionary<string, double> Valutes = new()
        {
            { "UAH", 1 },
            { "USD", 41.41 },
            { "EUR", 46.93 }
        };

        public static double ExchangeValute(string from, string to, int count)
        {
            var from_valute = Valutes[from];
            var to_valute = Valutes[to];
            return count * from_valute / to_valute;
        }
    }
}
