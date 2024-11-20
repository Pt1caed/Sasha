namespace DZ2011
{
    internal class Program
    {
        //2


        static void Main(string[] args)
        {
            // 1
            string? message = "Hello privet kakdela";

            var SearchWord = (string message, string word) =>
            {
                message = message.ToLower();
                if (message.Contains(word))
                {
                    return true;
                }
                return false;
            };

            Console.WriteLine(SearchWord(message, "Hello"));
            // 2
            Backpack backpack = new("green", "Good", "Great", 10000, 1000, 10);

            backpack.OnBackpackAdd += item =>
            {
                Console.WriteLine($"Предмет {item.Name} был положен в рюкзак. +{item.Volume}к Volume");
            };
            backpack.OnBackpackRemove += item =>
            {
                Console.WriteLine($"Предмет {item.Name} был убран из рюкзака. -{item.Volume} к Volume");
            };

            Item item1 = new("Har", 10, 10);
            backpack.Add(item1, 1);

            // 3

            int[] massive = [-1, -2, -3, 1, 4, 5, 6];

            var sort_positive = (int[] massive) =>
            {
                int count = 0;

                for (int i = 0; i < massive.Length; i++)
                {
                    if (massive[i] > 0) { count++; }
                }
                return count;
            };

            Console.WriteLine(sort_positive(massive));
        }
    }
}
