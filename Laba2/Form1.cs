using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using static Laba2.Student;

namespace Laba2
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            for (int i = 17; i <= 30; i++)
            {
                listBox1.Items.Add(i);
            }

            listBox2.Items.Add("Мужской");
            listBox2.Items.Add("Женский");
            listBox3.Items.Add("ИСиТ");
            listBox3.Items.Add("ПОИТ");
            listBox3.Items.Add("ПОиБМС");
            listBox3.Items.Add("ДЭиВИ");
            dateTimePicker1.MinDate = new DateTime(1991, 1, 1);
            dateTimePicker1.MaxDate = new DateTime(2004, 1, 1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void TextInput(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar))
            {
                e.Handled = !Char.IsLetter(e.KeyChar);
            }
        }

        private void DigitInput(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = !Char.IsDigit(e.KeyChar);
            }        
        }
        
        private void CreateObjectInstance(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Surname = textBox1.Text;
            student.Name = textBox2.Text;
            student.Patronymic = textBox3.Text;
            student.Age = listBox1.Text;
            student.Speciality = listBox3.Text;
            student.DateOfBirth = Convert.ToDateTime(dateTimePicker1.Text);
            if (radioButton1.Checked)
            {
                student.Course = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                student.Course = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                student.Course = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                student.Course = radioButton4.Text;
            }
            student.Group = trackBar1.Text;
            student.Gpa = textBox4.Text;
            student.Sex = listBox2.Text;
            student.Address = textBox5.Text;
            students.Add(student);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            listBox1.ClearSelected();
            listBox2.ClearSelected();
            listBox3.ClearSelected();
        }

        private void SerializeStudent(object sender, EventArgs e)
        {
            if (!File.Exists("students.json"))
            {
                using (FileStream fs = new FileStream("students.json", FileMode.OpenOrCreate))
                {
                    JsonSerializer.SerializeAsync(fs, students);
                }
            }
            else
            {
                using (FileStream fs = new FileStream("students.json", FileMode.Append))
                {
                    JsonSerializer.SerializeAsync(fs, students);
                }
            }
        }

        private void OutputStudentsInfo(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string json = File.ReadAllText("students.json");
            List<Student> deserializedStudents = JsonSerializer.Deserialize<List<Student>>(json);
            foreach (var student in deserializedStudents)
            {
                richTextBox1.AppendText($"Фамилия: {student.Surname}\n" +
                                        $"Имя: {student.Name}\n" +
                                        $"Отчество: {student.Patronymic}\n" +
                                        $"Возраст: {student.Age} лет\n" +
                                        $"Специальность: {student.Speciality}\n" +
                                        $"Дата Рождения: {student.DateOfBirth}\n" +
                                        $"Курс: {student.Course}\n" +
                                        $"Группа: {student.Group}\n" +
                                        $"Средний балл: {student.Gpa}\n" +
                                        $"Пол: {student.Sex}\n" +
                                        $"Адрес: {student.Address}\n\n");
            }
        }

        private void ClearField(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void About(object sender, EventArgs e)
        {
            MessageBox.Show("Какой-то чел");
        }
    }
}