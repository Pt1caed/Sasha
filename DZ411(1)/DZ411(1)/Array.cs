using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DZ411_1_
{
    internal class Array : IOutput, IOutput2, ICalc, ICalc2
    {
        private int[] massive;



        public Array(int[] massive)
        {
            this.massive = massive;
        }

        public Array()
        {
            this.massive = [];
        }

        public int this[int index]
        {
            get { return massive[index]; }
            set { massive[index] = value; }
        }

        public int Length
        { get { return massive.Length; } }

        #region Методы
        public void Add(int element)
        {
            int[] massive1 = new int[Length + 1];

            for (int i = 0; i < Length; i++)
            {
                massive1[i] = massive[i];
            }

            massive1[massive.Length] = element;

            massive = massive1;
        }

        public void Remove(int index)
        {
            int[] massive1 = new int[Length - 1];

            int counter = 0;
            for (int i = 0; i < Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                massive1[counter] = massive[i];
                counter++;
            }
            massive = massive1;
        }

        public void RandomMassive()
        {
            for (int i = 0; i < Length; i++)
            {
                massive[i] = new Random().Next(-5, 20);             
            }
        }
        #endregion

        #region IOutput
        public void Show()
        {
            ToString();
            Console.WriteLine();
        }

        public void Show(string message)
        {
            Show();
            Console.WriteLine(message + '\n');
        }
        #endregion

        #region ICalc
        public int Less(int valueToCompare)
        {
            int count = 0;

            foreach (int i in massive)
            {
                if (i < valueToCompare)
                { count++; }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;

            foreach (int i in massive)
            {
                if (i > valueToCompare)
                { count++; }
            }
            return count;
        }
        #endregion

        #region перевизначені методи object

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            string[] strings = new string[Length];
            for (int i = 0; i < massive.Length; i++)
            {
                strings[i] = massive[i].ToString() + " ";
            }
            return string.Join("", strings);
        }

        public override bool Equals(object? obj)
        {
            return this.ToString() == obj?.ToString();
        }
        #endregion

        #region IOuput2
        public void ShowOdd()
        {
            foreach (int i in massive)
            {
                if(i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        public void ShowEven()
        {
            foreach (int i in massive)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
        #endregion

        #region ICalc2
        public int CountDistinct()
        {
            int count = 0;
            for(int i = 0; i < Length; i++)
            {
                bool isDistinct = true;

                for (int j = 0; j < Length; j++)
                {
                    if (massive[i] == massive[j] && i != j)
                    {
                        isDistinct = false;
                        break;
                    }
                }
                if(isDistinct)
                {
                    count++;
                }
            }
            return count;
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            foreach(int i in massive)
            {
                if(valueToCompare == i)
                {
                    count++;
                }
            }
            return count;
        }
        #endregion
    }
}
