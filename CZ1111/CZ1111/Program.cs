using System.Text;

namespace CZ1111
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //    FifthDecimal a = new FifthDecimal(1000);
            //    a.SixteenSystem();
            //    a.OctalSystem();
            //    a.SecondSystem();

            //    Console.WriteLine(a);
            //    a += 10;
            //    Console.WriteLine(a);

            RGBColor a = new(102, 55, 72);

            a.ToSMYK();
            a.ToHEX();
            a.ToHSL();

            Fraction fr1 = new(1, 2);
            Fraction fr2 = new(1, 2);
            Fraction fr3 = fr1 + fr2;
            fr3 = fr1 * fr2;

            Console.WriteLine(fr3);
            Console.WriteLine(fr3);
        }
    }
}
