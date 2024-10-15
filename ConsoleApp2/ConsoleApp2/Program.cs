using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection.Metadata;
using System.Security.Principal;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Massives(); 2 задание
        //TwoMassives(); 1 задание
        }

        // Вспомогательные методы для заданий
        private static void InitialiseMassive(int[,] massive) // Инициалиазация двухмерного массива
        {
            Random a = new Random();
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    massive[i, j] = a.Next(1, 10);
                }
            }
        }

        private static void InitialiseMassive(int[] massive) // Инициалиазация массива
        {
            for (int i = 0; i < massive.Length; i++)
            {
                Console.Write("Write elem: ");
                string? str = Console.ReadLine();
                Console.WriteLine();
                massive[i] = Convert.ToInt32(str);
            }
        }

        static void PrintMassive(int[] massive)
        {
            foreach (int i in massive)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine('\n');
        }


        static void PrintMassive(int[,] massive)
        {
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    Console.Write(massive[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // Задание 2

        static void Massives()
        {
            int summa = 0;
            int[,] massive = new int[5, 5];
            Random random = new Random();
            InitialiseMassive(massive);

            PrintMassive(massive);


            IEnumerable<int> massive1 = massive.Cast<int>();

            int min = massive[0, 0];
            int max = massive[0, 0];

            int index_min_massives = 0;
            int index_min_massive = 0;
            int index_max_massives = 0;
            int index_max_massive = 0;


            for (int i = 0; i < massive.GetLength(0); i++)
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    if (massive[i, j] < min)
                    {
                        min = massive[i, j];

                        index_min_massives = i;
                        index_min_massive = j;
                    }
                    if (massive[i, j] > max)
                    {
                        max = massive[i, j];
                        index_max_massives = i;
                        index_max_massive = j;
                    }
                }
            }
            Console.WriteLine($"min: {index_min_massives} {index_min_massive}  max: {index_max_massives} {index_max_massive}");
            if (index_max_massives < index_min_massives || index_max_massives == index_min_massives && index_max_massive < index_min_massive)
            {

                int temp = index_min_massives;
                index_min_massives = index_max_massives;
                index_max_massives = temp;

                temp = index_min_massive;
                index_min_massive = index_max_massive;
                index_max_massive = temp;
            }
            if (index_min_massives == index_max_massives)
            {
                for (int k = index_min_massive; k <= index_max_massive; k++)
                {
                    Console.WriteLine($"{summa} + {massive[index_min_massives, k]}");
                    summa += massive[index_min_massives, k];
                }

                Console.WriteLine("summa: " + summa);
                return;
            }
            for (int i = index_min_massives; i <= index_max_massives; i++)
            {

                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    if (i == index_min_massives && j < index_min_massive)
                    {
                        continue;
                    }
                    else if (i == index_max_massives && j > index_max_massive )
                    {
                        continue;
                    }
                    Console.WriteLine($"{summa} + {massive[i, j]}");
                    summa += massive[i, j];

                }
            }

            Console.WriteLine("summa: " + summa);

        }
        
        // Вспомогательные методы для задания 1

        private static int MultiplicationMassive(int[] massive) // Умножение массива 1
        {
            int mult = 1;
            foreach(int i in massive)
            {
                mult *= i;
            }
            return mult;
        }

        private static int MultiplicationMassive(int[,] massive) // Умножение массива 2
        {
            int mult = 1;
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    mult *= massive[i, j];
                }
            }
            return mult;
        }

        private static int SummaPairsMassive(int[] massive) // Сумма парных элементов массива 1
        {
            int sum = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                if(i % 2 == 0)
                {
                    sum += massive[i];
                }
            }
            return sum;
        }

        private static int SummaNoPairsMassive(int[,] massive) // Сумма не парных элементов массива 2
        {
            int sum = 0;
            for(int i = 0;i < massive.GetLength(0);i++)
            {
                for( int j = 0;j < massive.GetLength(1);j++)
                {
                    if (j % 2 == 1)
                    {
                        sum += massive[i, j];
                    }
                }
            }
            return sum;
        }

        // Задание 1

        static void TwoMassives()
        {
            int[] first_massive = new int[5];
            int[,] second_massive = new int[3, 4];

            InitialiseMassive(first_massive);
            InitialiseMassive(second_massive);

            PrintMassive(first_massive);
            PrintMassive(second_massive);

            IEnumerable<int> second_massive1 = second_massive.Cast<int>();
            Console.Write($"Min elem first massive: {first_massive.Min()} and min elem second massive: {second_massive1.Min()} -> ");
            if (first_massive.Min() != second_massive1.Min())
            {
                Console.Write(" not equal.");
            }
            else
            {
                Console.Write(" equal.");
            }

            Console.WriteLine();

            Console.Write($"Max elem first massive: {first_massive.Max()} and max elem second massive: {second_massive1.Max()} -> ");
            if (first_massive.Max() != second_massive1.Max())
            {
                Console.WriteLine(" not equal.");
            }
            else
            {
                Console.WriteLine(" equal.");
            }
            Console.Write("Summa first massive: "); Console.WriteLine(first_massive.Sum());
            Console.Write("Summa second massive: "); Console.WriteLine(second_massive1.Sum());

            Console.Write("Multiple first massive: "); Console.WriteLine(MultiplicationMassive(first_massive));
            Console.Write("Multiple second massive: "); Console.WriteLine(MultiplicationMassive(second_massive));

            Console.Write("Summa pairs elements first massive: "); Console.WriteLine(SummaPairsMassive(first_massive));
            Console.Write("Summa no pairs elements second massive: "); Console.WriteLine(SummaNoPairsMassive(second_massive));

        }
    }



}
