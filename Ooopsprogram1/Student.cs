using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooopsprogram1
{
    public class Student
    {
        private static int count;
        private int rollno;
        private string name;
        private int mathmarks, englishmarks, sciencemarks, totalmarks;
        private double percentage;

        static Student()
        {
            count = 0;
        }
        public Student(string n, int mm, int em, int sm)
        {
            count++;
            rollno = count;
            name = n;
            mathmarks = mm;
            englishmarks = em;
            sciencemarks = sm;
        }
        public void Calculate()
        {
            totalmarks = mathmarks + englishmarks + sciencemarks;
            percentage = ((double)totalmarks / 300) * 100;
        }

        public static int DisplayCount()
        {
            return count;
        }
        public string Print()
        {
            return $"Rollno {rollno} Name {name} TotalMarks={totalmarks} Percentage={percentage}%";
        }

    }
}
