using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooopsprogram1
{
    public class Employee
    {
        private int id;
        private string name;
        private double salary;

        public Employee()
        {


        }
        public Employee(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public string Display()
        {
            return $"id={id} name={name} salary={salary}";
        }

    }
}
