using System.Collections.Generic;

namespace DZ190320251
{
    internal class Program
    {
        static SynchronizationContext? uiContext = SynchronizationContext.Current;
        private static readonly string PathToNums = Path.Combine(Directory.GetCurrentDirectory(), "nums.txt");
        private static readonly string PathToTableMultiple = Path.Combine(Directory.GetCurrentDirectory(), "TableMultiple.txt");
        static async Task Main(string[] args)
        {
            //1
            var list = await ReadTxtFileNums();
            await UniqueNums(list);

            //2
            await TheBiggestSequence(list);

            //3
            await ParralelMultipleDiaposone(1, 5);
        }
        public static async Task<List<int>> ReadTxtFileNums()
        {
            using (StreamReader sr = new(PathToNums))
            {
               return await Task.Run(() => 
               {
                   return sr.ReadToEnd()
               .Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(x => Convert.ToInt32(x.Trim())).ToList();
               });
            }
        }

        public static async Task<List<string>> ReadTxtFile()
        {
            using (StreamReader sr = new(PathToTableMultiple))
            {
                return await Task.Run(() => 
                {
                    return sr.ReadToEnd().Split(new[] { 'r', '\n'}, StringSplitOptions.RemoveEmptyEntries).Select(p => p).ToList();
                });
            }
        }

        public static async Task UniqueNums(List<int> list)
        {
            var list_countUnique = await Task.Run(() => list.AsParallel().Distinct().Count());
            Console.WriteLine($"1. Количество уникальных чисел: {list_countUnique}");
        }
        public static async Task TheBiggestSequence(List<int> list)
        {
            int index_start__TheBiggestSequence = 0;
            int index_end__TheBiggestSequence = 0;
            await Task.Run(async () =>
            {
                var list = await ReadTxtFileNums();

                int index_start = 0;
                int index_end = 0;

                for (int i = 0; i < list.Count; i++)
                {
                    var item = list[i];

                    if (i < list.Count - 1)
                    {
                        if (list[i] < list[i+1])
                        {
                            index_end = i;
                        }
                        else
                        {
                            index_start = i+1;
                        }
                    }
                    else
                    {
                        if (list[i] > list[i-1])
                        {
                            index_end = i;
                        }
}
                    if (index_end - index_start > index_end__TheBiggestSequence - index_start__TheBiggestSequence)
                    {
                        index_start__TheBiggestSequence = index_start;
                        index_end__TheBiggestSequence = index_end;
                    }
                }


                Console.WriteLine($"Начальный индекс: {index_start__TheBiggestSequence} | Конечный индекс: {index_end__TheBiggestSequence}");

                Console.WriteLine('\n');
                for (int j = index_start__TheBiggestSequence; j <= index_end__TheBiggestSequence; j++)
                {
                    Console.Write(list[j]);
                }
            });

        }
        public static async Task ParralelMultipleDiaposone(int start, int end)// мне пришлось реализацию метода сделать синхронной, так как запись/чтения сразу с нескольких потоков невозможна
        {
            var list = Enumerable.Range(start, end).ToList();

            foreach (var item in list)
            {
                await WriteTableInFile(item); 
            }
        }

        public static async Task WriteTableInFile(int num)
        {
            var txt = await ReadTxtFile();

            var table = TableMultipleNum(num).Concat(txt);

            await File.WriteAllTextAsync(PathToTableMultiple, string.Join('\n', table));
        }
        public static List<string> TableMultipleNum(int num)
        {
            List<string> listTable = [];
            for(int i = 1; i <= 10;  i++)
            {
                listTable.Add($"{num} * {i} = {num * i}");
            }
            return listTable;
        }
    }
}
