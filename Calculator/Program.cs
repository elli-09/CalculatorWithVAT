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
        public void ShowHistory()
        {
            if (count == 0)
            {
                Console.WriteLine("History is empty.");
            }
            else
            {
                Console.WriteLine("Last operations:");

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(records[i]);
                }
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double result = 0;

            Operations op = new Operations();
            OperationsVAT opVAT = new OperationsVAT();
            History history = new History();

            string command = "";
            string option = "";

            Console.WriteLine("Welcome! This is my calculator.");

            while (command != "4")
            {
                Console.WriteLine();
                Console.WriteLine("Please, choose an option:");
                Console.WriteLine("1. For calculator");
                Console.WriteLine("2. For calculator with VAT");
                Console.WriteLine("3. History");
                Console.WriteLine("4. Exit");

                try
                {
                    command = Console.ReadLine();

                    if (command == "1")
                    {
                        option = "";

                        while (option != "7")
                        {
                            Console.WriteLine();
                            Console.WriteLine("You are in Calculator.");
                            Console.WriteLine("Please, choose an option:");
                            Console.WriteLine("1. Addition");
                            Console.WriteLine("2. Subtraction");
                            Console.WriteLine("3. Multiplication");
                            Console.WriteLine("4. Division");
                            Console.WriteLine("5. Procents");
                            Console.WriteLine("6. Division with Procents");
                            Console.WriteLine("7. Exit");

                            option = Console.ReadLine();

                            if (option == "1" || option == "2" ||
                                option == "3" || option == "4" ||
                                option == "5" || option == "6")
                            {
                                Console.WriteLine("Enter the first number:");
                                a = double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter the second number:");
                                b = double.Parse(Console.ReadLine());

                                bool valid = true;
                                string record = "";

                                if (option == "1")
                                {
                                    result = op.Addition(a, b);
                                    record = a + " + " + b + " = " + result;
                                }
                                else if (option == "2")
                                {
                                    result = op.Subtraction(a, b);
                                    record = a + " - " + b + " = " + result;
                                }
                                else if (option == "3")
                                {
                                    result = op.Multiplication(a, b);
                                    record = a + " * " + b + " = " + result;
                                }
                                else if (option == "4")
                                {
                                    if (b != 0)
                                    {
                                        result = op.Division(a, b);
                                        record = a + " / " + b + " = " + result;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You cannot divide by zero!");
                                        valid = false;
                                    }
                                }
                                else if (option == "5")
                                {
                                    result = op.Procents(a, b);
                                    record = b + "% of " + a + " = " + result;
                                }
                                else if (option == "6")
                                {
                                    if (b != 0)
                                    {
                                        result = op.DivisionWithProcents(a, b);
                                        record = a + " % " + b + " = " + result;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You cannot divide by zero!");
                                        valid = false;
                                    }
                                }

                                if (valid)
                                {
                                    Console.WriteLine("The result is: " + result);
                                    history.AddRecord(record);
                                }
                            }
                            else if (option == "7")
                            {
                                Console.WriteLine("Returning to main menu.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid option!");
                            }
                        }
                    }
                    else if (command == "2")
                    {
                        option = "";

                        while (option != "6")
                        {
                            Console.WriteLine();
                            Console.WriteLine("You are in Calculator with VAT.");
                            Console.WriteLine("Please, choose an option:");
                            Console.WriteLine("1. Calculate VAT");
                            Console.WriteLine("2. Add VAT");
                            Console.WriteLine("3. Remove VAT");
                            Console.WriteLine("4. Calculate Discount");
                            Console.WriteLine("5. Apply Discount");
                            Console.WriteLine("6. Exit");

                            option = Console.ReadLine();

                            if (option == "1" || option == "2" ||
                                option == "3" || option == "4" ||
                                option == "5")
                            {
                                Console.WriteLine("Enter the amount:");
                                a = double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter the percentage:");
                                b = double.Parse(Console.ReadLine());

                                bool valid = true;
                                string record = "";

                                if (option == "1")
                                {
                                    result = opVAT.CalculateVAT(a, b);
                                    record = "VAT: " + b + "% of " + a + " = " + result;
                                }
                                else if (option == "2")
                                {
                                    result = opVAT.AddVAT(a, b);
                                    record = "Add VAT: " + a + " + " + b + "% = " + result;
                                }
                                else if (option == "3")
                                {
                                    if (b != -100)
                                    {
                                        result = Math.Round(opVAT.RemoveVAT(a, b),2);
                                        record = "Remove VAT: " + a + ", " + b + "% = " + result;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid VAT percentage!");
                                        valid = false;
                                    }
                                }
                                else if (option == "4")
                                {
                                    result = opVAT.CalculateDiscount(a, b);
                                    record = "Discount: " + b + "% of " + a + " = " + result;
                                }
                                else if (option == "5")
                                {
                                    result = opVAT.ApplyDiscount(a, b);
                                    record = "Apply Discount: " + a + " - " + b + "% = " + result;
                                }

                                if (valid)
                                {
                                    Console.WriteLine("The result is: " + result);
                                    history.AddRecord(record);
                                }
                            }
                            else if (option == "6")
                            {
                                Console.WriteLine("Returning to main menu.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid option!");
                            }
                        }
                    }
                    else if (command == "3")
                    {
                        Console.WriteLine("You chose History.");
                        history.ShowHistory();
                    }
                    else if (command == "4")
                    {
                        Console.WriteLine("Goodbye!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid option!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error! Please enter a valid number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error! The number is too large or too small.");
                }
            } 
        }     
    }         
}             




