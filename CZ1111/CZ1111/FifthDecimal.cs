using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CZ1111
{
    struct FifthDecimal
    {
        public FifthDecimal(int value)
        {
            Num = value;
        }
        public int Num { get; set; }

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
        public readonly void SixteenSystem()
        {
            char[] massive = ['A', 'B', 'C', 'D', 'E', 'F'];
            int num = Num;
            List<char> tobin = [];
            char char_symbol;
            while (num != 0)
            {
                int final_number = num % 16;
                if (final_number % 16 > 9)
                {
                    tobin.Add(massive[final_number - 10]);
                }
                else
                {
                    char_symbol = char.Parse(Convert.ToString(final_number));
                    tobin.Add(char_symbol);
                }
                num /= 16;
            }

            tobin.Reverse();

            string tobin1 = string.Concat<char>(tobin);
            Console.WriteLine(tobin1);

        }
        public readonly void SecondSystem() => ConvertUnit(Num, 2);
        public readonly void OctalSystem() => ConvertUnit(Num, 8);


        public static FifthDecimal operator +(FifthDecimal a, FifthDecimal b) => new(a.Num + b.Num);
        public static FifthDecimal operator +(FifthDecimal a, int num) => new(a.Num + num);
        public static FifthDecimal operator -(FifthDecimal a, FifthDecimal b) => new(a.Num - b.Num);
        public static FifthDecimal operator -(FifthDecimal a, int num) => new(a.Num - num);
        public static FifthDecimal operator *(FifthDecimal a, FifthDecimal b) => new(a.Num * b.Num);
        public static FifthDecimal operator *(FifthDecimal a, int num) => new(a.Num * num);
        public static FifthDecimal operator /(FifthDecimal a, FifthDecimal b) => new(a.Num / b.Num);
        public static FifthDecimal operator /(FifthDecimal a, int num) => new(a.Num / num);
        public static FifthDecimal operator %(FifthDecimal a, FifthDecimal b) => new(a.Num % b.Num);
        public static FifthDecimal operator %(FifthDecimal a, int num) => new(a.Num % num);
        public static bool operator ==(FifthDecimal left, FifthDecimal right) => left.Equals(right);
        public static bool operator !=(FifthDecimal left, FifthDecimal right) => !left.Equals(right);
        public static bool operator <(FifthDecimal left, FifthDecimal right) => left.Num < right.Num;
        public static bool operator >(FifthDecimal left, FifthDecimal right) => left.Num > right.Num;

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => this.ToString() == obj?.ToString();
        public override readonly string ToString() => $"Num: {Num}";
        public override readonly int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
