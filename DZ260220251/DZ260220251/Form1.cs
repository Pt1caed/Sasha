namespace DZ260220251
{
    public partial class Form1 : Form
    {
        SynchronizationContext? uiContext;
        int countPlayers { get; set; } = 0;
        private static readonly Random random = new();
        public Form1()
        {
            InitializeComponent();
            uiContext = SynchronizationContext.Current;
            countPlayers = 6;
        }
        public async Task Run()
        {
            List<Task> tasks = [];
            for (int i = 1; i <= countPlayers; i++)
            {
                int playerId = i;
                tasks.Add(Task.Run(async () =>
                {
                    while (true)
                    {
                        RunPlayer(playerId);
                        if (CheckPlayer(playerId))
                        {
                            break;
                        }
                        await Task.Delay(10);
                    }
                }));
            }
            await Task.WhenAll(tasks);

        }
        public void RunPlayer(int i)
        {
            if (groupBox1?.Controls?[$"progressBar{i}"] is ProgressBar progressBar)
            {
                progressBar.Value = Math.Min(progressBar.Maximum, progressBar.Value + random.Next(1, 15) / 10);
            }
        }
        public bool CheckPlayer(int i)
        {
            var player = ((ProgressBar?)groupBox1.Controls[$"progressBar{i}"]);

            if (player?.Value >= player?.Maximum)
            {
                listBox1.Items.Add($"{listBox1.Items.Count + 1}. {groupBox1?.Controls?[$"labelPlayer{i}"]?.Text}");
                return true;
            }
            return false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(Run);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
 }
