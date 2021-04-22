using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Laba3
{
    public partial class Form5 : Form
    {
        private static List<Student> found = new List<Student>();
        public Form5()
        {
            InitializeComponent();
        }
        private void DigitInput(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = !Char.IsDigit(e.KeyChar);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            string json = File.ReadAllText("students.json");
            string[] jsonDelim = json.Split("},{");
            Regex gpaCheck = new Regex(@"G\w{2}(""):("")" + $"[{Convert.ToInt32(gpaBox.Text) + 1}-9]");
            string match = null;
            foreach (var obj in jsonDelim)
            {
                if (gpaCheck.IsMatch(obj))
                {
                    if (obj.Contains('['))
                    {
                        match += obj + "},{";
                    }
                    else if (obj.Contains(']'))
                    {
                        match += "},{" + obj;
                    }
                    else
                    {
                        match += obj;
                    }
                }
            }
            if (match != null)
            {
                if (!match.Contains(']'))
                {
                    match += "}]";
                }
                else if (!match.Contains('['))
                {
                    match = match.Insert(0, "[{");
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
                                         $"Address: {stud.Address}\n\n");
                }
            }
            else
            {
                outputBox.AppendText("No matches found");
            }
        }

        private void SaveFound(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("foundByGPA.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync(fs, found);
            }
        }
    }
}