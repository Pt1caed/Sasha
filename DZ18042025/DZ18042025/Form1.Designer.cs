namespace DZ18042025
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
            listBoxChat = new ListBox();
            textBoxSend = new TextBox();
            buttonSend = new Button();
            buttonEntryName = new Button();
            textBoxEntryName = new TextBox();
            labelEntryName = new Label();
            buttonPort = new Button();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listBoxChat
            // 
            listBoxChat.BackColor = Color.FromArgb(255, 128, 255);
            listBoxChat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            listBoxChat.ForeColor = Color.FromArgb(255, 224, 192);
            listBoxChat.FormattingEnabled = true;
            listBoxChat.ItemHeight = 15;
            listBoxChat.Location = new Point(10, 37);
            listBoxChat.Name = "listBoxChat";
            listBoxChat.Size = new Size(322, 379);
            listBoxChat.TabIndex = 0;
            // 
            // textBoxSend
            // 
            textBoxSend.Location = new Point(12, 421);
            textBoxSend.Name = "textBoxSend";
            textBoxSend.Size = new Size(217, 23);
            textBoxSend.TabIndex = 1;
            // 
            // buttonSend
            // 
            buttonSend.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSend.Location = new Point(235, 421);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(99, 23);
            buttonSend.TabIndex = 2;
            buttonSend.Text = "Отправить SMS";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // buttonEntryName
            // 
            buttonEntryName.Location = new Point(257, 8);
            buttonEntryName.Name = "buttonEntryName";
            buttonEntryName.Size = new Size(61, 23);
            buttonEntryName.TabIndex = 3;
            buttonEntryName.Text = "Ок";
            buttonEntryName.UseVisualStyleBackColor = true;
            buttonEntryName.Click += buttonEntryName_Click;
            // 
            // textBoxEntryName
            // 
            textBoxEntryName.Location = new Point(93, 8);
            textBoxEntryName.Name = "textBoxEntryName";
            textBoxEntryName.Size = new Size(158, 23);
            textBoxEntryName.TabIndex = 4;
            // 
            // labelEntryName
            // 
            labelEntryName.AutoSize = true;
            labelEntryName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelEntryName.Location = new Point(4, 11);
            labelEntryName.Name = "labelEntryName";
            labelEntryName.Size = new Size(83, 15);
            labelEntryName.TabIndex = 5;
            labelEntryName.Text = "Введите имя";
            // 
            // buttonPort
            // 
            buttonPort.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonPort.Location = new Point(347, 89);
            buttonPort.Name = "buttonPort";
            buttonPort.Size = new Size(75, 23);
            buttonPort.TabIndex = 7;
            buttonPort.Text = "Ок";
            buttonPort.UseVisualStyleBackColor = true;
            buttonPort.Click += buttonPort_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            label1.Location = new Point(338, 45);
            label1.Name = "label1";
            label1.Size = new Size(112, 12);
            label1.TabIndex = 8;
            label1.Text = "На какой порт писать";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(338, 60);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(106, 23);
            numericUpDown1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(450, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(buttonPort);
            Controls.Add(labelEntryName);
            Controls.Add(textBoxEntryName);
            Controls.Add(buttonEntryName);
            Controls.Add(buttonSend);
            Controls.Add(textBoxSend);
            Controls.Add(listBoxChat);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxChat;
        private TextBox textBoxSend;
        private Button buttonSend;
        private Button buttonEntryName;
        private TextBox textBoxEntryName;
        private Label labelEntryName;
        private Button buttonPort;
        private Label label1;
        private NumericUpDown numericUpDown1;
    }
}
