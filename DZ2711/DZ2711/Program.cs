namespace DZ2711
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shop> shops = []; 

            Piecse obj = new("...", "Good", "Realy", 1022, 11, 15);
            Shop shop = new("Gucci", "Arhit 19, 2", 1);

            for (int i = 0; i < 10; i++)
            {
                using(Piecse obj1 = obj)
                {
                    Console.WriteLine(i);
                }
            }

            Shop shop1 = new("Rrr", "1", 2);

            GC.Collect(0, GCCollectionMode.Forced);


            for (int i = 0;i < 10000;i++)
            {
                Shop shop2 = shop1;
            }
            Console.Read();

        }
    }

}
