namespace DZ24022025
{
    public partial class Form1 : Form
    {
        public SynchronizationContext uiContext = null!;
        Thread thread = null!;
        List<Product> list = new List<Product>
            {
                new Product { Name = "Хот-дог", Price = 60 },
                new Product { Name = "Гамбургер", Price = 80 },
                new Product { Name = "Шаурма", Price = 120 },
                new Product { Name = "Пепперони", Price = 200 }
            };
        public Form1()
        {

            InitializeComponent();
            comboBoxBenzine.Items.Add(new Product { Name = "АИ-98", Price = 70 });
            comboBoxBenzine.Items.Add(new Product { Name = "АИ-95", Price = 55 });
            comboBoxBenzine.Items.Add(new Product { Name = "АИ-91", Price = 40 });

            comboBoxBenzine.SelectedIndex = 0;
            timer1.Start();

            if (SynchronizationContext.Current != null)
                uiContext = SynchronizationContext.Current;

            InitializeCafe(list);
            timer2.Start();
            timer3.Start();
        }

        private void InitializeCafe(List<Product> products)
        {
            if (products.Count >= 4)
            {
                int iterator = 1;
                foreach (Product product in products)
                {
                    ((CheckBox)GroupBoxMiniCafe.Controls[$"checkBoxMiniCafe{iterator}"]).Text = product.Name;
                    ((GroupBox)GroupBoxMiniCafe.Controls[$"groupBoxMiniCafe{iterator}"]).Controls[$"LabelMiniCafe{iterator}"].Text = product.Price.ToString();
                    iterator++;
                }
            }
        }

        private void MiniCafeSale()
        {
            double price = 0;
            if (list.Count >= 4)
            {
                for (int i = 1; i <= list.Count; i++)
                {
                    if (((CheckBox)GroupBoxMiniCafe.Controls[$"checkBoxMiniCafe{i}"]).Checked)
                    {
                        uiContext.Send(p => price += (double)p,
                            Convert.ToDouble(((NumericUpDown)GroupBoxMiniCafe.Controls[$"MiniCafeNumericUpDown{i}"]).Value)
                            * Convert.ToDouble(((GroupBox)GroupBoxMiniCafe.Controls[$"groupBoxMiniCafe{i}"]).Controls[$"LabelMiniCafe{i}"].Text));
                    }
                }
            }
            uiContext.Send(p => LabelMiniCafeCost.Text = p.ToString(), price);
        }

        private void comboBoxBenzine_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product benzine = (Product)comboBoxBenzine.SelectedItem;
            CostBenzin.Text = benzine.Price.ToString();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Enabled)
            {
                textBox1.Enabled = false;
            }
            else { textBox1.Enabled = true; }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.Enabled)
            {
                textBox2.Enabled = false;
            }
            else { textBox2.Enabled = true; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int costBenzine = Convert.ToInt32(CostBenzin.Text);
            if (radioButtonCount.Checked)
            {
                if (int.TryParse(textBox1.Text, out int value))
                {
                    LabelGasStationCost.Text = (costBenzine * value).ToString();
                }
            }
            else
            {
                if (int.TryParse(textBox2.Text, out int value))
                {
                    LabelGasStationCost.Text = value.ToString();
                }
            }
        }

        private void MiniCafeNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ThreadStart ts = new ThreadStart(MiniCafeSale);

            thread = new Thread(ts);
            thread.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            LabelTime.Text = DateTime.Now.ToString();
        }

        private void ButtonPay_Click(object sender, EventArgs e)
        {
            if (LabelAllCost.Text != "0")
            {
                MessageBox.Show($"Вы успешно оплатили товар! Ваш чек составил: {LabelAllCost.Text}", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Вам пока нечего оплачивать.", "Подумайте ещё...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            uiContext.Send(p => LabelAllCost.Text = p?.ToString(), Convert.ToDouble(LabelGasStationCost.Text) + Convert.ToDouble(LabelMiniCafeCost.Text));
        }
    }
}
