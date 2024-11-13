using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CZ1111
{
    struct Fraction
    {
        public Fraction(int numerator, int denominator) { Denominator = denominator; Numerator = numerator; }

        public int Denominator { get; set; }
        public int Numerator { get; set; }

        public void Reduction()
        {
            int a = Numerator;
            int b = Denominator;
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }
            Fraction fraction1 = new(Denominator / a, Numerator / a);
            this.Denominator = fraction1.Denominator;
            this.Numerator = fraction1.Numerator;
        }


        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction c = new(a.Denominator * b.Denominator, a.Numerator * b.Denominator + b.Numerator * a.Denominator);
            return c;
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {

            if (a.Denominator == b.Denominator)
            {
                Fraction c = new(a.Denominator, a.Numerator - b.Numerator);
                return c;
            }
            else
            {
                Fraction c = new(a.Denominator * b.Denominator, a.Numerator * b.Denominator - b.Numerator * a.Denominator);
                return c;
            }
        }
        public static Fraction operator*(Fraction a, Fraction b)
        {
            Fraction c = new(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
            return c;
        }
        public static Fraction operator/(Fraction a, Fraction b)
        {
            Fraction c = new(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
            return c;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

    }
}
