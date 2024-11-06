namespace DZ411_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] massive = new int[5];
            Array array = new(massive);

            array.RandomMassive();
            Console.WriteLine(array);

            Console.WriteLine(array.Less(5));
            Console.WriteLine(array.Greater(5));
            array.ShowEven();
            array.ShowOdd();

            Console.WriteLine(array.CountDistinct());
            Console.WriteLine(array.EqualToValue(5));

        }
    }
}
