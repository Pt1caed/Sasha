using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ServerForm
{
    internal class ClientObject
    {
        protected internal string Id { get; } = Guid.NewGuid().ToString();
        protected internal StreamWriter? Writer { get; }
        protected internal StreamReader? Reader { get; }
        TcpClient? Client { get; set; }
        ServerObject? Server { get; set; }
        public ClientObject(TcpClient tcpClient, ServerObject serverObject)
        {
            Client = tcpClient;
            Server = serverObject;
            var stream = Client.GetStream();
            Reader = new StreamReader(stream);
            Writer = new StreamWriter(stream);
        }
        public async Task StartClientAsync()
        {
            var username = Reader?.ReadLineAsync();
            string? message = $"Поприветствуем {username} в чате!";
            try
            {
                while (true)
                {
                    try
                    {
                        message = await Reader.ReadLineAsync();
                        if (message == null) continue;
                        message = $"({username}): {message}";
                        await Server.BroadcastMessageAsync(message, Id);
                    }
                    catch
                    {
                        message = $"{username} покинул чат";
                        Console.WriteLine(message);
                        await Server.BroadcastMessageAsync(message, Id);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Server.RemoveConnection(Id);
            }
        }
        protected internal void Close()
        {
            Writer?.Close();
            Reader?.Close();
            Client?.Close();
        }
    }
}
