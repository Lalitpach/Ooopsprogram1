using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooopsprogram1
{
    public class Calculator
    {
        public double Add(double a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b;
        }
        public double Add(int a, double b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Sub(int a, int b, int c)
        {
            return a - b - c;
        }
        public double Sub(int a, double b)
        {
            return a - b;
        }

        public double Sub(double a, int b)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }
        public int Mul(int a, int b, int c)
        {
            return a * b * c;
        }
        public double Mul(int a, double b)
        {
            return a * b;
        }

        public double Mul(double a, int b)
        {
            return a * b;
        }

        public int Div(int a, int b)
        {
            return a / b;
        }
        public double Div(int a, double b)
        {
            return (double)a / b;
        }

        public double Div(double a, int b)
        {
            return a / b;
        }
    }
}
