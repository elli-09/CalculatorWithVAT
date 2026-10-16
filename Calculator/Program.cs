using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
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
    class OperationsVAT
    {
        public double CalculateVAT(double amount, double vatPercent)
        {
            double vat = amount * vatPercent / 100;
            Math.Round(vat, 2);
            return vat;
        }
        public double AddVAT(double amount, double vatPercent)
        {
            double total = amount + (amount * vatPercent / 100);
            Math.Round(total, 2);
            return total;
        }
        public double RemoveVAT(double amountWithVAT, double vatPercent)
        {
            double amount = amountWithVAT / (1 + vatPercent / 100);
            Math.Round(amount, 2);
            return amount;
        }
        public double CalculateDiscount(double amount, double discountPercent)
        {
            double discount = amount * discountPercent / 100;
            Math.Round(discount, 2);
            return discount;
        }
        public double ApplyDiscount(double amount, double discountPercent)
        {
            double result = amount - (amount * discountPercent / 100);
            Math.Round(result, 2);
            return result;
        }
    }
    class History
    {
        private string[] records = new string[3];
        private int count = 0;
        public void AddRecord(string record)
        {
            if (count < 3)
            {
                records[count] = record;
                count++;
            }
            else
            {
                records[0] = records[1];
                records[1] = records[2];
                records[2] = record;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
