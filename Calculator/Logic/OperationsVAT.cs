using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsVAT
{
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
}
