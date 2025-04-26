using System.Text;

namespace DZ21042025
{
    public partial class Form1 : Form
    {
        HttpClient Client { get; set; } = new();
        SynchronizationContext? uiContext;
        public Form1()
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
            uiContext = SynchronizationContext.Current;
        }
        private static readonly HttpClient httpClient = new();


        public async Task<Book> GetHttpFromUrlReturnBook(string url)
        {
            var response = await httpClient.GetAsync(url);
            var stream = await response.Content.ReadAsStreamAsync();

            using StreamReader sr = new(stream);
            var text = await sr.ReadToEndAsync();

            Book book = new()
            {
                Text = text
            };

            var index = text.IndexOf("Title:");
            book.Title = FindSymbol(index, '\n', text);

            index = text.IndexOf("Author:");
            book.Author = FindSymbol(index, '\n', text);

            return book;
        }

        public async Task GetHttpFromUrl(string url)
        {
            var response = await httpClient.GetAsync(url);
            var stream = await response.Content.ReadAsStreamAsync();

            using StreamReader sr = new(stream);
            var text = await sr.ReadToEndAsync();

            uiContext?.Send(_ =>
            {
                richTextBox1.Text = text;
                var index = text.IndexOf("Title:");
                labelName.Text = FindSymbol(index, '\n', text);

                index = text.IndexOf("Author:");
                labelAuthor.Text = FindSymbol(index, '\n', text);
            }, null);
        }

        private string? FindSymbol(int indexStart, char toSymbol, string text)
        {
            if (indexStart < 0 || indexStart >= text.Length)
                return null;

            StringBuilder builder = new();
            while (indexStart < text.Length && text[indexStart] != toSymbol)
            {
                builder.Append(text[indexStart]);
                indexStart++;
            }
            return builder.ToString();
        }


        private async void timer1_Tick(object sender, EventArgs e)
        {
            await GetHttpFromUrl(@"");
            timer1.Stop();
        }
        // метод для парсинга страницы по определенному тегу.
        // Для парсинга есть более лучшие библиотеки, но я не думаю,
        // что их можно тут использовать, так что попытался в лоб
        public static async Task<List<string>> ParsingHtmlForTeg(string tegStart, string tegEnd, string htmlCode)
        {
            return await Task.Run(() =>
            {
                List<string> list = new List<string>();
                int? index_start = null;
                for (int i = 0; i <= htmlCode.Length - tegEnd.Length; i++)
                {
                    if (htmlCode[i..(i + tegStart.Length)] == tegStart)
                    {
                        index_start = i + tegStart.Length;
                    }
                    else if (htmlCode[i..(i + tegEnd.Length)] == tegEnd && index_start != null)
                    {
                        StringBuilder massive = new();
                        for (int? j = index_start; j <= i - 1; j++)
                        {
                            massive.Append(htmlCode[(int)j]);
                        }
                        index_start = null;
                        list.Add(massive.ToString());
                    }
                }
                return list;
            });
        }
        public async Task LoadBooks(int startId, int endId)
        {
            if (startId < 0 || endId < 0) return;
            if (startId > endId) (startId, endId) = (endId, startId);

            var tasks = new List<Task>();
            var list = new List<Book>();

            for (int i = startId; i <= endId; i++)
            {
                int localI = i;
                tasks.Add(Task.Run(async () =>
                {
                    var book = await GetHttpFromUrlReturnBook($"https://www.gutenberg.org/cache/epub/{localI}/pg{localI}.txt");
                    book.Id = localI;

                    lock (list)
                    {
                        list.Add(book);
                    }

                    uiContext?.Send(_ => labelTop100.Text = $"Loading...{list.Count}", null);
                }));
            }

            await Task.WhenAll(tasks);

            list = list.OrderBy(p => p.Id).ToList();

            uiContext?.Send(_ =>
            {
                comboBox1.Items.AddRange([.. list]);
                labelTop100.Text = "Loaded!";
            }, null);
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            int Id;
            if(!int.TryParse(textBox1.Text, out Id)) { return; }
            await GetHttpFromUrl($"https://www.gutenberg.org/cache/epub/{Id}/pg{Id}.txt");
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {

                var book = comboBox1.SelectedItem as Book;
                labelAuthor.Text = book?.Author;
                labelName.Text = book?.Title;
                richTextBox1.Text = book?.Text;
                labelId.Text = $"Id: {book?.Id}";
            });
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            int maxId = 100;
            buttonLoadOneHundredBooks.Enabled = false;
            await LoadBooks(1, maxId);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
