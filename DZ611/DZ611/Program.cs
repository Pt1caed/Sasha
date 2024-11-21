namespace DZ611
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book a = new(10, "Gudvin", "Roman...", "Good book", 250);
            Book b = new(30, "Zaza", "Вы любите розы?", "Хорошая книга", 500);

            Library c = new(3);

            c.Add(a, 1);
            c.Add(b, 2);

            foreach (var item in c)
            {
                Console.WriteLine(item);
            }    
            
        }
    }
}
