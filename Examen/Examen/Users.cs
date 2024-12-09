using System.Drawing;
using System.Runtime.Serialization.Json;

namespace Examen
{
    internal class Users
    {
        public User? CurrentUser { get; set; } = null;
        public string? PathCurrentUser { get; private set; }
        public Users()
        {
            string? BasePath = AppDomain.CurrentDomain.BaseDirectory;
            string? PathToUsers = BasePath + "Users";
            if (!Directory.Exists(PathToUsers))
                Directory.CreateDirectory(PathToUsers);

            DirectoryUsers = PathToUsers;
            Path_ = Path.Combine(PathToUsers, "RegisteredUsers.json");
        }
        public string DirectoryUsers { get; }
        public string Path_ { get; set; }

        delegate void MethodsProgram();
        public void EnterToProgram()
        {
            List<NameAndMethodMenu> ListMethods = 
                [new("Регистрация", RegisterUser), 
                new("Авторизация", AuthorizateUser), 
                new("Выход", () => Environment.Exit(0))];

            int choice = 0;

            while (true)
            {

                Console.Clear();
                Console.WriteLine("Что вы хотите сделать?");

                for (int i = 0; i < ListMethods.Count; i++)
                { Console.WriteLine($"{i}. {ListMethods[i].Name}"); }

                choice = OtherMethods.GetValidatedIndex(0, ListMethods.Count);
                if(choice == -1)
                {
                    continue;
                }

                break;
            }
            ListMethods[choice].Method?.Invoke();
        }

        public void RegisterUser()
        {
            var file = ReadUsers();

            string? login;
            string? password;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Логин:");
                login = Console.ReadLine();
                if(login?.ToArray().Length <= 3)
                {
                    Console.WriteLine("Логин не может быть меньше 4 символов!");
                    Console.ReadKey();
                    continue;
                }

                int count = file.Where(x => x.Login == login).Count();
                if (count > 0 || login == null)
                {
                    Console.WriteLine("Такой логин уже существует или вы не ввели логин!");
                    Console.ReadKey();
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Пароль: ");
                password = Console.ReadLine();

                if (password == null)
                {
                    Console.WriteLine("Пароль не может быть пуст!");
                    continue;
                }
                break;
            }

            int year;
            int month;
            int day;
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Дата рождения\n");
                Console.WriteLine("Год: ");
                year = OtherMethods.GetValidatedIndex(1, int.MaxValue);

                Console.WriteLine("Месяц: ");
                month = OtherMethods.GetValidatedIndex(1, 13);

                Console.WriteLine("День: ");
                day = OtherMethods.GetValidatedIndex(1, 32);

                if(year == -1 || month == -1 || day == -1)
                {
                    Console.WriteLine("Дата введена неправильно!");
                    Console.ReadKey();
                    continue;
                }
                break;
            }

            AddUser(new(login, password, MaxId(), year, month, day));

            Directory.CreateDirectory(Path.Combine(DirectoryUsers, login));
            Console.WriteLine("Регистрация прошла успешно!");
        }

        public void AuthorizateUser()
        {
            var file = ReadUsers();
            while (true)
            {
                Console.Clear();
                string? login;
                string? password;
                Console.WriteLine("Логин:");
                login = Console.ReadLine();

                Console.WriteLine("Пароль: ");
                password = Console.ReadLine();

                var new_users = file.Where(x => x.Login == login && x.Password == password).ToList();

                foreach (var user in new_users)
                {
                    Console.WriteLine(user);
                }

                int count = new_users.Count();

                if (count == 1)
                {
                    CurrentUser = new_users[0];

                    if(CurrentUser.Login != null)
                    PathCurrentUser = Path.Combine(DirectoryUsers, CurrentUser.Login);

                    Console.WriteLine("Авторизация прошла успешно!");
                    break;
                }
                else
                {
                    Console.WriteLine("Пользователь с такими данными не найден!");
                }
                Console.ReadKey();
            }
        }

        public void ChangePasswordCurrentUser()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if (CurrentUser != null)
            {
                int attempts = 0;
                var Wrong = (string message) =>
                {
                    Console.WriteLine(message);
                    attempts++;
                };
                var CheckAttempts = () =>
                {
                    if (attempts >= 3)
                    {
                        Console.WriteLine("Вы исчерпали все попытки!");
                        Console.ReadKey();
                        return;
                    }
                };

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Старый пароль: ");
                    string? old_password = Console.ReadLine();

                    if (old_password != CurrentUser?.Password)
                    {
                        Wrong("Старый пароль введен не правильно!");
                        CheckAttempts();
                        continue;
                    }
                    break;
                }
                attempts = 0;
                while (true)
                {

                    Console.WriteLine("Новый пароль: ");
                    string? new_password = Console.ReadLine();
                    if (new_password?.Length <= 3)
                    {
                        Wrong("Пароль не может быть меньше 4 символов!");
                        CheckAttempts();
                        continue;
                    }
                    if(CurrentUser != null)
                        CurrentUser.Password = new_password;
                    break;
                }

                var list_users = MethodsSerialization<User>.ReadJson(Path_);
                list_users = list_users.Where(list => list.Id != CurrentUser?.Id).ToList();
                if (CurrentUser != null)
                    list_users.Add(CurrentUser);
                MethodsSerialization<User>.UpdateJson(Path_, list_users);


            }

        }

        public void ChangeBirthdayCurrentUser()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if(CurrentUser != null)
            {
                int attempts = 0;
                var Wrong = (string message) =>
                {
                    Console.WriteLine(message);
                    attempts++;
                };
                var CheckAttempts = () =>
                {
                    if (attempts >= 3)
                    {
                        Console.WriteLine("Вы исчерпали все попытки!");
                        Console.ReadKey();
                        return;
                    }
                };

                while(true)
                {
                    Console.Clear();
                    Console.WriteLine("Год: ");
                    int year = OtherMethods.GetValidatedIndex(1, int.MaxValue);

                    Console.WriteLine("Месяц: ");
                    int month = OtherMethods.GetValidatedIndex(1, 13);

                    Console.WriteLine("День: ");
                    int day = OtherMethods.GetValidatedIndex(1, 32);

                    if (year == -1 || month == -1 || day == -1)
                    {
                        Wrong("Дата введена неправильно!");
                        CheckAttempts();
                        continue;
                    }
                    DateOnly new_date = new(year, month, day);
                    if (CurrentUser != null)
                        CurrentUser.Birthday = new_date.ToString("yyyy-MM-dd");
                    break;
                }

                var list_users = MethodsSerialization<User>.ReadJson(Path_);
                list_users = list_users.Where(list => list.Id != CurrentUser?.Id).ToList();
                list_users.Add(CurrentUser);
                MethodsSerialization<User>.UpdateJson(Path_, list_users);
            }
        }

        public int MaxId()
        {
            var list = ReadUsers();
            if(list.Count == 0)
            {
                return 1;
            }
            int max = list.Max(x => x.Id);
            return max + 1;
        }

        public List<User> ReadUsers()
        {
            return MethodsSerialization<User>.ReadJson(Path_);
        }
        public void AddUser(User user)
        {
            MethodsSerialization<User>.AddToJson(Path_, user);
            
        }

    }
}
