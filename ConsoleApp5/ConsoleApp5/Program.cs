namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateOnly date = new DateOnly(1920, 11, 10);
            WebSite site = new WebSite() { Name = "HugaBoss", Ip = "1.123.456.66.78", Url = "https://fdshf.com", Description = "Churhchhela - very good! Hello World!" };
            Journal journal = new Journal() { Name = "Hoho!", Date = date, Description = "Bumba. bumba gumba...", Mail = "Fafa@gmail.com", TelephoneNumber = "+380687433380" };
            Shop shop = new Shop() { Name = "NewYorker", Mail = "Gumbigumbi@i.ua", Description = "Fafa, fufu, fifi...", Address = "street Bigban 18 Ushen" };

            Console.WriteLine(site);
            Console.WriteLine(shop);
            Console.WriteLine(journal);
            
        }
    }
}
