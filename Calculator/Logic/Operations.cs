using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Operations
    {
        public double Addition(double a, double b)
        {
            return a + b;
        }
        public double Subtraction(double a, double b)
        {
            return a - b;
        }
        public double Multiplication(double a, double b)
        {
            return a * b;
        }
        public double Division(double a, double b)
        {
            return a / b;
        }
        public double Procents(double a, double b)
        {
            double x = a * b / 100;
            return x;
        }
        public double DivisionWithProcents(double a, double b)
        {
            double x = a % b;
            return x;
        }
    }
}