using System;

namespace DZ2910
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region[Тест Класс Matrix]
            int[,] matrix = new int[4, 4];
            int[,] matrix2 = new int[4, 4];

            Matrix obj1 = new Matrix(matrix);
            Matrix obj2 = new Matrix(matrix2);

            obj1.RandomNums();
            obj2.RandomNums();

            Console.WriteLine(obj1.Equals(obj2));

            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            Console.WriteLine(obj1 + obj2);
            Console.WriteLine(obj1 * obj2);

            Console.WriteLine(obj1.Min());
            Console.WriteLine(obj2.Max());
            #endregion

            #region[Тест Класс Book]

            string page1 = "Lorem ipsum odor amet, consectetuer adipiscing elit. " +
                "Habitant felis praesent fusce; tincidunt conubia praesent. Tristique vol" +
                "utpat non pretium eros montes nunc. Curabitur vulputate primis arcu a aliquet pulvin" +
                "ar natoque. Facilisi aenean nisi cursus nam quam nunc augue torquent. Leo justo nisl" +
                " curabitur ultrices convallis placerat sed. Senectus penatibus libero dictum magnis u" +
                "ltrices odio; cubilia odio commodo. Curae pretium libero sodales tellus arcu ante eu. " +
                "Et facilisi dolor ex dignissim facilisis cubilia.";

            string page2 = "Ipsum himenaeos at tristique tortor maximus dignissim " +
                "accumsan platea. Dictum morbi egestas dolor pulvinar nisi inceptos quam tristique. ";


            Book book1 = new("Ipsum", "Lorem");

            Book book2 = new("Suizy", "Buhem...");
            book1.Add = page1;
            book1.Add = page2;

            Console.WriteLine(book1);
            Console.WriteLine(book1.Count);
            Console.WriteLine(book1[1]);

            book2.Add = page1;
            book2.Add = page1;

            #endregion

            #region [Тест Класс ListBook]

            ListBook books1 = new ListBook();
            ListBook books2 = new ListBook();

            books1.Add = book1;
            books1.Add = book2;

            books2.Add = book2;
            books2.Add = book1;
            books2.Add = book1;

            Console.WriteLine(books1);
            Console.WriteLine(books2);

            books1.ReadBook(1);
            books1.DeleteBook(0);
            Console.WriteLine(books1);

            Console.WriteLine(books1 == books2);
            Console.WriteLine(books1 < books2);
            Console.WriteLine(books2[1]);
            books2[0] = books1[0];

            Console.WriteLine(books2);
            #endregion
        }
    }
}
