using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Core
    {
        private Users UsersControl = new();
        private Quizes QuizesControl = new();
        private List<NameAndMethodMenu> MethodsMenu = new();
        private string PathHistoryQuizes
        {
            get { return Path.Combine(UsersControl?.PathCurrentUser, "HistoryQuizes.json"); }
        }


        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            UsersControl.CurrentUser = null;
            do
            {
                UsersControl.EnterToProgram();
            }
            while (UsersControl.CurrentUser == null);


            MethodsMenu = new()
            {
                new("Выбор викторины", PlayQuiz_WriteResult),
                new("Сыграть в случайную викторину", PlayRandomQuiz_WriteResult),
                new("Топ 10 ваших прохождений", TopQuizes),
                new("История прохождений", HistoryQuizes),
                new("Топ прохождений викторин", ChooseTopRatesQuizes),
                new("Изменить данные аккаунта", ChangeDataCurrentUser),
                new("Выход из акаунта", Start),
            };
            Menu(MethodsMenu);
        }

        

        private void ChangeDataCurrentUser()
        {
            List<NameAndMethodMenu>? ChangeDataMethods =
                [new("Изменить пароль", UsersControl.ChangePasswordCurrentUser), 
                new("Изменить почту", UsersControl.ChangeBirthdayCurrentUser)];

            
            Console.WriteLine("Что вы хотите изменить?(-1 = выход)");

            for (int i = 0; i < ChangeDataMethods.Count; i++)
            {
                Console.WriteLine($"{i}. {ChangeDataMethods[i].Name}");
            }
            int index = OtherMethods.GetValidatedIndex(0, ChangeDataMethods.Count);
            if(index == -1)
            {
                return;
            }
            ChangeDataMethods[index].Method?.Invoke();

        }

        private void Menu(List<NameAndMethodMenu> parts_menu)
        {
            StandardQuizes();
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Вы: { UsersControl.CurrentUser?.Login }");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nМеню\n");

                Console.ForegroundColor = ConsoleColor.Cyan;
                OutputPartsMenu(parts_menu);
                int choice = OtherMethods.GetValidatedIndex(0, MethodsMenu.Count);

                if(choice == -1)
                {
                    continue;
                }

                parts_menu[choice].Method?.Invoke();
            }
        }

        private void OutputPartsMenu(List<NameAndMethodMenu> parts_menu)
        {
            for (int i = 0; i < parts_menu.Count; i++)
            {
                Console.WriteLine($"{i}. {parts_menu[i].Name}");
            }
        }

        private void TopRatesQuizes(string path)
        {
            Console.Clear();
            var List_TopUsers = MethodsSerialization<QuizeResult>.ReadJson(path);
            if(List_TopUsers.Count > 0 )
            {
                List_TopUsers = List_TopUsers.OrderByDescending(item => item.Points / (double)item.MaxPoints).ToList();
                Console.WriteLine("Топ 20 за всё время:");
                for (int i = 0;i < List_TopUsers.Count;i++)
                {
                    Console.WriteLine($"{i + 1}. {List_TopUsers[i]}");
                }
            }
            else
            {
                Console.WriteLine("Эту викторину пока что никто не проходил!");
            }
            Console.ReadKey();
        }

        private void ChooseTopRatesQuizes()
        {
            var directories_quizes = Directory.GetDirectories(QuizesControl.BaseQuizes).ToList();

            while(true)
            {
                Console.Clear();
                Console.WriteLine("Выберите, какую викторины вы хотите просмотреть(-1 = выход): ");

                for (int i = 0; i < directories_quizes.Count; i++)
                {
                    Console.WriteLine($"{i}. {File.ReadAllText(Path.Combine(directories_quizes[i], "Name.txt"))}");
                }
                int index = OtherMethods.GetValidatedIndex(-1, directories_quizes.Count);

                if(index == -1)
                {
                    break;
                }
                if (index >= 0 && index < directories_quizes.Count)
                {
                    TopRatesQuizes(Path.Combine(directories_quizes[index], "HistoryUsers.json"));
                    break;
                }
                else
                {
                    continue;
                }
            }

        }

        private void PlayQuiz_WriteResult()
        {
            Console.Clear();

            var quizResult = QuizesControl.ChooseQuize();
            quizResult.NameUser = new(UsersControl.CurrentUser?.Login);

            string historyUsersPath = Path.Combine(QuizesControl.BaseQuizes, quizResult.NameQuiz, "HistoryUsers.json");

            MethodsSerialization<QuizeResult>.AddToJson(historyUsersPath, quizResult);

            var topList = MethodsSerialization<QuizeResult>.ReadJson(historyUsersPath).OrderByDescending(t => t.Points / (double)t.MaxPoints).ToList();

            int userRank = topList.FindIndex(t => t.NameUser == quizResult.NameUser && t.Points == quizResult.Points) + 1;

            Console.WriteLine($"Ваш результат: {quizResult.Points}/{quizResult.MaxPoints}");
            Console.WriteLine($"Вы на {userRank}-м месте из {topList.Count} участников!");

            MethodsSerialization<QuizeResult>.AddToJson(PathHistoryQuizes, quizResult);

            Console.ReadKey();
        }

        private void PlayRandomQuiz_WriteResult()
        {
            Console.Clear();
            var quizResult = QuizesControl.PlayRandomQuize();
            quizResult.NameUser = new(UsersControl.CurrentUser?.Login);
            MethodsSerialization<QuizeResult>.AddToJson(PathHistoryQuizes, quizResult);
        }

        private void HistoryQuizes()
        {
            Console.Clear();
            Console.WriteLine("История ваших прохождений:");

            var UserQuizes = MethodsSerialization<QuizeResult>.ReadJson(PathHistoryQuizes).ToList();

            for (int i = 0; i < UserQuizes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {UserQuizes[i]}");
            }
            Console.ReadKey();
        }

        private void TopQuizes()
        {
            Console.Clear();
            Console.WriteLine("Топ 10 ваших прохождений за всё время: ");

            var UserQuizes = MethodsSerialization<QuizeResult>.ReadJson(PathHistoryQuizes).ToList();
            UserQuizes = UserQuizes.OrderBy(p => p.MaxPoints / p.Points).ToList();

            for(int i = 0; i < UserQuizes.Count;i++)
            {
                Console.WriteLine($"{i + 1}. {UserQuizes[i]}");
            }
            Console.ReadKey();
        }


        private void StandardQuizes() // Что-то типа базы данных. Если стандартных викторин нету, то они автоматичеси подгружаются.
        {
            if (
                !Directory.Exists(Path.Combine(QuizesControl.BaseQuizes, "Математика"))
                && !Directory.Exists(Path.Combine(QuizesControl.BaseQuizes, "Английский"))
                && !Directory.Exists(Path.Combine(QuizesControl.BaseQuizes, "Игры")))

            {

                QandA math1 = new("Какой квадратный корень 144?", new List<string> { "5", "11", "13" }, new List<string> { "12" });
                QandA math2 = new("Что такое 25% от 200?", new List<string> { "100", "25", "150" }, new List<string> { "50" });
                QandA math3 = new("Каков периметр прямоугольника с длинами сторон 5 см и 8 см?", new List<string> { "25см", "13см", "58см" }, new List<string> { "26см" });
                QandA math4 = new("Какова высота равностороннего треугольника со стороной 6?", new List<string> { "6", "4.5", "2 корней 3" }, new List<string> { "5.2", "3 корней 3" });
                QandA math5 = new("Чему равна площадь круга с радиусом 3?", new List<string> { "18", "6 PI", "36"}, new List<string> { "28.3", "9 PI" });
                QandA math6 = new("Чему равна сумма углов треугольника?", new List<string> { "180 градусов", "360 градусов", "90 градусов" }, new List<string> { "180 градусов" });
                QandA math7 = new("Сколько будет 7 умножить на 8?", new List<string> { "54", "64", "56" }, new List<string> { "56" });
                QandA math8 = new("Что больше: 3/4 или 2/3?", new List<string> { "Равны", "2/3" }, new List<string> { "3/4" });
                QandA math9 = new("Чему равен 2 в 10 степени?", new List<string> { "512", "2048", "1024" }, new List<string> { "1024" });
                QandA math10 = new("Чему равна площадь треугольника со стороной 4 и высотой 6?", new List<string> { "24", "10", "18" }, new List<string> { "12" });
                QandA math11 = new("Чему равна сумма квадратов катетов прямоугольного треугольника?", new List<string> { "Периметр", "Гипотенуза в квадрате" }, new List<string> { "Гипотенуза в квадрате" });
                QandA math12 = new("Чему равно 45 градусов в радианах?", new List<string> { "PI/2", "PI", "PI/4" }, new List<string> { "PI/4" });
                QandA math13 = new("Сколько граней у куба?", new List<string> { "12", "8", "10" }, new List<string> { "6" });
                QandA math14 = new("Чему равен корень из 49?", new List<string> { "5", "9", "8" }, new List<string> { "7" });
                QandA math15 = new("Сколько сантиметров в одном метре?", new List<string> { "10", "1000", "100" }, new List<string> { "100" });
                QandA math16 = new("Чему равно 10% от 500?", new List<string> { "45", "25", "15" }, new List<string> { "50" });
                QandA math17 = new("Чему равна площадь квадрата с длиной стороны 4?", new List<string> { "8", "12", "18" }, new List<string> { "16" });
                QandA math18 = new("Чему равен объем куба с длиной стороны 2?", new List<string> { "12", "10", "16" }, new List<string> { "8" });
                QandA math19 = new("Сколько часов в одной неделе?", new List<string> { "160", "120", "200" }, new List<string> { "168" });
                QandA math20 = new("Чему равно 2+2*2?", new List<string> { "8", "4", "10" }, new List<string> { "6" });
                QandA math21 = new("Чему равен радиус круга, если его диаметр 10?", new List<string> { "15", "2.5", "6" }, new List<string> { "5" });
                QandA math22 = new("Чему равна длина окружности с радиусом 3?", new List<string> { "18", "12 PI", "6 PI" }, new List<string> { "6 PI" });
                QandA math23 = new("Что будет, если умножить 0 на 1000?", new List<string> { "1", "1000", "10" }, new List<string> { "0" });
                QandA math24 = new("Сколько дней в високосном году?", new List<string> { "365", "363", "367" }, new List<string> { "366" });
                QandA math25 = new("Сколько будет 100 делить на 4?", new List<string> { "50", "20", "40" }, new List<string> { "25" });

                List<QandA> math_test = [math1, math2, math3, math4, math5, math6, math7, math8, math9, math10, math11, math12, math13, math14, math15, math16, math17, math18, math19, math20, math21, math22, math23, math24, math25];

                QandA game1 = new("В какой игре впервые появился персонаж Марио?",
                    new List<string> { "The Legend of Zelda", "Metroid", "Kirby" },
                    new List<string> { "Donkey Kong" });

                QandA game2 = new("Какая компания разработала игру The Witcher?",
                    new List<string> { "Ubisoft", "Bethesda", "Rockstar Games" },
                    new List<string> { "CD Projekt RED" });

                QandA game3 = new("Как называется валюта в игре Minecraft?",
                    new List<string> { "Золото", "Рубли", "Алмазы" },
                    new List<string> { "Изумруды", "Алмазы" });

                QandA game4 = new("Какой жанр у игры League of Legends?",
                    new List<string> { "RPG", "FPS", "Survival" },
                    new List<string> { "MOBA", "Стратегия" });

                QandA game5 = new("Сколько игроков участвует в стандартной игре Among Us?",
                    new List<string> { "15", "20", "5" },
                    new List<string> { "10", "до 15 (в обновлении)" });

                List<QandA> game_test = new List<QandA> { game1, game2, game3, game4, game5 };

                QandA geo1 = new("Какая самая длинная река в мире?", new List<string> { "Волга", "Ганг", "Дунай" }, new List<string> { "Амазонка", "Нил" });
                QandA geo2 = new("В какой стране находится Эйфелева башня?", new List<string> { "Италия", "Германия", "Испания" }, new List<string> { "Франция", "Париж" });
                QandA geo3 = new("На каком континенте находится пустыня Сахара?", new List<string> { "Азия", "Австралия", "Америка" }, new List<string> { "Африка" });
                QandA geo4 = new("Какое озеро самое глубокое в мире?", new List<string> { "Виктория", "Титикака", "Каспийское море" }, new List<string> { "Байкал" });
                QandA geo5 = new("Какая страна имеет больше всего соседей?", new List<string> { "Индия", "Бразилия", "Канада" }, new List<string> { "Россия", "Китай" });
                List<QandA> geo_test = new List<QandA> { geo1, geo2, geo3, geo4, geo5 };



                QuizesControl.CreateQuize(new("Математика"), math_test);
                QuizesControl.CreateQuize(new("Игры"), game_test);
                QuizesControl.CreateQuize(new("География"), geo_test);
            }
        }

    }
}
