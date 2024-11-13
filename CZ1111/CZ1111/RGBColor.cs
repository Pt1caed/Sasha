using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ1111
{
    struct RGBColor
    {
        public RGBColor(int R, int G, int B) { red = R; green = G; blue = B; }

        private int red;
        private int green;
        private int blue;

        public readonly void ToSMYK()
        {

            double R = (double)red / 255;
            double G = (double)green / 255;
            double B = (double)blue / 255;

            double[] rgb = [R, G, B];
            double[] cmyk = new double[4];

            double K = Math.Round(rgb.Max(), 2);
            for (int i = 0; i < rgb.Length; i++)
            {
                double color_cmyk = (1 - rgb[i] - K) / (1 - K);
                cmyk[i] = Math.Round(color_cmyk, 2);
            }
            cmyk[3] = K;



            Console.Write("CMYK( ");
            foreach (double item in cmyk)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(")");
        }

        public void ToHEX()
        {
            int[] massive = [Red, Green, Blue];

            string hex = "#";

            foreach (int i in massive)
            {
                hex += Convert.ToString(i, 16).ToUpper();
            }
            Console.WriteLine(hex);
        }

        public void ToHSL()
        {
            double R = (double)red / 255;
            double G = (double)green / 255;
            double B = (double)blue / 255;

            double[] massive = [R, G, B];

            double max = massive.Max();
            double min = massive.Min();

            double lightness = (max + min) / 2;

            double saturation = (max - min) / (1 - Math.Abs(2 * lightness - 1));
            double hue;

            if(max == R)
            {
                hue = 60 * ((G - B) / (max - min));
            }
            else if(max == G)
            {
                hue = 60 * (2 + (B - R) / (max - min));
            }
            else
            {
                hue = 60 * (4 + (R - G) / (max - min));
            }

            if(hue < 0)
            {
                hue += 360;
            }

            Math.Round(hue, 2);
            Math.Round(saturation, 2);
            Math.Round(lightness, 2);

            Console.WriteLine($"HSL({Math.Round(hue,2)} {Math.Round(saturation,2)} {Math.Round(lightness,2)})");
        }
        

        public int Red
        {
            get => red;
            set
            {
                if (value < 0 || value > 255)
                    throw new ArgumentOutOfRangeException("value");
                else
                    red = value;
            }
        }
        public int Green
        {
            get => green;
            set
            {
                if (value < 0 || value > 255)
                    throw new ArgumentOutOfRangeException("value");
                else
                    green = value;
            }
        }
        public int Blue
        {
            get => blue;
            set
            {
                if (value < 0 || value > 255)
                    throw new ArgumentOutOfRangeException("value");
                else
                    blue = value;
            }
        }
    }
}
