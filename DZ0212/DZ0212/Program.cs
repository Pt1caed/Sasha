using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

namespace DZ0212
{
    internal class Program
    {
        static string path = Directory.GetCurrentDirectory();
        static void Main(string[] args)
        {


            #region 1 задание
            //List<int> list = [];

            //for (int i = 0; i < 100; i++)
            //{
            //    list.Add(i);
            //}

            //try
            //{
            //    using FileStream fibbo = new(Path.Combine(path, "fibbo.txt"), FileMode.Create, FileAccess.Write);
            //    using FileStream simple = new(Path.Combine(path, "simple.txt"), FileMode.Create, FileAccess.Write);


            //    using StreamWriter file_fibbonachi = new(fibbo);
            //    using StreamWriter file_simple = new(simple);


            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        if (IsSimple(i) == true)
            //        {
            //            file_simple.WriteLine(i);
            //        }
            //        if (Fibbonacci(i) == true)
            //        {
            //            file_fibbonachi.WriteLine(i);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            #endregion

            #region 2 задание

            //string? input;
            //string? replace;
            //string path1 = Path.Combine(path, "replace.txt");
            //File.WriteAllText(path1, "Hello, my name is Sasha");

            //Console.WriteLine("Поиск: ");
            //replace = Console.ReadLine();

            //Console.WriteLine("Замена: ");
            //input = Console.ReadLine();

            //string replace_txt = File.ReadAllText(path1);
            //Console.WriteLine(replace_txt);

            //replace_txt = replace_txt.Replace(replace, input);
            //File.WriteAllText(path1, replace_txt);



            #endregion

            #region 3 задание

            //string path_to_file = Path.Combine(path, "Moderate.txt");
            //File.WriteAllText(path_to_file, "Lorem ipsum dolor sit amet, consectetur adipiscing " +
            //    "elit, sed do eiusmod tempor incididunt ut labore et dolore " +
            //    "magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation " +
            //    "ullamco laboris nisi ut aliquip ex ea commodo consequat.");

            //List<string> moder_words = [];

            //Console.WriteLine("Введите слова для модерирования: ");
            //while (moder_words.Count < 5)
            //{
            //    string? moder_word = Console.ReadLine();
            //    if (moder_word != null)
            //        moder_words.Add(moder_word);
            //}

            //string read_txt = File.ReadAllText(path_to_file);

            //foreach (string replace_word in moder_words)
            //{
            //    read_txt = read_txt.Replace(replace_word, String.Concat(Enumerable.Repeat("*", replace_word.Length)));
            //}
            //File.WriteAllText(path_to_file, read_txt);

            #endregion

            #region 4 задание

            //Console.WriteLine("Введите название файла(с припиской txt): ");
            //string? name_txt = Console.ReadLine();

            //string path_text = "";
            //if (name_txt != null)
            //{
            //    path_text = Path.Combine(path, name_txt);
            //}

            //Console.WriteLine("Запишите что-нибудь: ");

            //string? text = Console.ReadLine();
            //var text1 = text.ToCharArray();
            //Array.Reverse(text1);

            //text = new string(text1);

            //File.WriteAllText(path_text, text);
            #endregion

            #region 5 задание


            string path_to_nums = Path.Combine(path, "random_nums.txt");

            using (StreamWriter sw = new(path_to_nums))
            {
                int count = 0;
                while (count < 1000)
                {
                    count++;
                    sw.WriteLine(new Random().Next(-100000, 100000));
                }
            }

            using(StreamReader sr = new(path_to_nums))
            {
                string text = sr.ReadToEnd(); 
                var text1 = text.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(text1.Max());
                Console.WriteLine(text1.Length);
                int positive = text1.Where(t => int.Parse(t) > 0).Count();
                Console.WriteLine(positive);
                int negative = text1.Where(t => int.Parse(t) < 0).Count();
                int double_nums = text1.Where(t => Convert.ToInt32(t) >= 10 && Convert.ToInt32(t) <= 99).Count();
                int fifty_nums = text1.Where(t => Convert.ToInt32(t) >= 10000 && Convert.ToInt32(t) <= 99999).Count();

                Console.WriteLine("positive: " + positive);
                Console.WriteLine("negative: " + negative);
                Console.WriteLine("double nums: " + double_nums);
                Console.WriteLine("fifty nums: " + fifty_nums);
            }

            #endregion
        }

        #region 1 задание
        static bool IsSimple(int num)
        {
            if(num < 2)
            {
                return false;
            }
            bool error = true;
            for (int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    error = false;
                    break;
                }
            }
            if(error)
            {
                return true;
            }
            return false;
        }
        static bool Fibbonacci(int num)
        {
            int a = 0;
            int b = 1;

            while(a < num)
            {
                int temp = a;
                a = b;
                b = temp + b;

                if(a == num)
                {
                    return true;
                }
            }
            return false;
        }
    #endregion


    }
}
