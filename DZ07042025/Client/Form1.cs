using System.Net.Sockets;

namespace Client
{
    public partial class Form1 : Form
    {
        bool isOn = false;
        string IP { get; set; } = "127.0.0.1";
        int Port { get; set; } = 888;
        StreamReader? Reader { get; set; }
        StreamWriter? Writer { get; set; }
        TcpClient Client { get; set; } = new();
        public Form1()
        {
            InitializeComponent();
            Client.Connect(IP, Port);

            Writer = new(Client.GetStream());
            Reader = new(Client.GetStream());
        }
        private async Task<string?> clientSendMessage()
        {
            if(isOn == false)
            {
                isOn = true;
                CheckNewMessages();
            }
            Writer = new(Client.GetStream());
            var ip = ((NetworkStream)Writer.BaseStream).Socket.RemoteEndPoint;
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Writer.WriteLine($"{ip}: {textBox1.Text}");
                Writer.Flush();
                listBox1.Items.Add($"ß: {textBox1.Text}");
            }
            Reader = new(Client.GetStream());
            return await Reader.ReadLineAsync();
        }
        private async Task CheckNewMessages()
        {
            while (true)
            {
                var message = await Reader?.ReadLineAsync();

                if(!String.IsNullOrEmpty(message))
                    listBox1.Items.Add(message);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var messageFromServer = await Task.Run(async () => { return await clientSendMessage(); });
            listBox1.Items.Add(messageFromServer);
            textBox1.Text = "";
        }
    }
}
