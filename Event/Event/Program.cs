using System.Security.Cryptography.X509Certificates;

namespace Event
{
    internal class Program
    {
        public static void Print(string message) => Console.WriteLine(message + '\n');
        public static void Print1(object? e,  EventMessageArgs? message) => Console.WriteLine(message?.Message);
        static void Main(string[] args)
        {
            CreditCard card = new("Fif", "+305435345", new(1920, 12, 11));

            card.Notify += Print;
            card.TryOperation += Print1;

            card.StartCredit(10000);
            card.Put(10);
            card.Put(1000000);

            card.ReNamePin(101);

        }
    }
}
