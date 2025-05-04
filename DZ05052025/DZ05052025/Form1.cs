using System.Net;
using System.Net.Mail;

namespace DZ05052025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            var text = textBoxPossessorsAdd.Text;
            if (!string.IsNullOrEmpty(text))
            {
                listBoxPossessors.Items.Add(text);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var item = listBoxPossessors.SelectedItem;
            if (item != null)
            {
                listBoxPossessors.Items.Remove(item);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Task.Run(() => listBoxPossessors.Items.Clear());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async Task SendMessage()
        {
            var smtpServer = textBoxSMTP.Text;
            var port = int.Parse(textBoxPort.Text);
            var email = textBoxEmail.Text;
            var password = textBoxPassword.Text;
            var subject = textBoxTheme.Text;
            var body = richTextBoxText.Text;
            var attachments = listBoxAttachments.Items.Cast<string>().ToList();
            var recipients = listBoxPossessors.Items.Cast<string>().ToList();

            if (string.IsNullOrWhiteSpace(smtpServer) || port <= 0 ||
                string.IsNullOrWhiteSpace(email) || !email.Contains('@') ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(subject) || string.IsNullOrWhiteSpace(body))
            {
                MessageBox.Show("Перевір усі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await Task.Run(() =>
            {
                try
                {
                    using MailMessage message = new();
                    message.From = new MailAddress(email, email[..email.IndexOf('@')]);
                    message.Subject = subject;
                    message.Body = body;

                    foreach (var r in recipients)
                    {
                        if (r.Contains("@"))
                            message.To.Add(r);
                    }

                    foreach (var file in attachments)
                    {
                        message.Attachments.Add(new Attachment(file));
                    }

                    using SmtpClient smtp = new(smtpServer, port)
                    {
                        Credentials = new NetworkCredential(email, password),
                        EnableSsl = true
                    };

                    smtp.Send(message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Message: {ex.Message}\n" +
                        $"Inner: {ex.InnerException?.Message}",
                        "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            });
        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            await SendMessage();
        }

        private void textBoxSMPT_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddInvestment_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBoxAttachments.Items.Add(openFileDialog1.FileName);
            }
        }

        private void buttonDeleteInvestment_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxAttachments.SelectedItem;
            if( selectedItem != null)
            {
                listBoxAttachments.Items.Remove(selectedItem);
            }
        }
    }
}
