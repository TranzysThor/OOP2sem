using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Timers;
using System.Windows.Forms;

namespace Laba3
{
    public partial class Form1 : Form
    {
        private static List<Student> Students = new List<Student>();
        private static IOrderedEnumerable<Student> sortedByGroup;
        private static IOrderedEnumerable<Student> sortedByCourse;
        public Form1()
        {
            InitializeComponent();
            for (int i = 17; i <= 30; i++)
            {
                listBox1.Items.Add(i);
            }

            listBox2.Items.Add("Male");
            listBox2.Items.Add("Female");
            listBox3.Items.Add("ISiT");
            listBox3.Items.Add("POIT");
            listBox3.Items.Add("POiBMS");
            listBox3.Items.Add("DEiWI");
            dateTimePicker1.MinDate = new DateTime(1991, 1, 1);
            dateTimePicker1.MaxDate = new DateTime(2004, 1, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

            student.Group = Convert.ToString(trackBar1.Value);
            student.Gpa = textBox4.Text;
            student.Sex = listBox2.Text;
            student.Address = textBox5.Text;
            var results = new List<ValidationResult>();
            var context = new ValidationContext(student);
            if (!Validator.TryValidateObject(student, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error);
                }
            }
            else
            {
                Students.Add(student);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            listBox1.ClearSelected();
            listBox2.ClearSelected();
            listBox3.ClearSelected();
            label13.Text = "Previous Action: Create Object";
        }

        private void SerializeStudent(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("students.json", FileMode.OpenOrCreate))
            {
                    JsonSerializer.SerializeAsync(fs, Students);
            }
            label13.Text = "Previous Action: Save Object";

        }

        private void OutputStudentsInfo(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string json = File.ReadAllText("students.json");
            List<Student> deserializedStudents = JsonSerializer.Deserialize<List<Student>>(json);
            foreach (var student in deserializedStudents)
            {
                richTextBox1.AppendText($"Surname: {student.Surname}\n" +
                                        $"First Name: {student.Name}\n" +
                                        $"Patronymic: {student.Patronymic}\n" +
                                        $"Age: {student.Age} лет\n" +
                                        $"Speciality: {student.Speciality}\n" +
                                        $"Date of Birth: {student.DateOfBirth}\n" +
                                        $"Course: {student.Course}\n" +
                                        $"Group: {student.Group}\n" +
                                        $"GPA: {student.Gpa}\n" +
                                        $"Sex: {student.Sex}\n" +
                                        $"Address: {student.Address}\n\n");
            }
            label13.Text = "Previous Action: Output Object";

        }

        private void ClearField(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            label13.Text = "Previous Action: Clear";

        }

        private void About(object sender, EventArgs e)
        {
            MessageBox.Show("v.1.0.2\nDeveloper: Akulevich M.D.");
            label13.Text = "Previous Action: About";
        }

        private void FullnameSearch(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
            label13.Text = "Previous Action: Search By FIO";
        }

        private void SpecialitySearch(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.ShowDialog();
            label13.Text = "Previous Action: Search By Speciality";
        }

        private void CourseSearch(object sender, EventArgs e)
        {
            Form form4 = new Form4();
            form4.ShowDialog();
            label13.Text = "Previous Action: Search By Course";
        }

        private void GpaSearch(object sender, EventArgs e)
        {
            Form form5 = new Form5();
            form5.ShowDialog();
            label13.Text = "Previous Action: Search By GPA";
        }

        private void SortByGroup(object sender, EventArgs e)
        {
            sortedByGroup = from student in Students
                orderby student.Group
                select student;
            foreach (var student in sortedByGroup)
            {
                richTextBox1.AppendText($"Surname: {student.Surname}\n" +
                                        $"First Name: {student.Name}\n" +
                                        $"Patronymic: {student.Patronymic}\n" +
                                        $"Age: {student.Age} лет\n" +
                                        $"Speciality: {student.Speciality}\n" +
                                        $"Date of Birth: {student.DateOfBirth}\n" +
                                        $"Course: {student.Course}\n" +
                                        $"Group: {student.Group}\n" +
                                        $"GPA: {student.Gpa}\n" +
                                        $"Sex: {student.Sex}\n" +
                                        $"Address: {student.Address}\n\n");
            }
            label13.Text = "Previous Action: Sort By Group";
        }

        private void SaveSortedByGroup(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("sortedByGroup.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync(fs, sortedByGroup);
            }
            label13.Text = "Previous Action: Save Sorted By Group";
        }
        private void SortByCourse(object sender, EventArgs e)
        {
            sortedByCourse = from student in Students
                orderby student.Course
                select student;
            foreach (var student in sortedByCourse)
            {
                richTextBox1.AppendText($"Surname: {student.Surname}\n" +
                                        $"First Name: {student.Name}\n" +
                                        $"Patronymic: {student.Patronymic}\n" +
                                        $"Age: {student.Age} лет\n" +
                                        $"Speciality: {student.Speciality}\n" +
                                        $"Date of Birth: {student.DateOfBirth}\n" +
                                        $"Course: {student.Course}\n" +
                                        $"Group: {student.Group}\n" +
                                        $"GPA: {student.Gpa}\n" +
                                        $"Sex: {student.Sex}\n" +
                                        $"Address: {student.Address}\n\n");
            }
            label13.Text = "Previous Action: Sort By Course";
        }

        private void SaveSortedByCourse(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("sortedByCourse.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync(fs, sortedByCourse);
            }
            label13.Text = "Previous Action: Save Sorted By Course";
        }
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            label12.Text = $"Amount of Objects: {Students.Count()}";
            label14.Text = $"{DateTime.Now}";
        }
    }
}