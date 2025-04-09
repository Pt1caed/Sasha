using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DZ18042025
{
    internal class Client
    {
        int localPort { get; set; } = 5321;
        public int PortSend { get; set; } = 5321;
        IPAddress BroadcastAddress { get; set; }
        public string Name { get; set; }
        public event Action<string> WriteMessage;
        public event Func<List<string>> ReadMessage;
        public Client()
        {
            BroadcastAddress = IPAddress.Parse("224.0.0.0");
        }
        public void Connect(string name)
        {
            if (string.IsNullOrEmpty(name)) return;
            Name = name;
            WriteMessage?.Invoke("Твоё имя: " + Name);
        }
        public async Task ReceiveMessageAsync()
        {
            await Task.Run(async () => 
            {
                using var receiver = new UdpClient(5321);
                receiver.JoinMulticastGroup(BroadcastAddress);

                receiver.MulticastLoopback = true;
                while (true)
                {
                    var result = await receiver.ReceiveAsync();
                    string message = Encoding.UTF8.GetString(result.Buffer);

                    WriteMessage?.Invoke($"{message} <- ({result.RemoteEndPoint.ToString()})");
                }
            });
        }
        public async Task SendMessageAsync()
        {
            await Task.Run(async () => 
            {
                using var sender = new UdpClient();

                var messageList = ReadMessage.Invoke();

                if (messageList.Count != 2 || string.IsNullOrEmpty(messageList[1])) return;
                string message = $"{messageList[0]}: {messageList[1]}";
                byte[] data = Encoding.UTF8.GetBytes(message);
                await sender.SendAsync(data, new IPEndPoint(BroadcastAddress, PortSend));
            });
        }
    }
}
