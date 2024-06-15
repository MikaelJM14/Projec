namespace Projec
{
    public class Student
    {
        public List<int> grades = new();

        public Student(string name, string surname)
        {
            Name = name; 
            Surname = surname;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public void AddGrade(int grade)
        {
            this.grades.Add(grade);
        }
    }
}
