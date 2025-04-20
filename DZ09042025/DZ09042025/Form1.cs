using System;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ09042025
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private StreamReader? reader;
        private StreamWriter? writer;

        public Form1()
        {
            InitializeComponent();
        }

        private async void connectButton_Click(object sender, EventArgs e)
        {
            string host = "127.0.0.1";
            int port = 121;
            string userName = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Введите имя пользователя.");
                return;
            }

            try
            {
                client = new TcpClient();
                await client.ConnectAsync(host, port);
                reader = new StreamReader(client.GetStream());
                writer = new StreamWriter(client.GetStream());

                await writer.WriteLineAsync(userName);
                await writer.FlushAsync();

                _ = Task.Run(() => ReceiveMessagesAsync());

                listBox1.Items.Add($"Вы вошли как {userName}");
                button1.Enabled = false;
                textBox1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex.Message}");
            }
        }

        private async Task ReceiveMessagesAsync()
        {
            while (true)
            {
                try
                {
                    string? message = await reader!.ReadLineAsync();
                    if (!string.IsNullOrEmpty(message))
                    {
                        listBox1.Items.Add(message);
                    }
                }
                catch
                {
                    break;
                }
            }
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            if (writer == null) return;

            string message = textBox2.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                await writer.WriteLineAsync(message);
                await writer.FlushAsync();
                textBox2.Clear();
            }
        }
    }
}
