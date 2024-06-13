using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projec
{
    public class French
    {
        private List<float> grades = new List<float>();

        public void AddGrade(int grade)
        {
                this.grades.Add(grade);
        }
        public int Max { get; set; }

        public int Min { get; set; }

        public int Average { get; set; }
    }
}
