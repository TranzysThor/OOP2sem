using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Laba3
{
    public partial class Form3 : Form
    {
        private static List<Student> found = new List<Student>();
        public Form3()
        {
            InitializeComponent();
            specialityBox.DropDownStyle = ComboBoxStyle.DropDownList;
            specialityBox.Items.Add("ISiT");
            specialityBox.Items.Add("POIT");
            specialityBox.Items.Add("POiBMS");
            specialityBox.Items.Add("DEiWI");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            string json = File.ReadAllText("students.json");
            string[] jsonDelim = json.Split("},{");
            Regex specialityCheck = new Regex(specialityBox.Text);
            string match = null;
            foreach (var obj in jsonDelim)
            {
                if (specialityCheck.IsMatch(obj))
                {
                    if (obj.Contains('['))
                    {
                        match += obj + "},{";
                    }
                    else if (obj.Contains(']'))
                    {
                        match += obj;
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
            using (FileStream fs = new FileStream("foundBySpeciality.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync(fs, found);
            }
        }
    }
}