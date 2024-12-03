using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DZ2511_1_
{
    internal class Program
    {
        delegate void MethodsDelegate(LinkedList<Book> list);
        static void Main(string[] args)
        {
            LinkedList<Book> list = [];

            list.AddLast(new Book("Goodvin", "Marvel", "Fantasy", 1915, 12, 11));
            list.AddLast(new Book("My Little Pony", "Disney", "Spooky", 2000, 5, 6));
            list.AddLast(new Book("My Little Pony", "Disney", "Spooky", 2000, 5, 6));
            list.AddLast(new Book("Goodvin", "Marvel", "Fantasy", 1915, 12, 11));
            List<MethodsDelegate> delegateList = [PrintBook, AddBook, AddFirst, AddEnd, AddIndex, DeleteIndex, DeleteFirst, DeleteEnd, ChangeBook, Search];

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Выберите метод(-1 = выход): ");

                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < delegateList.Count; i++)
                {
                    Console.WriteLine($"{i}. {delegateList[i].Method.Name}");
                }

                int index_method = Convert.ToInt32(Console.ReadLine());

                if(index_method == -1)
                {
                    Console.Clear();
                    break;
                }

                Console.Clear();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                if (index_method >= 0 && index_method < delegateList.Count)
                {
                    delegateList[index_method].Invoke(list);
                }
                Console.WriteLine();
            }
            
            
        }


        public static void AddBook(LinkedList<Book> list)
        {
            list.AddLast(CreateObject());
        }

        public static void DeleteIndex(LinkedList<Book> list)
        {
            Console.WriteLine("Индекс: ");
            int index = Convert.ToInt32(Console.ReadLine());


            var current = list.First;
            for (int i = 0; i < index; i++)
            {
                current = current?.Next;
            }
            if (current != null)
            {
                list.Remove(current);
            }
        }

        public static void ChangeBook(LinkedList<Book> list)
        {
            int index;
            Console.WriteLine("Индекс: ");
            index = Convert.ToInt32(Console.ReadLine());

            if(index < 0 || index >= list.Count)
            {
                throw new Exception();
            }

            var current = list.First;
            for (int i = 0; i < index; i++)
            {
                current = current?.Next;
            }
            if (current != null)
            {
                current.Value = CreateObject();
            }
        }

        public static void AddIndex(LinkedList<Book> list)
        {
            Console.WriteLine("Индекс: ");

            int index = Convert.ToInt32(Console.ReadLine());

            if(index < 0 || index >= list.Count)
            {
                Console.WriteLine("Индекс за пределами массива.");
                return;
            }

            list.AddLast(list.Last.Value);
            
            var end = list.Last;

            for (int i = list.Count - 1; i != index; i--)
            {
                end = end?.Previous;
                
                if(end != null)
                end.Value = end.Previous?.Value;
            }
            if(end != null)
            end.Value = CreateObject();


        }

        public static void AddFirst(LinkedList<Book> list)
        {
            list.AddFirst(CreateObject());
        }

        public static void AddEnd(LinkedList<Book> list)
        {
            list.AddLast(CreateObject());
        }

        public static void DeleteFirst(LinkedList<Book> list)
        {
            list.RemoveFirst();
        }

        public static void DeleteEnd(LinkedList<Book> list)
        {
            list.RemoveLast();
        }

        public static void Search(LinkedList<Book> list)
        {
            List<string> texts = ["Name", "Author", "Genre", "Date Release"];

            Console.WriteLine("По какой характеристике искать: ");

            for (int i = 0; i < texts.Count; i++)
            {
                Console.WriteLine($"{i}. " + texts[i]);
            }

            string? choice = Console.ReadLine();

            LinkedList<Book> list1 = [];

            switch (choice)
            {
                case "0":
                    string? name = Console.ReadLine();
                    if (name != null)
                    {
                        list1 = new LinkedList<Book>(list.Where(p => p.Name.Contains(name)).ToList());
                    }
                    break;

                case "1":
                    string? author = Console.ReadLine();
                    if (author != null)
                    {
                        list1 = new LinkedList<Book>(list.Where(p => p.Author.Contains(author)).ToList());
                    }
                    break;
                case "2":
                    string? genre = Console.ReadLine();
                    if (genre != null)
                    {
                        list1 = new LinkedList<Book>(list.Where(p => p.Genre == genre).ToList());
                    }
                    break;
                case "3":
                    Console.WriteLine("Год: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Месяц: ");
                    int month = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("День: ");
                    int day = Convert.ToInt32(Console.ReadLine());

                    DateOnly date = new(year, month, day);

                    list1 = new LinkedList<Book>(list.Where(p => p.DateRelease == date).ToList());
                    break;
            }

            Console.WriteLine("По твоим критериям найдено: \n");

            var list1_next = list1.First;


            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1_next?.Value);
                list1_next = list1_next?.Next;
            }
        }

        public static void PrintBook(LinkedList<Book> list)
        {
            var first = list.First;

            while (first != null)
            {
                Console.WriteLine(first?.Value);
                first = first?.Next;
            }
        }

        public static Book CreateObject()
        {
            Console.WriteLine("Имя: ");
            string? name = Console.ReadLine();

            Console.WriteLine("Автор: ");
            string? author = Console.ReadLine();

            Console.WriteLine("Жанр: ");
            string? genre = Console.ReadLine();

            Console.WriteLine("Год выхода: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Месяц: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("День: ");
            int day = Convert.ToInt32(Console.ReadLine());
            DateOnly date = new(year, month, day);


            if (name != null && author != null && genre != null)
            {
                return new(name, author, genre, date);
            }
            else
            {
                throw new Exception("Одна из переменных равняется null.");
            }
        }

    }

}
