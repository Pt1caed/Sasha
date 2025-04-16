using System.Net.Sockets;

namespace Client
{
    public partial class Form1 : Form
    {
        string IP { get; set; } = "127.0.0.1";
        int Port { get; set; } = 888;

        StreamReader? Reader { get; set; }
        StreamWriter? Writer { get; set; }
        TcpClient Client { get; set; } = new();
        bool isReceiving = false;

        public Form1()
        {
            InitializeComponent();

            Client.Connect(IP, Port);
            var stream = Client.GetStream();

            Writer = new StreamWriter(stream) { AutoFlush = true };
            Reader = new StreamReader(stream);
        }

        private async Task clientSendMessage()
        {
            if (!isReceiving)
            {
                isReceiving = true;
                _ = CheckNewMessages(); 
            }

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                await Writer!.WriteLineAsync(textBox1.Text);
                listBox1.Items.Add($"Я: {textBox1.Text}");
            }
        }

        private async Task CheckNewMessages()
        {
            while (true)
            {
                var message = await Reader?.ReadLineAsync();
                if (!string.IsNullOrEmpty(message))
                {
                    listBox1.Invoke(() => listBox1.Items.Add($"Сервер: {message}"));
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await clientSendMessage();
            textBox1.Text = "";
        }
    }
}
