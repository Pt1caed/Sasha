using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiaposoneNum(9);
            Percent(13, 101);
            Concatenation(1, 2, 3, 4);
            EditNum(123456, 1, 2);
            Date(2015, 9, 9);
            Celsius(105);
            Fahrenheit(36.6);
            NumbersDiaposone(1, 5);
        }


        static void DiaposoneNum(int x) // 1
        {
            if(x > 0 && x <= 100) 
            {
                if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz" + "\n");
                }
                else if (x % 3 == 0)
                {
                    Console.WriteLine("Fizz" + "\n");
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine("Buzz" + "\n");
                }
                else
                {
                    Console.WriteLine(x + "\n");
                }
            }
            else { Console.WriteLine("Error.\n"); }
        }
        static void Percent(double percent, double num) // 2
        {
            Console.WriteLine( (num / 100) * percent + "\n");
        }
        static void Concatenation(int num1, int num2, int num3, int num4) // 3
        {
            string string_num = num1.ToString() + num2.ToString() + num3.ToString() + num4.ToString();

            int num5 = Convert.ToInt32(string_num);

            Console.WriteLine(num5 + "\n");
        }
        static void EditNum(int num, int index_1, int index_2) // 4
        {

            string string_num = Convert.ToString(num);


            if(string_num.Length == 6)
            {
                var temp = string_num[index_1];
                string_num = string_num.Remove(index_1, 1).Insert(index_1, string_num[index_2].ToString());
                string_num = string_num.Remove(index_2, 1).Insert(index_2, temp.ToString().ToString());
                num = Convert.ToInt32(string_num);
                Console.WriteLine(num + "\n");
            }
            else
            {
                Console.WriteLine("Error");
            }

        }

        static void Date(int year, int month, int day)
        {

            
            DateTime date = new DateTime(year, month, day);

            string string_month;
            if (month >= 3 && month <= 5)
            {
                string_month = "Spring";
            }
            else if(month >= 6 && month <= 8)
            {
                string_month = "Summer";
            }
            else if (month >= 9 && month <= 11)
            {
                string_month = "Autumn";
            }
            else
            {
                string_month = "Winter";
            }

            Console.WriteLine($"{date.DayOfWeek} {string_month} \n");
        }

        static void Celsius(double fahrenheit) // 6
        {
            Console.WriteLine(Math.Round((fahrenheit - 32) * 5 / 9, 1) + "\n");
        }
        static void Fahrenheit(double celsius) // 6
        {
            Console.WriteLine(Math.Round((celsius * 5 / 9) + 32, 1) + "\n");
        }

        static void NumbersDiaposone(int start, int end) // 7 
        {
            if(start > end) 
            {
                int start_1;
                start_1 = start;
                start = end;
                end = start_1;
            }
            for (int i = 0; i < end; i++) 
            {
                Console.WriteLine(i + "  ");
            }
            Console.WriteLine("\n");
        }
    }
}
