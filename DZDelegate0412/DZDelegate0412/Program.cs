namespace DZDelegate0412
{
    internal class Program
    {
        public delegate bool ArithmeticDelegate(int num);

        static void Main(string[] args)
        {
            #region 1 задание
            //List<ArithmeticDelegate> list_methods = [Even, Odd, Simple, Fibbonacci];
            //List<int> list = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            //for (int i = 0; i < list_methods.Count; i++)
            //{
            //    Console.WriteLine($"{i} {list_methods[i].Method.Name}");
            //}

            //int choice = Convert.ToInt32(Console.ReadLine());
            //Sort(list, list_methods[choice]);
            #endregion

            #region 2 задание

            List<Action> list_methods1 = [TimeNow, DateNow, DayNow, AreaTriangle, AreaRectangle];
            for (int i = 0; i < list_methods1.Count; i++)
            {
                Console.WriteLine($"{i} {list_methods1[i].Method.Name}");
            }

            int choice = Convert.ToInt32(Console.ReadLine());

            list_methods1[choice].Invoke();

            #endregion
        }

        #region 1 задание

        public static void Sort(List<int> list, ArithmeticDelegate sort_method)
        {
            for (int i = 0;i < list.Count;i++)
            {
                if(sort_method(list[i]) == false)
                {
                    list.RemoveAt(i);
                }

            }
        }

        public static bool Odd(int num) => num % 2 != 0;
        public static bool Even(int num) => num % 2 == 0;
        public static bool Simple(int num)
        {
            if(num < 2)
            {
                return false;
            }
            for (int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool Fibbonacci(int num)
        {
            int a = 0;
            int b = 1;

            while (a < num)
            {
                int temp = a;
                a = b;
                b = temp + b;

                if (a == num)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region 2 задание

        public static void TimeNow() =>
            Console.WriteLine($"Время сейчас: {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}");
        public static void DateNow() => Console.WriteLine($"Дата сейчас: {DateTime.Now.Date}");
        public static void DayNow() => Console.WriteLine($"Дата сейчас: {DateTime.Now.DayOfWeek}");
        public static void AreaTriangle()
        {
            Console.WriteLine("Сторона: ");

            double a = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Площадь: ", a * h * 0.5);
        }

        public static void AreaRectangle()
        {
            Console.WriteLine("Первая сторона: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Вторая сторона: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Площадь: ", a * b);
        }

        #endregion



    }
}
