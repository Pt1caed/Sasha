namespace DZ05052025
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
            openFileDialog1 = new OpenFileDialog();
            groupBoxServer = new GroupBox();
            textBoxPort = new TextBox();
            labelPort = new Label();
            labelSMTP = new Label();
            textBoxSMTP = new TextBox();
            labelEmail = new Label();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            labelPassword = new Label();
            groupBoxPossessors = new GroupBox();
            listBoxPossessors = new ListBox();
            textBoxPossessorsAdd = new TextBox();
            buttonClear = new Button();
            buttonAdd = new Button();
            buttonDelete = new Button();
            groupBoxList = new GroupBox();
            richTextBoxText = new RichTextBox();
            labelText = new Label();
            labelTheme = new Label();
            textBoxTheme = new TextBox();
            labelAttachments = new Label();
            buttonAddInvestment = new Button();
            buttonDeleteInvestment = new Button();
            buttonSend = new Button();
            listBoxAttachments = new ListBox();
            openFileDialog2 = new OpenFileDialog();
            groupBoxServer.SuspendLayout();
            groupBoxPossessors.SuspendLayout();
            groupBoxList.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBoxServer
            // 
            groupBoxServer.Controls.Add(textBoxPort);
            groupBoxServer.Controls.Add(labelPort);
            groupBoxServer.Controls.Add(labelSMTP);
            groupBoxServer.Controls.Add(textBoxSMTP);
            groupBoxServer.Controls.Add(labelEmail);
            groupBoxServer.Controls.Add(textBoxPassword);
            groupBoxServer.Controls.Add(textBoxEmail);
            groupBoxServer.Controls.Add(labelPassword);
            groupBoxServer.Location = new Point(12, 208);
            groupBoxServer.Name = "groupBoxServer";
            groupBoxServer.Size = new Size(243, 206);
            groupBoxServer.TabIndex = 0;
            groupBoxServer.TabStop = false;
            groupBoxServer.Text = "Server";
            // 
            // textBoxPort
            // 
            textBoxPort.Location = new Point(6, 79);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.ReadOnly = true;
            textBoxPort.Size = new Size(231, 23);
            textBoxPort.TabIndex = 8;
            textBoxPort.Text = "587";
            // 
            // labelPort
            // 
            labelPort.AutoSize = true;
            labelPort.Location = new Point(6, 63);
            labelPort.Name = "labelPort";
            labelPort.Size = new Size(29, 15);
            labelPort.TabIndex = 7;
            labelPort.Text = "Port";
            // 
            // labelSMTP
            // 
            labelSMTP.AutoSize = true;
            labelSMTP.Location = new Point(6, 19);
            labelSMTP.Name = "labelSMTP";
            labelSMTP.Size = new Size(72, 15);
            labelSMTP.TabIndex = 6;
            labelSMTP.Text = "SMTP server";
            // 
            // textBoxSMTP
            // 
            textBoxSMTP.Location = new Point(6, 37);
            textBoxSMTP.Name = "textBoxSMTP";
            textBoxSMTP.Size = new Size(231, 23);
            textBoxSMTP.TabIndex = 3;
            textBoxSMTP.Text = "smtp.gmail.com";
            textBoxSMTP.TextChanged += textBoxSMPT_TextChanged;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(6, 107);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(41, 15);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "E-mail";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(6, 169);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(231, 23);
            textBoxPassword.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(6, 125);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(231, 23);
            textBoxEmail.TabIndex = 0;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(6, 151);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            // 
            // groupBoxPossessors
            // 
            groupBoxPossessors.Controls.Add(listBoxPossessors);
            groupBoxPossessors.Controls.Add(textBoxPossessorsAdd);
            groupBoxPossessors.Controls.Add(buttonClear);
            groupBoxPossessors.Controls.Add(buttonAdd);
            groupBoxPossessors.Controls.Add(buttonDelete);
            groupBoxPossessors.Location = new Point(12, 12);
            groupBoxPossessors.Name = "groupBoxPossessors";
            groupBoxPossessors.Size = new Size(243, 190);
            groupBoxPossessors.TabIndex = 1;
            groupBoxPossessors.TabStop = false;
            groupBoxPossessors.Text = "Possessors";
            // 
            // listBoxPossessors
            // 
            listBoxPossessors.FormattingEnabled = true;
            listBoxPossessors.ItemHeight = 15;
            listBoxPossessors.Location = new Point(6, 16);
            listBoxPossessors.Name = "listBoxPossessors";
            listBoxPossessors.Size = new Size(231, 109);
            listBoxPossessors.TabIndex = 9;
            listBoxPossessors.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBoxPossessorsAdd
            // 
            textBoxPossessorsAdd.Location = new Point(3, 132);
            textBoxPossessorsAdd.Name = "textBoxPossessorsAdd";
            textBoxPossessorsAdd.Size = new Size(234, 23);
            textBoxPossessorsAdd.TabIndex = 8;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(165, 161);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(72, 23);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(3, 161);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(84, 161);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // groupBoxList
            // 
            groupBoxList.Controls.Add(richTextBoxText);
            groupBoxList.Controls.Add(labelText);
            groupBoxList.Controls.Add(labelTheme);
            groupBoxList.Controls.Add(textBoxTheme);
            groupBoxList.Location = new Point(261, 12);
            groupBoxList.Name = "groupBoxList";
            groupBoxList.Size = new Size(527, 280);
            groupBoxList.TabIndex = 2;
            groupBoxList.TabStop = false;
            groupBoxList.Text = "List";
            // 
            // richTextBoxText
            // 
            richTextBoxText.BorderStyle = BorderStyle.None;
            richTextBoxText.Location = new Point(6, 113);
            richTextBoxText.Name = "richTextBoxText";
            richTextBoxText.Size = new Size(515, 161);
            richTextBoxText.TabIndex = 10;
            richTextBoxText.Text = "";
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Location = new Point(6, 95);
            labelText.Name = "labelText";
            labelText.Size = new Size(28, 15);
            labelText.TabIndex = 9;
            labelText.Text = "Text";
            // 
            // labelTheme
            // 
            labelTheme.AutoSize = true;
            labelTheme.Location = new Point(6, 34);
            labelTheme.Name = "labelTheme";
            labelTheme.Size = new Size(44, 15);
            labelTheme.TabIndex = 8;
            labelTheme.Text = "Theme";
            // 
            // textBoxTheme
            // 
            textBoxTheme.Location = new Point(6, 52);
            textBoxTheme.Name = "textBoxTheme";
            textBoxTheme.Size = new Size(515, 23);
            textBoxTheme.TabIndex = 0;
            // 
            // labelAttachments
            // 
            labelAttachments.AutoSize = true;
            labelAttachments.Location = new Point(267, 295);
            labelAttachments.Name = "labelAttachments";
            labelAttachments.Size = new Size(75, 15);
            labelAttachments.TabIndex = 11;
            labelAttachments.Text = "Attachments";
            // 
            // buttonAddInvestment
            // 
            buttonAddInvestment.Location = new Point(626, 413);
            buttonAddInvestment.Name = "buttonAddInvestment";
            buttonAddInvestment.Size = new Size(75, 23);
            buttonAddInvestment.TabIndex = 10;
            buttonAddInvestment.Text = "Add";
            buttonAddInvestment.UseVisualStyleBackColor = true;
            buttonAddInvestment.Click += buttonAddInvestment_Click;
            // 
            // buttonDeleteInvestment
            // 
            buttonDeleteInvestment.Location = new Point(707, 413);
            buttonDeleteInvestment.Name = "buttonDeleteInvestment";
            buttonDeleteInvestment.Size = new Size(75, 23);
            buttonDeleteInvestment.TabIndex = 11;
            buttonDeleteInvestment.Text = "Delete";
            buttonDeleteInvestment.UseVisualStyleBackColor = true;
            buttonDeleteInvestment.Click += buttonDeleteInvestment_Click;
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(35, 415);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(190, 28);
            buttonSend.TabIndex = 12;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // listBoxAttachments
            // 
            listBoxAttachments.FormattingEnabled = true;
            listBoxAttachments.ItemHeight = 15;
            listBoxAttachments.Location = new Point(267, 313);
            listBoxAttachments.Name = "listBoxAttachments";
            listBoxAttachments.Size = new Size(515, 94);
            listBoxAttachments.TabIndex = 10;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxAttachments);
            Controls.Add(buttonSend);
            Controls.Add(buttonAddInvestment);
            Controls.Add(buttonDeleteInvestment);
            Controls.Add(labelAttachments);
            Controls.Add(groupBoxList);
            Controls.Add(groupBoxPossessors);
            Controls.Add(groupBoxServer);
            Name = "Form1";
            Text = "Form1";
            groupBoxServer.ResumeLayout(false);
            groupBoxServer.PerformLayout();
            groupBoxPossessors.ResumeLayout(false);
            groupBoxPossessors.PerformLayout();
            groupBoxList.ResumeLayout(false);
            groupBoxList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private GroupBox groupBoxServer;
        private Label labelPort;
        private Label labelSMTP;
        private TextBox textBoxSMTP;
        private Label labelEmail;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private Label labelPassword;
        private GroupBox groupBoxPossessors;
        private TextBox textBoxPossessorsAdd;
        private Button buttonClear;
        private Button buttonAdd;
        private Button buttonDelete;
        private GroupBox groupBoxList;
        private Label labelTheme;
        private TextBox textBoxTheme;
        private RichTextBox richTextBoxText;
        private Label labelText;
        private Label labelAttachments;
        private Button buttonAddInvestment;
        private Button buttonDeleteInvestment;
        private Button buttonSend;
        private ListBox listBoxPossessors;
        private ListBox listBoxAttachments;
        private OpenFileDialog openFileDialog2;
        private TextBox textBoxPort;
    }
}
