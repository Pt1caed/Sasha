using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DZ26032025
{
    internal class Methods
    {
        byte[] data;
        FileStream fs;
        public void OnCompletedRead(IAsyncResult ar)
        {
            
            int bytes = fs.EndRead(ar);
            string word = (string)ar.AsyncState;
            var content = Encoding.UTF8.GetString(data, 0, bytes);
            if (content.Contains(word))
            {
                Console.WriteLine("В этом файле содержится это слово!");
            }
            else { Console.WriteLine("Такого слова в файле не существует."); }
            fs.Close();
        }

        public void ReadFileAndFindWord(string path, string word)
        {
            var fi = new FileInfo(path);
            long lenght = fi.Length;
            data = new byte[lenght];
            fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, data.Length * 2, true);
            AsyncCallback callback = new AsyncCallback(OnCompletedRead);
            fs.BeginRead(data, 0, (int)lenght, callback, word);
        }
    }
}
