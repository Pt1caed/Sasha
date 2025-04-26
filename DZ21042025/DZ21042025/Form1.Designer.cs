namespace DZ21042025
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
            timer1 = new System.Windows.Forms.Timer(components);
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            folderBrowserDialog1 = new FolderBrowserDialog();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            labelName = new Label();
            labelAuthor = new Label();
            comboBox1 = new ComboBox();
            labelTop100 = new Label();
            buttonLoadOneHundredBooks = new Button();
            labelId = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(12, 325);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 1;
            button1.Text = "Select book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.Location = new Point(361, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(427, 424);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelName.Location = new Point(12, 12);
            labelName.Name = "labelName";
            labelName.Size = new Size(0, 21);
            labelName.TabIndex = 4;
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelAuthor.Location = new Point(12, 89);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(0, 21);
            labelAuthor.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 179);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(210, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelTop100
            // 
            labelTop100.AutoSize = true;
            labelTop100.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelTop100.Location = new Point(12, 156);
            labelTop100.Name = "labelTop100";
            labelTop100.Size = new Size(210, 20);
            labelTop100.TabIndex = 8;
            labelTop100.Text = "Top 100 books of Gutenberg";
            // 
            // buttonLoadOneHundredBooks
            // 
            buttonLoadOneHundredBooks.Location = new Point(12, 208);
            buttonLoadOneHundredBooks.Name = "buttonLoadOneHundredBooks";
            buttonLoadOneHundredBooks.Size = new Size(121, 35);
            buttonLoadOneHundredBooks.TabIndex = 9;
            buttonLoadOneHundredBooks.Text = "Load first 100 books";
            buttonLoadOneHundredBooks.UseVisualStyleBackColor = true;
            buttonLoadOneHundredBooks.Click += button2_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelId.Location = new Point(12, 53);
            labelId.Name = "labelId";
            labelId.Size = new Size(0, 21);
            labelId.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 296);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(12, 273);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 12;
            label1.Text = "Search By Id";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(labelId);
            Controls.Add(buttonLoadOneHundredBooks);
            Controls.Add(labelTop100);
            Controls.Add(comboBox1);
            Controls.Add(labelAuthor);
            Controls.Add(labelName);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button1;
        private RichTextBox richTextBox1;
        private Label labelName;
        private Label labelAuthor;
        private ComboBox comboBox1;
        private Label labelTop100;
        private Button buttonLoadOneHundredBooks;
        private Label labelId;
        private TextBox textBox1;
        private Label label1;
    }
}
