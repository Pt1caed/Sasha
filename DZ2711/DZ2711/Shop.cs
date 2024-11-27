using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2711
{
    internal class Shop : IDisposable
    {
        bool isOpen = false;
        public Shop(string? name, string? address, int type)
        {
            List<string> list = ["Продовольственный", "Хозяйственный", "Одежда", "Обувь"];

            TypeShop = list[type];
        }

        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? TypeShop { get; private set; }
        
        public void Open()
        {
            if(!isOpen)
            {
                Console.WriteLine("Магазин открыт!");
                isOpen = true;
            }
            else
            {
                Console.WriteLine("Магазин уже открыт.");
            }
        }



        public void Dispose()
        {
            Console.WriteLine($"Dispose Магазин закрыт {Name} \n");
            Console.WriteLine(this);
        }

        ~Shop()
        {
            Console.WriteLine($"Destructor Магазин закрыт... {Name} \n");
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Name: {Name} Address: {Address} TypeShop: {TypeShop}";
        }
    }
}
