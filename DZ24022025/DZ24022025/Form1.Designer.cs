namespace DZ24022025
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
            label2 = new Label();
            comboBoxBenzine = new ComboBox();
            radioButtonSum = new RadioButton();
            radioButtonCount = new RadioButton();
            textBox1 = new TextBox();
            CostBenzin = new Label();
            textBox2 = new TextBox();
            LabelGasStationCost = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1 = new GroupBox();
            groupBox6 = new GroupBox();
            label10 = new Label();
            groupBox5 = new GroupBox();
            label7 = new Label();
            LabelPriceLiterBenzine = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ButtonPay = new Button();
            label13 = new Label();
            LabelAllCost = new Label();
            LabelTime = new Label();
            GroupBoxMiniCafe = new GroupBox();
            MiniCafeNumericUpDown4 = new NumericUpDown();
            MiniCafeNumericUpDown3 = new NumericUpDown();
            MiniCafeNumericUpDown2 = new NumericUpDown();
            MiniCafeNumericUpDown1 = new NumericUpDown();
            groupBoxMiniCafe4 = new GroupBox();
            LabelMiniCafe4 = new Label();
            groupBoxMiniCafe3 = new GroupBox();
            LabelMiniCafe3 = new Label();
            groupBoxMiniCafe2 = new GroupBox();
            LabelMiniCafe2 = new Label();
            groupBoxMiniCafe1 = new GroupBox();
            LabelMiniCafe1 = new Label();
            checkBoxMiniCafe4 = new CheckBox();
            checkBoxMiniCafe3 = new CheckBox();
            checkBoxMiniCafe2 = new CheckBox();
            checkBoxMiniCafe1 = new CheckBox();
            groupBox7 = new GroupBox();
            label11 = new Label();
            LabelMiniCafeCost = new Label();
            label8 = new Label();
            label6 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            timer3 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            GroupBoxMiniCafe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MiniCafeNumericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MiniCafeNumericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MiniCafeNumericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MiniCafeNumericUpDown1).BeginInit();
            groupBoxMiniCafe4.SuspendLayout();
            groupBoxMiniCafe3.SuspendLayout();
            groupBoxMiniCafe2.SuspendLayout();
            groupBoxMiniCafe1.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(15, 41);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Бензин";
            // 
            // comboBoxBenzine
            // 
            comboBoxBenzine.FormattingEnabled = true;
            comboBoxBenzine.Location = new Point(62, 38);
            comboBoxBenzine.Name = "comboBoxBenzine";
            comboBoxBenzine.Size = new Size(78, 23);
            comboBoxBenzine.TabIndex = 2;
            comboBoxBenzine.SelectedIndexChanged += comboBoxBenzine_SelectedIndexChanged;
            // 
            // radioButtonSum
            // 
            radioButtonSum.AutoSize = true;
            radioButtonSum.ForeColor = Color.AliceBlue;
            radioButtonSum.Location = new Point(6, 64);
            radioButtonSum.Name = "radioButtonSum";
            radioButtonSum.Size = new Size(54, 19);
            radioButtonSum.TabIndex = 1;
            radioButtonSum.TabStop = true;
            radioButtonSum.Text = "Сума";
            radioButtonSum.UseVisualStyleBackColor = true;
            radioButtonSum.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButtonCount
            // 
            radioButtonCount.AutoSize = true;
            radioButtonCount.ForeColor = Color.AliceBlue;
            radioButtonCount.Location = new Point(6, 22);
            radioButtonCount.Name = "radioButtonCount";
            radioButtonCount.Size = new Size(74, 19);
            radioButtonCount.TabIndex = 0;
            radioButtonCount.TabStop = true;
            radioButtonCount.Text = "Кількість";
            radioButtonCount.UseVisualStyleBackColor = true;
            radioButtonCount.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Enabled = false;
            textBox1.Location = new Point(110, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // CostBenzin
            // 
            CostBenzin.Anchor = AnchorStyles.None;
            CostBenzin.AutoSize = true;
            CostBenzin.Font = new Font("Segoe UI", 10F);
            CostBenzin.ForeColor = SystemColors.ButtonFace;
            CostBenzin.Location = new Point(6, 17);
            CostBenzin.Name = "CostBenzin";
            CostBenzin.Size = new Size(97, 19);
            CostBenzin.TabIndex = 3;
            CostBenzin.Text = "Цена бензина";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Enabled = false;
            textBox2.Location = new Point(110, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // LabelGasStationCost
            // 
            LabelGasStationCost.AutoSize = true;
            LabelGasStationCost.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            LabelGasStationCost.ForeColor = SystemColors.ActiveCaption;
            LabelGasStationCost.Location = new Point(9, 24);
            LabelGasStationCost.Name = "LabelGasStationCost";
            LabelGasStationCost.Size = new Size(33, 37);
            LabelGasStationCost.TabIndex = 6;
            LabelGasStationCost.Text = "0";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(LabelPriceLiterBenzine);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBoxBenzine);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.ForeColor = SystemColors.ActiveCaption;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 314);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Автозаправка";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label10);
            groupBox6.Controls.Add(LabelGasStationCost);
            groupBox6.Font = new Font("Segoe UI", 10F);
            groupBox6.ForeColor = Color.Cyan;
            groupBox6.Location = new Point(6, 235);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(238, 73);
            groupBox6.TabIndex = 13;
            groupBox6.TabStop = false;
            groupBox6.Text = "До сплати";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(203, 40);
            label10.Name = "label10";
            label10.Size = new Size(33, 19);
            label10.TabIndex = 14;
            label10.Text = "грн.";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(CostBenzin);
            groupBox5.Controls.Add(label7);
            groupBox5.Location = new Point(62, 67);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(148, 48);
            groupBox5.TabIndex = 12;
            groupBox5.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(-39, 40);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 11;
            label7.Text = "label6";
            // 
            // LabelPriceLiterBenzine
            // 
            LabelPriceLiterBenzine.AutoSize = true;
            LabelPriceLiterBenzine.Location = new Point(18, 88);
            LabelPriceLiterBenzine.Name = "LabelPriceLiterBenzine";
            LabelPriceLiterBenzine.Size = new Size(32, 15);
            LabelPriceLiterBenzine.TabIndex = 11;
            LabelPriceLiterBenzine.Text = "Ціна";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(215, 100);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 10;
            label5.Text = "грн.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 191);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 9;
            label4.Text = "грн.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 151);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 8;
            label1.Text = "л.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonCount);
            groupBox2.Controls.Add(radioButtonSum);
            groupBox2.ForeColor = SystemColors.GrayText;
            groupBox2.Location = new Point(6, 125);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(98, 100);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ButtonPay);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(LabelAllCost);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox3.ForeColor = Color.Yellow;
            groupBox3.Location = new Point(12, 341);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(328, 100);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "ВСЬОГО до оплати";
            // 
            // ButtonPay
            // 
            ButtonPay.BackColor = Color.Cyan;
            ButtonPay.ForeColor = Color.Black;
            ButtonPay.Location = new Point(12, 29);
            ButtonPay.Name = "ButtonPay";
            ButtonPay.Size = new Size(122, 57);
            ButtonPay.TabIndex = 16;
            ButtonPay.Text = "Сплатити";
            ButtonPay.UseVisualStyleBackColor = false;
            ButtonPay.Click += ButtonPay_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(268, 65);
            label13.Name = "label13";
            label13.Size = new Size(41, 21);
            label13.TabIndex = 15;
            label13.Text = "грн.";
            // 
            // LabelAllCost
            // 
            LabelAllCost.AutoSize = true;
            LabelAllCost.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            LabelAllCost.ForeColor = SystemColors.ActiveCaption;
            LabelAllCost.Location = new Point(140, 29);
            LabelAllCost.Name = "LabelAllCost";
            LabelAllCost.Size = new Size(46, 54);
            LabelAllCost.TabIndex = 15;
            LabelAllCost.Text = "0";
            // 
            // LabelTime
            // 
            LabelTime.AutoSize = true;
            LabelTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LabelTime.ForeColor = Color.Gold;
            LabelTime.Location = new Point(206, 329);
            LabelTime.Name = "LabelTime";
            LabelTime.Size = new Size(54, 19);
            LabelTime.TabIndex = 0;
            LabelTime.Text = "Время";
            // 
            // GroupBoxMiniCafe
            // 
            GroupBoxMiniCafe.Controls.Add(MiniCafeNumericUpDown4);
            GroupBoxMiniCafe.Controls.Add(MiniCafeNumericUpDown3);
            GroupBoxMiniCafe.Controls.Add(MiniCafeNumericUpDown2);
            GroupBoxMiniCafe.Controls.Add(MiniCafeNumericUpDown1);
            GroupBoxMiniCafe.Controls.Add(groupBoxMiniCafe4);
            GroupBoxMiniCafe.Controls.Add(groupBoxMiniCafe3);
            GroupBoxMiniCafe.Controls.Add(groupBoxMiniCafe2);
            GroupBoxMiniCafe.Controls.Add(groupBoxMiniCafe1);
            GroupBoxMiniCafe.Controls.Add(checkBoxMiniCafe4);
            GroupBoxMiniCafe.Controls.Add(checkBoxMiniCafe3);
            GroupBoxMiniCafe.Controls.Add(checkBoxMiniCafe2);
            GroupBoxMiniCafe.Controls.Add(checkBoxMiniCafe1);
            GroupBoxMiniCafe.Controls.Add(groupBox7);
            GroupBoxMiniCafe.Controls.Add(label8);
            GroupBoxMiniCafe.Controls.Add(label6);
            GroupBoxMiniCafe.ForeColor = SystemColors.ActiveCaption;
            GroupBoxMiniCafe.Location = new Point(295, 12);
            GroupBoxMiniCafe.Name = "GroupBoxMiniCafe";
            GroupBoxMiniCafe.Size = new Size(258, 314);
            GroupBoxMiniCafe.TabIndex = 10;
            GroupBoxMiniCafe.TabStop = false;
            GroupBoxMiniCafe.Text = "МініКафе";
            // 
            // MiniCafeNumericUpDown4
            // 
            MiniCafeNumericUpDown4.Location = new Point(164, 169);
            MiniCafeNumericUpDown4.Name = "MiniCafeNumericUpDown4";
            MiniCafeNumericUpDown4.Size = new Size(60, 23);
            MiniCafeNumericUpDown4.TabIndex = 26;
            MiniCafeNumericUpDown4.ValueChanged += MiniCafeNumericUpDown1_ValueChanged;
            // 
            // MiniCafeNumericUpDown3
            // 
            MiniCafeNumericUpDown3.Location = new Point(164, 128);
            MiniCafeNumericUpDown3.Name = "MiniCafeNumericUpDown3";
            MiniCafeNumericUpDown3.Size = new Size(60, 23);
            MiniCafeNumericUpDown3.TabIndex = 25;
            MiniCafeNumericUpDown3.ValueChanged += MiniCafeNumericUpDown1_ValueChanged;
            // 
            // MiniCafeNumericUpDown2
            // 
            MiniCafeNumericUpDown2.Location = new Point(164, 88);
            MiniCafeNumericUpDown2.Name = "MiniCafeNumericUpDown2";
            MiniCafeNumericUpDown2.Size = new Size(60, 23);
            MiniCafeNumericUpDown2.TabIndex = 24;
            MiniCafeNumericUpDown2.ValueChanged += MiniCafeNumericUpDown1_ValueChanged;
            // 
            // MiniCafeNumericUpDown1
            // 
            MiniCafeNumericUpDown1.Location = new Point(163, 47);
            MiniCafeNumericUpDown1.Name = "MiniCafeNumericUpDown1";
            MiniCafeNumericUpDown1.Size = new Size(60, 23);
            MiniCafeNumericUpDown1.TabIndex = 23;
            MiniCafeNumericUpDown1.ValueChanged += MiniCafeNumericUpDown1_ValueChanged;
            // 
            // groupBoxMiniCafe4
            // 
            groupBoxMiniCafe4.Controls.Add(LabelMiniCafe4);
            groupBoxMiniCafe4.Location = new Point(95, 159);
            groupBoxMiniCafe4.Name = "groupBoxMiniCafe4";
            groupBoxMiniCafe4.Size = new Size(63, 33);
            groupBoxMiniCafe4.TabIndex = 22;
            groupBoxMiniCafe4.TabStop = false;
            // 
            // LabelMiniCafe4
            // 
            LabelMiniCafe4.AutoSize = true;
            LabelMiniCafe4.ForeColor = SystemColors.ActiveCaption;
            LabelMiniCafe4.Location = new Point(4, 12);
            LabelMiniCafe4.Name = "LabelMiniCafe4";
            LabelMiniCafe4.Size = new Size(13, 15);
            LabelMiniCafe4.TabIndex = 0;
            LabelMiniCafe4.Text = "0";
            // 
            // groupBoxMiniCafe3
            // 
            groupBoxMiniCafe3.Controls.Add(LabelMiniCafe3);
            groupBoxMiniCafe3.Location = new Point(95, 118);
            groupBoxMiniCafe3.Name = "groupBoxMiniCafe3";
            groupBoxMiniCafe3.Size = new Size(63, 33);
            groupBoxMiniCafe3.TabIndex = 21;
            groupBoxMiniCafe3.TabStop = false;
            // 
            // LabelMiniCafe3
            // 
            LabelMiniCafe3.AutoSize = true;
            LabelMiniCafe3.ForeColor = SystemColors.ActiveCaption;
            LabelMiniCafe3.Location = new Point(4, 12);
            LabelMiniCafe3.Name = "LabelMiniCafe3";
            LabelMiniCafe3.Size = new Size(13, 15);
            LabelMiniCafe3.TabIndex = 0;
            LabelMiniCafe3.Text = "0";
            // 
            // groupBoxMiniCafe2
            // 
            groupBoxMiniCafe2.Controls.Add(LabelMiniCafe2);
            groupBoxMiniCafe2.Location = new Point(95, 78);
            groupBoxMiniCafe2.Name = "groupBoxMiniCafe2";
            groupBoxMiniCafe2.Size = new Size(63, 33);
            groupBoxMiniCafe2.TabIndex = 20;
            groupBoxMiniCafe2.TabStop = false;
            // 
            // LabelMiniCafe2
            // 
            LabelMiniCafe2.AutoSize = true;
            LabelMiniCafe2.ForeColor = SystemColors.ActiveCaption;
            LabelMiniCafe2.Location = new Point(4, 12);
            LabelMiniCafe2.Name = "LabelMiniCafe2";
            LabelMiniCafe2.Size = new Size(13, 15);
            LabelMiniCafe2.TabIndex = 0;
            LabelMiniCafe2.Text = "0";
            // 
            // groupBoxMiniCafe1
            // 
            groupBoxMiniCafe1.Controls.Add(LabelMiniCafe1);
            groupBoxMiniCafe1.Location = new Point(95, 37);
            groupBoxMiniCafe1.Name = "groupBoxMiniCafe1";
            groupBoxMiniCafe1.Size = new Size(63, 33);
            groupBoxMiniCafe1.TabIndex = 19;
            groupBoxMiniCafe1.TabStop = false;
            // 
            // LabelMiniCafe1
            // 
            LabelMiniCafe1.AutoSize = true;
            LabelMiniCafe1.ForeColor = SystemColors.ActiveCaption;
            LabelMiniCafe1.Location = new Point(4, 12);
            LabelMiniCafe1.Name = "LabelMiniCafe1";
            LabelMiniCafe1.Size = new Size(13, 15);
            LabelMiniCafe1.TabIndex = 0;
            LabelMiniCafe1.Text = "0";
            // 
            // checkBoxMiniCafe4
            // 
            checkBoxMiniCafe4.AutoSize = true;
            checkBoxMiniCafe4.Location = new Point(7, 173);
            checkBoxMiniCafe4.Name = "checkBoxMiniCafe4";
            checkBoxMiniCafe4.Size = new Size(82, 19);
            checkBoxMiniCafe4.TabIndex = 18;
            checkBoxMiniCafe4.Text = "checkBox4";
            checkBoxMiniCafe4.UseVisualStyleBackColor = true;
            checkBoxMiniCafe4.CheckedChanged += MiniCafeNumericUpDown1_ValueChanged;
            // 
            // checkBoxMiniCafe3
            // 
            checkBoxMiniCafe3.AutoSize = true;
            checkBoxMiniCafe3.Location = new Point(7, 134);
            checkBoxMiniCafe3.Name = "checkBoxMiniCafe3";
            checkBoxMiniCafe3.Size = new Size(82, 19);
            checkBoxMiniCafe3.TabIndex = 17;
            checkBoxMiniCafe3.Text = "checkBox3";
            checkBoxMiniCafe3.UseVisualStyleBackColor = true;
            checkBoxMiniCafe3.CheckedChanged += MiniCafeNumericUpDown1_ValueChanged;
            // 
            // checkBoxMiniCafe2
            // 
            checkBoxMiniCafe2.AutoSize = true;
            checkBoxMiniCafe2.Location = new Point(7, 92);
            checkBoxMiniCafe2.Name = "checkBoxMiniCafe2";
            checkBoxMiniCafe2.Size = new Size(82, 19);
            checkBoxMiniCafe2.TabIndex = 16;
            checkBoxMiniCafe2.Text = "checkBox2";
            checkBoxMiniCafe2.UseVisualStyleBackColor = true;
            checkBoxMiniCafe2.CheckedChanged += MiniCafeNumericUpDown1_ValueChanged;
            // 
            // checkBoxMiniCafe1
            // 
            checkBoxMiniCafe1.AutoSize = true;
            checkBoxMiniCafe1.Location = new Point(7, 51);
            checkBoxMiniCafe1.Name = "checkBoxMiniCafe1";
            checkBoxMiniCafe1.Size = new Size(82, 19);
            checkBoxMiniCafe1.TabIndex = 15;
            checkBoxMiniCafe1.Text = "checkBox1";
            checkBoxMiniCafe1.UseVisualStyleBackColor = true;
            checkBoxMiniCafe1.CheckedChanged += MiniCafeNumericUpDown1_ValueChanged;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(label11);
            groupBox7.Controls.Add(LabelMiniCafeCost);
            groupBox7.Font = new Font("Segoe UI", 10F);
            groupBox7.ForeColor = Color.Cyan;
            groupBox7.Location = new Point(6, 235);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(245, 73);
            groupBox7.TabIndex = 14;
            groupBox7.TabStop = false;
            groupBox7.Text = "До сплати";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(210, 40);
            label11.Name = "label11";
            label11.Size = new Size(33, 19);
            label11.TabIndex = 15;
            label11.Text = "грн.";
            // 
            // LabelMiniCafeCost
            // 
            LabelMiniCafeCost.AutoSize = true;
            LabelMiniCafeCost.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            LabelMiniCafeCost.ForeColor = SystemColors.ActiveCaption;
            LabelMiniCafeCost.Location = new Point(6, 24);
            LabelMiniCafeCost.Name = "LabelMiniCafeCost";
            LabelMiniCafeCost.Size = new Size(33, 37);
            LabelMiniCafeCost.TabIndex = 6;
            LabelMiniCafeCost.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(164, 19);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 1;
            label8.Text = "Кількість";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 19);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 0;
            label6.Text = "Ціна";
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.free_sticker_money_bag_6639875;
            pictureBox1.Location = new Point(342, 352);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // timer3
            // 
            timer3.Tick += timer3_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(565, 456);
            Controls.Add(pictureBox1);
            Controls.Add(LabelTime);
            Controls.Add(GroupBoxMiniCafe);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            GroupBoxMiniCafe.ResumeLayout(false);
            GroupBoxMiniCafe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MiniCafeNumericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)MiniCafeNumericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)MiniCafeNumericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)MiniCafeNumericUpDown1).EndInit();
            groupBoxMiniCafe4.ResumeLayout(false);
            groupBoxMiniCafe4.PerformLayout();
            groupBoxMiniCafe3.ResumeLayout(false);
            groupBoxMiniCafe3.PerformLayout();
            groupBoxMiniCafe2.ResumeLayout(false);
            groupBoxMiniCafe2.PerformLayout();
            groupBoxMiniCafe1.ResumeLayout(false);
            groupBoxMiniCafe1.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ComboBox comboBoxBenzine;
        private RadioButton radioButtonSum;
        private RadioButton radioButtonCount;
        private TextBox textBox1;
        private Label CostBenzin;
        private TextBox textBox2;
        private Label LabelGasStationCost;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox GroupBoxMiniCafe;
        private Label label1;
        private Label LabelPriceLiterBenzine;
        private Label label5;
        private Label label4;
        private GroupBox groupBox5;
        private Label label7;
        private GroupBox groupBox6;
        private Label label10;
        private GroupBox groupBox7;
        private Label label11;
        private Label LabelMiniCafeCost;
        private Label label8;
        private Label label6;
        private CheckBox checkBoxMiniCafe4;
        private CheckBox checkBoxMiniCafe3;
        private CheckBox checkBoxMiniCafe2;
        private CheckBox checkBoxMiniCafe1;
        private GroupBox groupBoxMiniCafe1;
        private Label LabelMiniCafe1;
        private GroupBox groupBoxMiniCafe4;
        private Label LabelMiniCafe4;
        private GroupBox groupBoxMiniCafe3;
        private Label LabelMiniCafe3;
        private GroupBox groupBoxMiniCafe2;
        private Label LabelMiniCafe2;
        private NumericUpDown MiniCafeNumericUpDown1;
        private NumericUpDown MiniCafeNumericUpDown4;
        private NumericUpDown MiniCafeNumericUpDown3;
        private NumericUpDown MiniCafeNumericUpDown2;
        private System.Windows.Forms.Timer timer2;
        private Label LabelTime;
        private Button ButtonPay;
        private Label label13;
        private Label LabelAllCost;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer3;
    }
}
