namespace DZ240220251
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            comboBox1 = new ComboBox();
            LabelNameBank = new Label();
            LabelMoneyBank = new Label();
            LabelPercentBank = new Label();
            textBoxChangeMoney = new TextBox();
            textBoxChangePercent = new TextBox();
            ButtonEditBank = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            LabelTime = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(82, 92);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // LabelNameBank
            // 
            LabelNameBank.AutoSize = true;
            LabelNameBank.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            LabelNameBank.ForeColor = Color.Yellow;
            LabelNameBank.Location = new Point(82, 52);
            LabelNameBank.Name = "LabelNameBank";
            LabelNameBank.Size = new Size(47, 25);
            LabelNameBank.TabIndex = 1;
            LabelNameBank.Text = "имя";
            // 
            // LabelMoneyBank
            // 
            LabelMoneyBank.AutoSize = true;
            LabelMoneyBank.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            LabelMoneyBank.ForeColor = Color.Yellow;
            LabelMoneyBank.Location = new Point(82, 180);
            LabelMoneyBank.Name = "LabelMoneyBank";
            LabelMoneyBank.Size = new Size(58, 20);
            LabelMoneyBank.TabIndex = 2;
            LabelMoneyBank.Text = "деньги";
            // 
            // LabelPercentBank
            // 
            LabelPercentBank.AutoSize = true;
            LabelPercentBank.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            LabelPercentBank.ForeColor = Color.Yellow;
            LabelPercentBank.Location = new Point(250, 180);
            LabelPercentBank.Name = "LabelPercentBank";
            LabelPercentBank.Size = new Size(82, 20);
            LabelPercentBank.TabIndex = 3;
            LabelPercentBank.Text = "проценты";
            // 
            // textBoxChangeMoney
            // 
            textBoxChangeMoney.Location = new Point(78, 217);
            textBoxChangeMoney.Name = "textBoxChangeMoney";
            textBoxChangeMoney.Size = new Size(100, 23);
            textBoxChangeMoney.TabIndex = 4;
            // 
            // textBoxChangePercent
            // 
            textBoxChangePercent.Location = new Point(250, 217);
            textBoxChangePercent.Name = "textBoxChangePercent";
            textBoxChangePercent.Size = new Size(100, 23);
            textBoxChangePercent.TabIndex = 5;
            // 
            // ButtonEditBank
            // 
            ButtonEditBank.Location = new Point(82, 292);
            ButtonEditBank.Name = "ButtonEditBank";
            ButtonEditBank.Size = new Size(134, 55);
            ButtonEditBank.TabIndex = 6;
            ButtonEditBank.Text = "Изменить данные банка";
            ButtonEditBank.UseVisualStyleBackColor = true;
            ButtonEditBank.Click += ButtonEditBank_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // LabelTime
            // 
            LabelTime.AutoSize = true;
            LabelTime.Font = new Font("Segoe UI", 15F);
            LabelTime.ForeColor = Color.Yellow;
            LabelTime.Location = new Point(298, 21);
            LabelTime.Name = "LabelTime";
            LabelTime.Size = new Size(65, 28);
            LabelTime.TabIndex = 7;
            LabelTime.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelTime);
            Controls.Add(ButtonEditBank);
            Controls.Add(textBoxChangePercent);
            Controls.Add(textBoxChangeMoney);
            Controls.Add(LabelPercentBank);
            Controls.Add(LabelMoneyBank);
            Controls.Add(LabelNameBank);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label LabelNameBank;
        private Label LabelMoneyBank;
        private Label LabelPercentBank;
        private TextBox textBoxChangeMoney;
        private TextBox textBoxChangePercent;
        private Button ButtonEditBank;
        private System.Windows.Forms.Timer timer1;
        private Label LabelTime;
    }
}
