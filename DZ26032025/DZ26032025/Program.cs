using System.Text;

namespace DZ26032025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methods method = new Methods();
            method.ReadFileAndFindWord(@"D:\Tiles\privet.txt", "hello");
        }
    }

}
