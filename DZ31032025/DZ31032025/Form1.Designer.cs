namespace DZ31032025
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
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            label2 = new Label();
            button3 = new Button();
            ReceivedPackets = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            OutputPacketRequests = new Label();
            ReceivedPacketsDiscarded = new Label();
            OutputPacketsDiscarded = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(134, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 1;
            label1.Text = "Активные задачи";
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.FromArgb(255, 192, 192);
            checkedListBox1.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkedListBox1.ForeColor = Color.FromArgb(64, 64, 64);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 32);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(393, 244);
            checkedListBox1.TabIndex = 2;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.Green;
            button1.Location = new Point(56, 281);
            button1.Name = "button1";
            button1.Size = new Size(133, 42);
            button1.TabIndex = 3;
            button1.Text = "Обновить задачи";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(195, 283);
            button2.Name = "button2";
            button2.Size = new Size(132, 41);
            button2.TabIndex = 4;
            button2.Text = "Удалить выбранные задачи";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(255, 192, 192);
            listBox1.Font = new Font("Segoe UI Symbol", 8F, FontStyle.Bold);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 13;
            listBox1.Location = new Point(411, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(377, 186);
            listBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(485, 9);
            label2.Name = "label2";
            label2.Size = new Size(219, 20);
            label2.TabIndex = 6;
            label2.Text = "Активные сетевые адаптеры";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button3.ForeColor = Color.Green;
            button3.Location = new Point(513, 224);
            button3.Name = "button3";
            button3.Size = new Size(172, 52);
            button3.TabIndex = 7;
            button3.Text = "Обновить адаптеры";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ReceivedPackets
            // 
            ReceivedPackets.AutoSize = true;
            ReceivedPackets.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ReceivedPackets.ForeColor = Color.FromArgb(255, 255, 128);
            ReceivedPackets.Location = new Point(428, 308);
            ReceivedPackets.Name = "ReceivedPackets";
            ReceivedPackets.Size = new Size(117, 15);
            ReceivedPackets.TabIndex = 8;
            ReceivedPackets.Text = "Входящие пакеты:";
            ReceivedPackets.Click += label3_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // OutputPacketRequests
            // 
            OutputPacketRequests.AutoSize = true;
            OutputPacketRequests.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            OutputPacketRequests.ForeColor = Color.FromArgb(255, 255, 128);
            OutputPacketRequests.Location = new Point(428, 342);
            OutputPacketRequests.Name = "OutputPacketRequests";
            OutputPacketRequests.Size = new Size(124, 15);
            OutputPacketRequests.TabIndex = 14;
            OutputPacketRequests.Text = "Исходящие пакеты:";
            // 
            // ReceivedPacketsDiscarded
            // 
            ReceivedPacketsDiscarded.AutoSize = true;
            ReceivedPacketsDiscarded.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ReceivedPacketsDiscarded.ForeColor = Color.FromArgb(255, 255, 128);
            ReceivedPacketsDiscarded.Location = new Point(428, 378);
            ReceivedPacketsDiscarded.Name = "ReceivedPacketsDiscarded";
            ReceivedPacketsDiscarded.Size = new Size(189, 15);
            ReceivedPacketsDiscarded.TabIndex = 16;
            ReceivedPacketsDiscarded.Text = "Отброшено входящих пакетов:";
            // 
            // OutputPacketsDiscarded
            // 
            OutputPacketsDiscarded.AutoSize = true;
            OutputPacketsDiscarded.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            OutputPacketsDiscarded.ForeColor = Color.FromArgb(255, 255, 128);
            OutputPacketsDiscarded.Location = new Point(428, 412);
            OutputPacketsDiscarded.Name = "OutputPacketsDiscarded";
            OutputPacketsDiscarded.Size = new Size(196, 15);
            OutputPacketsDiscarded.TabIndex = 18;
            OutputPacketsDiscarded.Text = "Отброшено исходящих пакетов:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(OutputPacketsDiscarded);
            Controls.Add(ReceivedPacketsDiscarded);
            Controls.Add(OutputPacketRequests);
            Controls.Add(ReceivedPackets);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private CheckedListBox checkedListBox1;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private Label label2;
        private Button button3;
        private Label ReceivedPackets;
        private Label ReceivedPacketsDiscarded;
        private System.Windows.Forms.Timer timer1;
        private Label OutputPacketsDiscarded;
        private Label OutputPacketRequests;
        private Label PacketFragmentFailures;
        private Label PacketFragmentFailures1;
        private Label PacketReassemblyFailures;
    }
}
