using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	class Program
	{
		static void Main(string[] args)
		{
			Invoice invoice = new Invoice(1345, "Ivan Petrov", "firma 'Firma'");

			invoice.Article = "Garden Scissors";
			invoice.Quantity = 10;

			//или так:
			//{Article = "Garden Scissors", Quantity = 10;}

			Console.WriteLine("Invoice #: {0}" +
								"\nCustomer: {1}" +
								"\nProvider: {2}" +
								"\nArticle: {3}" +
								"\nQuantity: {4}" +
								"\nPrice with VAT: {5}" +
								"\nPrice without VAT: {6}",
								invoice.Account,
								invoice.Customer,
								invoice.Provider,
								invoice.Article,
								invoice.Quantity,
								invoice.VATCalculator(true),
								invoice.VATCalculator(false));
		}
	}
}
