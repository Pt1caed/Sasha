using System.Net.Sockets;
using System.Net;

namespace ServerForm
{
    public partial class Form1 : Form
    {
        ServerObject Server { get; set; } = new();
        public Form1()
        {
            InitializeComponent();
            Server.AddList += AddToList;
        }
        private void AddToList(object obj)
        {
            listBox1.Items.Add(obj);
        }

        
        private async void button1_Click(object sender, EventArgs e)
        {
            await Server.ListenAsync();
        }
        private async Task StartServer()
        {

        }
    }
    internal class ServerObject
    {
        TcpListener tcpListener { get; set; } = new TcpListener(IPAddress.Parse("127.0.0.1"), 121);
        List<ClientObject> clients { get; set; } = new List<ClientObject>();
        public Action<object> AddList { get; set; }
        protected internal async Task BroadcastMessageAsync(string message, string id)
        {
            AddList.Invoke(message);
            foreach (var client in clients)
            {
                await client.Writer.WriteLineAsync(message);
                await client.Writer.FlushAsync();
            }
        }
        protected internal void Disconnect()
        {
            foreach (var client in clients)
            {
                client.Close(); 
            }
            tcpListener.Stop();
        }
        protected internal async Task ListenAsync()
        {
            try
            {
                tcpListener.Start();
                AddList.Invoke("Сервер запущен. Ожидание подключений...");

                while (true)
                {
                    TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync();

                    ClientObject clientObject = new ClientObject(tcpClient, this);
                    clients.Add(clientObject);
                    Task.Run(clientObject.StartClientAsync);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
        protected internal void RemoveConnection(string id)
        {
            ClientObject? client = clients.FirstOrDefault(c => c.Id == id);
            if (client != null) clients.Remove(client);
            client?.Close();
        }
    }
}
