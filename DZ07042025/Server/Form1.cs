using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Server
{
    public partial class FormServer : Form
    {
        bool isServer = false;
        string IP {  get; set; } = "127.0.0.1";
        int Port { get; set; } = 888;
        StreamReader? Reader { get; set; }
        StreamWriter? Writer { get; set; }
        public FormServer()
        {
            InitializeComponent();
        }
        private void WriteTime(string message)
        {
            if (message?.ToLower().Contains("hello") == true || message?.ToLower().Contains("привет") == true)
            {
                var hours = DateTime.Now.Hour;
                string messageWrite;
                if (hours >= 6 && hours < 12)
                {
                    messageWrite = "Доброе утро!";
                }
                else if (hours >= 12 && hours < 18)
                {
                    messageWrite = "Добрый день!";
                }
                else if (hours >= 18 && hours < 24)
                {
                    messageWrite = "Добрый вечер!";
                }
                else
                {
                    messageWrite = "Доброй ночи!";
                }
                var ip = ((NetworkStream)Writer.BaseStream).Socket.RemoteEndPoint;
                Writer?.WriteLineAsync($"{ip}: {messageWrite}");
                Writer?.Flush();
                listBox1.Items.Add($"Сервер: {messageWrite}");
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
                    Reader = new(client.GetStream());
                    Writer = new(client.GetStream());

                    ProcessClient(Reader, Writer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Reader?.Close(); Writer?.Close();
            }
            
        }
        private async Task ProcessClient(StreamReader reader, StreamWriter writer)
        {
            await Task.Run(async () => 
            {
                while (true)
                {
                    var message = await reader.ReadLineAsync();


                    if (message != null)
                    {
                        listBox1.Items.Add(message);
                        WriteTime(message);
                    }
                }
            });
           
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                isServer = true;
                button1.Enabled = false;
                await Task.Run(async () => await OpenServer());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                isServer = false;
                button1.Enabled = true;
            }
        }
    }
}
