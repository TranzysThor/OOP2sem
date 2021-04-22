using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Laba3
{
    public partial class Form2 : Form
    {
        private static List<Student> found = new List<Student>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        private void TextInput(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar))
            {
                e.Handled = !Char.IsLetter(e.KeyChar);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            string json = File.ReadAllText("students.json");
            string[] jsonDelim = json.Split("},{");
            Regex surnameCheck = new Regex(surnameBox.Text);
            Regex nameCheck = new Regex(firstNameBox.Text);
            Regex patronymicCheck = new Regex(patronymicBox.Text);
            string match = null;
            foreach (var obj in jsonDelim)
            {
                if (surnameCheck.IsMatch(obj) && nameCheck.IsMatch(obj) && patronymicCheck.IsMatch(obj))
                {
                    match = obj;
                }
            }

            if (match != null)
            {
                if (match.Contains('['))
                {
                    match += "}]";
                }
                else if (match.Contains(']'))
                {
                    match = match.Insert(0, "[{");
                }
                else
                {
                    match = match.Insert(0, "[{");
                    match += "}]";
                }
                found = JsonSerializer.Deserialize<List<Student>>(match);
                foreach (var stud in found)
                {
                    outputBox.AppendText($"Surname: {stud.Surname}\n" +
                                         $"First Name: {stud.Name}\n" +
                                         $"Patronymic: {stud.Patronymic}\n" +
                                         $"Age: {stud.Age}\n" +
                                         $"Speciality: {stud.Speciality}\n" +
                                         $"Date of Birth: {stud.DateOfBirth}\n" +
                                         $"Course: {stud.Course}\n" +
                                         $"Group: {stud.Group}\n" +
                                         $"GPA: {stud.Gpa}\n" +
                                         $"Sex: {stud.Sex}\n" +
                                         $"Address: {stud.Address}\n");
                }
            }
            else
            {
                outputBox.AppendText("No matches found");
            }
            surnameBox.Clear();
            firstNameBox.Clear();
            patronymicBox.Clear();
        }

        private void SaveFound(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("foundByFio.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync(fs, found);
            }
        }
    }
}