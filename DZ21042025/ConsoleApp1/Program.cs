using System.Net;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var a = await new HttpClient().GetAsync(@"https://www.gutenberg.org/cache/epub/1521/pg1521.txt").Result.Content.ReadAsStringAsync();
        }
        
    }
}
