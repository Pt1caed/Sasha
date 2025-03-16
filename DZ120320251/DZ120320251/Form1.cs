using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace DZ120320251
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkedListBox1.Items.AddRange(new object[]
            {
                new NameAndFunc { Action = CountOfWords, Name = "���������� ����"},
                new NameAndFunc { Action = CountOfSymbols, Name = "���������� ��������"},
                new NameAndFunc { Action = CountOfSentences, Name = "���������� �����������"},
                new NameAndFunc { Action = CountOfExclamations, Name = "���������� ��������������� �����������"},
                new NameAndFunc { Action = CountOfQuestions, Name = "���������� �������������� �����������"}
            });

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private async Task CountOfWords()
        {
            await Task.Run(() =>
            {
                var words = textBox1.Text.Split(' ').Count();

                listBox1.Items.Add($"���������� ����: {words}");
            });
        }
        private async Task CountOfSymbols()
        {
            await Task.Run(() =>
            {
                listBox1.Items.Add($"���������� ��������: {textBox1.Text.Length}");
            });
        }
        private async Task<string[]> AllSentence()
        {
            return await Task.Run(() =>
            {
                List<string> massive = [];
                string ChoiceSentences = @"([?!\.])";

                var text = Regex.Split(textBox1.Text, ChoiceSentences).ToArray();
                
                for(int i = 0; i < text.Length; i+=2)
                {
                    string sentence = text[i] + (i + 1 < text.Length ? text[i + 1].ToString() : "");
                    massive.Add(sentence.Trim());
                }

                return massive.ToArray();
            });
        }
        private async Task CountOfSentences()
        {
            await Task.Run(async () =>
            {
                var CountQuestions = await CountOfSymbol('.', "");
            });
        }
        private async Task CountOfExclamations()
        {
            await Task.Run(async () =>
            {
                var CountQuestions = await CountOfSymbol('!', "���������������");
            });
        }
        private async Task CountOfQuestions()
        {
            await Task.Run(async () =>
            {
                var CountQuestions = await CountOfSymbol('?', "��������������");
            });
        }

        private async Task<int> CountOfSymbol(char symbol, string nameSymbol)
        {
            return await Task.Run(async () =>
            {
                var CountSentences = (await AllSentence())
                .Where(p => p.Length > 1 && p[p.Length - 1] == symbol)
                .Count();
                listBox1.Items.Add($"���������� {nameSymbol} �����������: {CountSentences}");

                return CountSentences;
            });
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                listBox1.Items.Clear();
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    var method = ((NameAndFunc)item).Action;
                    await method.Invoke();
                }
            });

            
        }
    }
}
