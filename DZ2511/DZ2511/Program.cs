using System;
using System.ComponentModel;

namespace DZ2511
{
    internal class Program
    {
        delegate void EmployeeDelegate(List<Employee> list);
        delegate void MessageDelegate();
        event MessageDelegate? Message;

        static List<IComparer<Employee>> list_sort = [new SortFullName(), new SortJobTitle(), new SortSalary(), new SortMail()];
        static void Main(string[] args)
        {
            Employee employee1 = new("Mister", "Admin", 100, "Ivan@gmail.com");
            Employee employee2 = new("Kira", "NoAdmin", 10, "Leze@i.ua");


            List<EmployeeDelegate> delegateList = [AddCin, DeleteEmployee, ChangeEmployee, SearchEmployee, SortEmployees, PrintEmployees];

            List<Employee> employees = [employee1, employee2];



            while (true)
            {
                Console.WriteLine("Выберите что хотите сделать(-1 = выход):");

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
                if (index_method >= 0 && index_method < delegateList.Count)
                {
                    delegateList[index_method].Invoke(employees);
                }
                Console.WriteLine();
            }

        }

        public static void AddCin(List<Employee> list)
        {
            Console.WriteLine("Имя: ");
            string? name = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Должность: ");
            string? job_title = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Зарплата: ");
            string? string_salary = Console.ReadLine();

            double salary = Convert.ToDouble(string_salary);

            Console.WriteLine();

            Console.WriteLine("Эмейл: ");
            string? mail = Console.ReadLine();

            if (name != null && job_title != null && mail != null)
            {
                list.Add(new(name, job_title, salary, mail));
            }
            else
            {
                list.Add(new());
            }
        }

        public static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($" {i}. {employees[i].ToString()}");
            }
        }

        public static void DeleteEmployee(List<Employee> list)
        {
            int index;

            Console.WriteLine("Индекс: ");
            index = Convert.ToInt32(Console.ReadLine());

            list.RemoveAt(index);
        }

        public static void ChangeEmployee(List<Employee> list)
        {
            int index;

            Console.WriteLine("Индекс: ");
            index = Convert.ToInt32(Console.ReadLine());

            if(index < 0 || index > list.Count)
            {
                Console.WriteLine("Такого индекса не существует!");
                return;
            }

            Console.WriteLine("Имя: ");
            string? name = Console.ReadLine();

            Console.WriteLine("Должность: ");
            string? job_title = Console.ReadLine();

            Console.WriteLine("Зарплата: ");
            string? string_salary = Console.ReadLine();

            double salary = Convert.ToDouble(string_salary);

            Console.WriteLine("Эмейл: ");
            string? mail = Console.ReadLine();

            if (name != null && job_title != null && mail != null)
            {
                list[index] = new(name, job_title, salary, mail);
            }


        }

        public static void SearchEmployee(List<Employee> list)
        {
            List<string> Criterions = ["Full Name", "Job Title", "Salary", "Mail"];

            var a = typeof(Employee).GetMethods();

            var PrintResult = (List<Employee> list) =>
            {
                Console.WriteLine("Всего найденный результатов: ");

                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"index: {i} => {list[i]}");
                }
            };

            Console.WriteLine("По каким критериям нужно искать? ");

            for (int i = 0; i < Criterions.Count; i++)
            {
                Console.WriteLine($"{i}. {Criterions[i]}");
            }

            string? choose = Console.ReadLine();

            List<Employee> list1 = [];

            switch (choose)
            {
                case "0":
                    string? name = Console.ReadLine();
                    if(name != null)
                    {
                        list1 = list.Where(p => p.FullName?.Contains(name) == true).ToList();
                    }
                    break;
                case "1":
                    string? jobtitle = Console.ReadLine();
                    if (jobtitle != null)
                    {
                        list1 = list.Where(p => p.JobTitle?.Contains(jobtitle) == true).ToList();
                    }
                    break;
                case "2":
                    double Salary = Convert.ToInt32(Console.ReadLine());
                    list1 = list.Where(p => p.Salary == Salary).ToList();
                    break;
                case "3":

                    string? Mail = Console.ReadLine();
                    if (Mail != null)
                    {
                        list1 = list.Where(p => p.FullName?.Contains(Mail) == true).ToList();
                    }
                    break;
            }
            PrintResult(list1);
        }
        public static void SortEmployees(List<Employee> list)
        {
            Console.WriteLine("Выберите способ сортировки: ");

            for (int i = 0; i < list_sort.Count; i++)
            {
                Console.WriteLine($"{i}. {list_sort[i].GetType()}");   
            }

            int choice = Convert.ToInt32(Console.ReadLine());

            list.Sort(list_sort[choice]);
        }
    }
    
}
