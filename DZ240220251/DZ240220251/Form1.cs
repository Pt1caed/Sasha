namespace DZ240220251
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            comboBox1.Items.AddRange(new object[]
            {
                new Bank() { Name = "ПриватБанк", Money = 10000, Percent = 10},
                new Bank() { Name = "МоноБанк", Money = 5000, Percent = 5 },
                new Bank() { Name = "Яблоко", Money = 2000, Percent= 20 }
            });
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bank bank = (Bank)comboBox1.SelectedItem;

            Task task1 = Task.Factory.StartNew(() =>
            {
                LabelNameBank.Text = bank?.Name;
                LabelMoneyBank.Text = bank?.Money.ToString();
                LabelPercentBank.Text = bank?.Percent.ToString();
            });
        }

        private void ButtonEditBank_Click(object sender, EventArgs e)
        {
            Task task1 = Task.Factory.StartNew(() =>
            {
                if (int.TryParse(textBoxChangeMoney.Text, out int money) && int.TryParse(textBoxChangePercent.Text, out int percent))
                {
                    int index = comboBox1.SelectedIndex;
                    comboBox1.Items[index] = new Bank { Name = LabelNameBank.Text, Money = money, Percent = percent };
                }
            });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LabelTime.Text = DateTime.Now.ToString();
        }
    }
}
