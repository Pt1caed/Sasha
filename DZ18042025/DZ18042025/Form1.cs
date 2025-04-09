using System.Net.Sockets;
using System.Net;
using System.Text;

namespace DZ18042025
{
    public partial class Form1 : Form
    {
        Client client { get; set; }
        public Form1()
        {
            InitializeComponent();
            client = new();
            client.WriteMessage += Client_WriteMessage;
            client.ReadMessage += Client_ReadMessage; ;
        }

        private List<string> Client_ReadMessage()
        {
            return [textBoxEntryName.Text, textBoxSend.Text];
        }

        private void Client_WriteMessage(string obj)
        {
            listBoxChat.Items.Add(obj);
        }

        private async void buttonEntryName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEntryName.Text)) return;

            buttonEntryName.Enabled = false;
            client.Connect(textBoxEntryName.Text);
            textBoxEntryName.ReadOnly = true;
            await Task.Run(async () => await client.ReceiveMessageAsync());
        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            await Task.Run(async () => await client.SendMessageAsync());

        }

        private void buttonPort_Click(object sender, EventArgs e)
        {
            buttonPort.Enabled = false;
            client.PortSend = (int)numericUpDown1.Value;
        }
    }
}
