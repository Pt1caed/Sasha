using System.Diagnostics;
using System.Net.NetworkInformation;

namespace DZ31032025
{
    public partial class Form1 : Form
    {
        private SynchronizationContext? uiContext;
        public Form1()
        {
            InitializeComponent();
            uiContext = SynchronizationContext.Current;
            timer1.Start();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            var processes = await Task.Run(() =>
            {
                uiContext?.Post(p => checkedListBox1.Items.Clear(), null);
                var list = Process.GetProcesses();
                List<Process?> listProcesses = [];

                checkedListBox1.Items.Clear();
                foreach (var process in list)
                {
                    checkedListBox1.Items.Add(new ProcessAndName() { Process = process });
                }
                return listProcesses;
            });
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                var listCheckedProcesses = checkedListBox1.CheckedItems.Cast<ProcessAndName>().Select(p => p.Process).ToList();

                foreach (var process in listCheckedProcesses)
                {
                    process.Kill();
                }
                button1_Click(sender, e);
            });
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                var adapters = NetworkInterface.GetAllNetworkInterfaces();
                var list = adapters.AsParallel().Select(p =>
                    $"Name: {p.Name} Id: {p.Id}\nDescription: {p.Description}\nTypeInterface: {p.NetworkInterfaceType}\nPhysical Address: {p.GetPhysicalAddress().ToString()}"
                ).ToList();

                uiContext?.Post(p =>
                {
                    listBox1.Items.Clear();
                    listBox1.DrawMode = DrawMode.OwnerDrawVariable;
                    listBox1.MeasureItem += (s, e) =>
                    {
                        var text = list[e.Index];
                        var lines = text.Split('\n');
                        e.ItemHeight = lines.Length * 20;
                    };

                    listBox1.DrawItem += (s, e) =>
                    {
                        if (e.Index >= 0)
                        {
                            e.DrawBackground();
                            var text = list[e.Index];
                            var lines = text.Split('\n');
                            for (int i = 0; i < lines.Length; i++)
                            {
                                e.Graphics.DrawString(lines[i], e.Font, Brushes.Black, e.Bounds.Left, e.Bounds.Top + (i * 20));
                            }
                        }
                    };

                    foreach (var adapter in list)
                    {
                        listBox1.Items.Add(adapter);
                    }
                }, null);
            });
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var ipProps = IPGlobalProperties.GetIPGlobalProperties();
            var ipStats = ipProps.GetIPv4GlobalStatistics();

            ReceivedPackets.Text = $"Входящие пакеты: {ipStats.ReceivedPackets}";
            OutputPacketRequests.Text = $"Исходящие пакеты: {ipStats.OutputPacketRequests}";
            ReceivedPacketsDiscarded.Text = $"Отброшено входящих пакетов: {ipStats.ReceivedPacketsDiscarded}";
            OutputPacketsDiscarded.Text = $"Отброшено исходящих пакетов: {ipStats.OutputPacketsDiscarded}";
        }
    }
}
