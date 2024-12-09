using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Quizes
    {
        public Quizes()
        {
            BaseQuizes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Quizes");

            if(!Directory.Exists(BaseQuizes))
                Directory.CreateDirectory(BaseQuizes);
        }

        public string BaseQuizes { get; set; }


        public void CreateQuize(Quiz quiz, List<QandA> quizQuestAnsw) // Создание папки для викторины, сериализация данных в папку, в файл json
        {
            if (string.IsNullOrWhiteSpace(quiz.NameQuiz))
            {
                Console.WriteLine("Quiz name is invalid.");
                return;
            }
            string QuizDirectory = Path.Combine(BaseQuizes, quiz.NameQuiz);
            if (!Directory.Exists(QuizDirectory))
            {
                Directory.CreateDirectory(QuizDirectory);
            }

            File.WriteAllText(Path.Combine(QuizDirectory, "Name.txt"), quiz.NameQuiz);
            MethodsSerialization<List<QandA>>.AddToJson(Path.Combine(QuizDirectory, "Question_And_Answers.json"), quizQuestAnsw);
        }

        private void ShuffleListWoC(List<WrongOrCorrectAnswer> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                (list[k], list[n]) = (list[n], list[k]);
            }
        }
        public QuizeResult PlayRandomQuize()
        {
            int count_correct_answers = 0;
            var list_quizes_paths = Directory.GetDirectories(BaseQuizes);
            List<QandA> List_QandA = [];

            foreach(var path in list_quizes_paths)
            {
                var quize = MethodsSerialization<QandA>.ReadJson1(Path.Combine(path, "Question_And_Answers.json"));
                List_QandA.Add(quize[new Random().Next(0, quize.Count)]);
            }
            if (List_QandA == null)
            {
                Console.WriteLine("Ошибка: файл не был загружен или пуст.");
                return null;
            }

            for (int i = 0; i < List_QandA.Count; i++)
            {
                Console.Clear();
                if (List_QandA[i].CorrectAnswers == null || List_QandA[i].WrongAnswers == null)
                {
                    Console.WriteLine("Ошибка: Нет правильных или неправильных ответов для вопроса.");
                    continue;
                }

                Console.Write($"{i}/{List_QandA.Count}  {List_QandA[i].Question}");
                if (List_QandA[i].CorrectAnswers.Count > 1)
                {
                    Console.WriteLine("(Ответ не один)");
                }
                else
                {
                    Console.WriteLine();
                }

                List<WrongOrCorrectAnswer> list_answers = new List<WrongOrCorrectAnswer>();
                foreach (var item in List_QandA[i].WrongAnswers)
                {
                    list_answers.Add(new WrongOrCorrectAnswer(item, false));
                }
                foreach (var item in List_QandA[i].CorrectAnswers)
                {
                    list_answers.Add(new WrongOrCorrectAnswer(item, true));
                }
                ShuffleListWoC(list_answers);

                for (int j = 0; j < list_answers.Count; j++)
                {
                    Console.WriteLine($"{j}. {list_answers[j].Answer}");
                }

                if (List_QandA[i].CorrectAnswers.Count == 1)
                {

                    if (!int.TryParse(Console.ReadLine(), out int index) || index < 0 || index >= list_answers.Count)
                    {
                        index = new Random().Next(0, list_answers.Count);
                    }
                    else if (list_answers[index].IsCorrect == true)
                    {
                        count_correct_answers++;
                    }
                }
                else
                {
                    List<int> indexes = new List<int>();

                    while (true)
                    {
                        Console.WriteLine("(Введите -1 для конечного ответа): ");
                        if (int.TryParse(Console.ReadLine(), out int index))
                        {
                            indexes.Add(index);
                        }
                        if (index == -1)
                        { break; }
                    }
                    int correct_indexes = indexes.Where(t => t >= 0 && t < list_answers.Count).Where(t => list_answers[t].IsCorrect == true).Distinct().Count();

                    if (correct_indexes == List_QandA[i].CorrectAnswers.Count)
                    {
                        count_correct_answers++;
                    }
                }
            }

            Console.WriteLine($"Ты ответил правильно: {count_correct_answers}/{List_QandA.Count}");
            Console.ReadKey();
            return new QuizeResult("Случайная Викторина", " ", List_QandA.Count, count_correct_answers, DateOnly.FromDateTime(DateTime.Now));

        }

        public QuizeResult PlayQuize(string path)
        {
            var path_name = path;
            path = Path.Combine(path, "Question_And_Answers.json");
            double count_correct_answers = 0;

            List<QandA> List_QandA = MethodsSerialization<QandA>.ReadJson1(path);
            if (List_QandA == null)
            {
                Console.WriteLine("Ошибка: файл не был загружен или пуст.");
                return null;
            }

            for (int i = 0; i < List_QandA.Count; i++)
            {
                Console.Clear();
                if (List_QandA[i].CorrectAnswers == null || List_QandA[i].WrongAnswers == null)
                {
                    Console.WriteLine("Ошибка: Нет правильных или неправильных ответов для вопроса.");
                    continue;
                }

                Console.Write($"{i}/{List_QandA.Count}  {List_QandA[i].Question}");
                if (List_QandA[i].CorrectAnswers.Count > 1)
                {
                    Console.WriteLine("(Ответ не один)");
                }
                else
                {
                    Console.WriteLine();
                }

                List<WrongOrCorrectAnswer> list_answers = new List<WrongOrCorrectAnswer>();
                foreach (var item in List_QandA[i].WrongAnswers)
                {
                    list_answers.Add(new WrongOrCorrectAnswer(item, false));
                }
                foreach (var item in List_QandA[i].CorrectAnswers)
                {
                    list_answers.Add(new WrongOrCorrectAnswer(item, true));
                }
                ShuffleListWoC(list_answers);

                for (int j = 0; j < list_answers.Count; j++)
                {
                    Console.WriteLine($"{j}. {list_answers[j].Answer}");
                }

                if (List_QandA[i].CorrectAnswers.Count == 1)
                {

                    if(!int.TryParse(Console.ReadLine(), out int index) || index < 0 || index >= list_answers.Count)
                    {
                        index = new Random().Next(0, list_answers.Count);
                    }
                    else if (list_answers[index].IsCorrect == true)
                    {
                        count_correct_answers++;
                    }
                }
                else
                {
                    List<int> indexes = new List<int>();

                    while (true)
                    {
                        Console.WriteLine("(Введите -1 для конечного ответа): ");
                        if (int.TryParse(Console.ReadLine(), out int index))
                        {
                            indexes.Add(index);
                        }
                        if (index == -1)
                        { break; }
                    }
                    int correct_indexes = indexes.Where(t => t >= 0 && t < list_answers.Count).Where(t => list_answers[t].IsCorrect == true).Distinct().Count();

                    if (correct_indexes == List_QandA[i].CorrectAnswers.Count)
                    {
                        count_correct_answers++;
                    }
                }
            }

            Console.WriteLine($"Ты ответил правильно: {count_correct_answers}/{List_QandA.Count}");
            Console.ReadKey();
            return new QuizeResult(File.ReadAllText(Path.Combine(path_name, "Name.txt")), " ", List_QandA.Count, count_correct_answers, DateOnly.FromDateTime(DateTime.Now));
        }


        public QuizeResult ChooseQuize()
        {
            Console.WriteLine("Какую викторины вы выберите?");
            var a = Directory.GetDirectories(BaseQuizes);

            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{i}. {File.ReadAllText(Path.Combine(a[i], "Name.txt"))}");
            }

            int index;

            do
            {
                index = Convert.ToInt32(Console.ReadLine());
            }
            while (index >= a.Length || index < 0);
            var c = PlayQuize(Path.Combine(a[index]));
            return c;
        }



        //public void CreateQuiz()
    }
}
