using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StudentRecords
{
    public partial class Form1 : Form
    {
        private static readonly Random random = new Random();

        private static readonly List<string> LastNames = new List<string> { "Иванов", "Петров", "Сидоров", "Кузнецов", "Смирнов" };
        private static readonly List<string> FirstNamesMale = new List<string> { "Иван", "Петр", "Александр" };
        private static readonly List<string> MiddleNames = new List<string> { "Иванович", "Петрович", "Александрович" };
        private static readonly List<string> Subjects = new List<string> { "Математика", "Русский язык", "Английский язык", "Информатика", "Физика" };

        private List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var student = GenerateRandomStudent();
                students.Add(student);
            }

            MessageBox.Show("Данные успешно сгенерированы и записаны.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Student GenerateRandomStudent()
        {
            string lastName = LastNames[random.Next(LastNames.Count)];
            string firstName = FirstNamesMale[random.Next(FirstNamesMale.Count)];
            string middleName = MiddleNames[random.Next(MiddleNames.Count)];

            var student = new Student
            {
                FullName = $"{lastName} {firstName} {middleName}",
                GroupNumber = random.Next(1, 6),
                Grades = new Dictionary<string, int>()
            };

            foreach (var subject in Subjects)
            {
                student.Grades.Add(subject, random.Next(1, 6));
            }

            return student;
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            DisplayStudents();
        }

        private void DisplayStudents()
        {
            studentsListBox.Items.Clear();

            if (students.Count == 0)
            {
                MessageBox.Show("Файл пуст.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var orderedStudents = students.OrderBy(s => s.GroupNumber).ToList();

            bool hasStudentAboveFour = false;

            foreach (var student in orderedStudents)
            {
                double averageGrade = student.Grades.Values.Average();
                string grades = string.Join(", ", student.Grades.Select(kv => $"{kv.Key}: {kv.Value}"));
                studentsListBox.Items.Add($"{student.FullName}, Группа {student.GroupNumber}, Средний балл: {averageGrade:F2}, Оценки: {grades}");

                if (averageGrade > 4)
                {
                    hasStudentAboveFour = true;
                }
            }

            if (!hasStudentAboveFour)
            {
                MessageBox.Show("Нет студентов с средним баллом выше 4.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    public class Student
    {
        public string FullName { get; set; }
        public int GroupNumber { get; set; }
        public Dictionary<string, int> Grades { get; set; }
    }
}





