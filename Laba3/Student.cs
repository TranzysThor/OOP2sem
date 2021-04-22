using System;
using System.ComponentModel.DataAnnotations;

namespace Laba3
{
    public class Student
    {
        [Required(ErrorMessage = "Missing Surname")]
        private string _surname;

        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }
        [Required(ErrorMessage = "Missing Name")]
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        [Required(ErrorMessage = "Missing Patronymic")]
        [RegularExpression(@"$(ich|vna)")]
        private string _patronymic;

        public string Patronymic
        {
            get => _patronymic;
            set => _patronymic = value;
        }
        [Required(ErrorMessage = "Missing Age")]
        private string _age;

        public string Age
        {
            get => _age;
            set => _age = value;
        }
        [Required(ErrorMessage = "Missing Speciality")]
        private string _speciality;

        public string Speciality
        {
            get => _speciality;
            set => _speciality = value;
        }
        [Required(ErrorMessage = "Missing Date of Birth")]
        private DateTime _dateOfBirth;

        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set => _dateOfBirth = value;
        }
        [Required(ErrorMessage = "Missing Course")]
        [Range(1, 4)]
        private string _course;

        public string Course
        {
            get => _course;
            set => _course = value;
        }
        [Required(ErrorMessage = "Missing Group")]
        private string _group;

        public string Group
        {
            get => _group;
            set => _group = value;
        }
        [Required(ErrorMessage = "Missing GPA")]
        private string _gpa;

        public string Gpa
        {
            get => _gpa;
            set => _gpa = value;
        }
        [Required(ErrorMessage = "Missing Sex")]
        private string _sex;

        public string Sex
        {
            get => _sex;
            set => _sex = value;
        }
        [Required(ErrorMessage = "Missing Address")]
        private string _address;

        public string Address
        {
            get => _address;
            set => _address = value;
        }

        public Student()
        {
        }

        public Student(string surname, string name, string patronymic, string age, string speciality,
            DateTime dateOfBirth, string course, string group, string gpa, string sex, string address)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Age = age;
            Speciality = speciality;
            DateOfBirth = dateOfBirth;
            Course = course;
            Group = group;
            Gpa = gpa;
            Sex = sex;
            Address = address;
        }
    }
}