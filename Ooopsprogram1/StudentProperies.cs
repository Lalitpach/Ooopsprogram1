using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooopsprogram1
{
    public class StudentProperies
    {
        private int rollno;
        private string name;
        private int s1, s2, s3;
        //private double percentage;

        public int Rollno { get { return rollno; } set { rollno = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int S1 { get { return s1; } set { s1 = value; } }
        public int S2 { get { return s2; } set { s2 = value; } }
        public int S3 { get { return s3; } set { s3 = value; } }
    }
}
