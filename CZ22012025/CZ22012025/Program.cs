using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.Configuration;
namespace CZ22012025
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Action> MenuMethods = [AddBook, DeleteBook, UpdateBook, InfoBooks];

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите метод из предложенных: ");

                for (int i = 0; i < MenuMethods.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {MenuMethods[i].Method.Name}");
                }
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.Clear();
                    MenuMethods[choice - 1].Invoke();
                }
                else { Console.WriteLine("Такого метода не существует! "); }
                Console.ReadKey();
            }
        }

        public static Book CreateBook()
        {
            Console.WriteLine("Имя произведения: ");
            string? name = Console.ReadLine();

            Console.WriteLine("Автор: ");
            string? author = Console.ReadLine();

            Console.WriteLine("Количество страниц: ");
            int.TryParse(Console.ReadLine(), out int count_pages);

            Console.WriteLine("Категория: ");
            string? category = Console.ReadLine();

            Console.WriteLine("Издательство");
            string? publishinghouse = Console.ReadLine();

            Console.WriteLine("Год издательства: ");
            int.TryParse(Console.ReadLine(), out int year);

            return new Book
            {
                Author = author,
                Name = name,
                Category = category,
                CountPages = count_pages,
                PublishingHouse = publishinghouse,
                YearPublishingHouse = year
            };
        }

        public static Book EditBook(Book book) // мне пришлось сделать этот метод, так как когда я вручную менял объект, создавая новый и применяя его, то выдавало ошибку.
        {
            var book1 = CreateBook();

            book.Author = book1.Author;
            book.Name = book1.Name;
            book.Category = book1.Category;
            book.YearPublishingHouse = book1.YearPublishingHouse;
            book.PublishingHouse = book1.PublishingHouse;
            book.CountPages = book1.CountPages;
            return book;
        }

        public static void AddBook()
        {
            var book = CreateBook();

            using ApplicationContext db = new();
            {
                db.Books.Add(book);
                db.SaveChanges();
            }
        }

        public static void DeleteBook()
        {
            Console.WriteLine("Id: ");

            using (ApplicationContext db = new())
            {
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    var book = db.Books.Find(id);
                    if(book != null)
                    {
                        db.Books.Remove(book);
                        db.SaveChanges();
                        Console.WriteLine("Книга удалена.");
                    }
                    else { Console.WriteLine("Книги не найдено."); }
                }
            }
        }

        public static void UpdateBook()
        {
            Console.WriteLine("Id: ");
            using (ApplicationContext db = new())
            {
                if (int.TryParse(Console.ReadLine(), out int id_write))
                {

                    var book = db.Books.Find(id_write);
                    if(book != null)
                    {
                        book = EditBook(book);
                        db.Books.Update(book);
                        db.SaveChanges();
                    }
                }
                else { Console.WriteLine("Книги не найдено."); }
            }
        }

        public static void InfoBooks()
        {
            using(ApplicationContext db = new())
            {
                foreach(var book in db.Books)
                {
                    Console.WriteLine(book);
                }
            }
        }
    }
}
