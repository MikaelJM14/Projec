using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projec
{
    public class Student
    {
        public List<float> grades = new List<float>();

        public Student(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public void AddGrade(int grade)
        {
            this.grades.Add(grade);
        }
    }
}
