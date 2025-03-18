using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DZ17032025
{
    public partial class Form1 : Form
    {
        string PathToJson { get; set; }

        

        public Form1()
        {
            InitializeComponent();
            PathToJson = Path.Combine(Directory.GetCurrentDirectory(), "Resumes.json");
            //List<Resume> list =
            //    [
            //    new() { City = new() { Name = "Kiev" }, Salary = 10000, Text = "aaaa", YearOfExperience = 2 },
            //new() { City = new() { Name = "Odessa" }, Salary = 15000, Text = "ffff", YearOfExperience = 1 },
            //new() { City = new() { Name = "Zhitomyr" }, Salary = 20000, Text = "Я Аня, и я джуниор.", YearOfExperience = 4 }
            //    ];

            //WriteArray(PathToJson, list);
            //LoadDataAsync();
        }

            private async void LoadDataAsync()
        {
            var list = await FromListBoxToList();
            if (list != null)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(
                    list.Where(p => p.City != null)
                        .Select(p => p.City!.Name)
                        .Distinct()
                        .ToArray()
                );
            }
        }

        private async Task<List<Resume>> FromListBoxToList()
        {
            return await Task.Run(() =>
            {
                List<Resume> list = new();
                foreach (var item in listBox1.Items)
                {
                    if (item is Resume resume)
                    {
                        list.Add(resume);
                    }
                }
                return list;
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = ReadJson(PathToJson);
            string jsonContent = File.ReadAllText(PathToJson);
            MessageBox.Show(jsonContent);

            listBox1.Items.Clear();
            comboBox1.Items.Clear();

            if (list != null)
            {
                listBox1.Items.AddRange(list.ToArray());
            }
        }

        private void WriteObj(string filePath, Resume obj)
        {
            List<Resume> list = new List<Resume>();
            if (File.Exists(filePath))
            {
                list = JsonConvert.DeserializeObject<List<Resume>>(File.ReadAllText(filePath)) ?? new List<Resume>();
            }
            list.Add(obj);

            var json = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        private async Task WriteArray(string filePath, List<Resume> objects)
        {
            await Task.Run(() =>
            {
                List<Resume> list;
                if (File.Exists(filePath))
                {
                    var jsonContent = File.ReadAllText(filePath);
                    list = JsonConvert.DeserializeObject<List<Resume>>(jsonContent) ?? new List<Resume>();
                }
                else
                {
                    list = new List<Resume>();
                }

                list.AddRange(objects);

                var json = JsonConvert.SerializeObject(list, Formatting.Indented);
                File.WriteAllText(filePath, json);
            });
        }

        private List<Resume>? ReadJson(string filePath)
        {
            if (File.Exists(filePath) && File.ReadAllText(filePath) != null)
            {
                return JsonConvert.DeserializeObject<List<Resume>>(File.ReadAllText(filePath));
            }
            else
            {
                return new List<Resume>();
            }
        }

        private async Task AddToListBox(List<Resume> list)
        {
            await Task.Run(() =>
            {
                listBox2.Items.Clear();
                if (list != null)
                    listBox2.Items.AddRange(list.ToArray());
            });
        }

        private async void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            await AddToListBox(await ExperiencedCandidate());
        }

        private async void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            await AddToListBox(await NotExperiencedCandidate());
        }

        private async void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            await AddToListBox(await TopSalaryDemandCandidate());
        }

        private async void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            await AddToListBox(await MinSalaryDemandCandidate());
        }

        private async void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is City city && city != null)
                await AddToListBox(await CandidateFromOneCountry(city));
        }

        private async Task<List<Resume>?> ExperiencedCandidate()
        {
            var list = await FromListBoxToList();
            return list.OrderByDescending(p => p.YearOfExperience).Take(1).ToList();
        }

        private async Task<List<Resume>?> NotExperiencedCandidate()
        {
            var list = await FromListBoxToList();
            return list.OrderBy(p => p.YearOfExperience).Take(1).ToList();
        }

        private async Task<List<Resume>?> TopSalaryDemandCandidate()
        {
            var list = await FromListBoxToList();
            return list.OrderByDescending(p => p.Salary).Take(1).ToList();
        }

        private async Task<List<Resume>?> MinSalaryDemandCandidate()
        {
            var list = await FromListBoxToList();
            return list.OrderBy(p => p.Salary).Take(1).ToList();
        }

        private async Task<List<Resume>?> CandidateFromOneCountry(City city)
        {
            var list = await FromListBoxToList();
            return list.Where(p => p.City == city).ToList();
        }
    }
}