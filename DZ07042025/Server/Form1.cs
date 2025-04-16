using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Server
{
    public partial class FormServer : Form
    {
        string IP { get; set; } = "127.0.0.1";
        int Port { get; set; } = 888;

        public FormServer()
        {
            InitializeComponent();
        }

        private void WriteRate(string message, StreamWriter writer)
        {
            var list = message.Split(' ');
            if (list.Length < 3) return;

            if (int.TryParse(list[2], out int count))
            {
                var rate = CurrencyRate.ExchangeValute(list[0], list[1], count);
                writer.WriteLine(rate.ToString());
                listBox1.Invoke(() => listBox1.Items.Add($"Ответ: {rate}"));
            }
        }

        private async Task OpenServer()
        {
            try
            {
                TcpListener server = new(IPAddress.Parse(IP), Port);
                server.Start();

                while (true)
                {
                    var client = await server.AcceptTcpClientAsync();
                    var a = Task.Run(async () =>
                    {
                        using var stream = client.GetStream();
                        using var reader = new StreamReader(stream);
                        using var writer = new StreamWriter(stream) { AutoFlush = true };
                        await ProcessClient(reader, writer);
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task ProcessClient(StreamReader reader, StreamWriter writer)
        {
            while (true)
            {
                var message = await reader.ReadLineAsync();
                if (message != null)
                {
                    listBox1.Invoke(() => listBox1.Items.Add($"Клиент: {message}"));
                    WriteRate(message, writer);
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            await OpenServer();
        }
    }
}
