using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			Converter converter = new Converter(24.3, 27.05, 0.3575);

			Console.WriteLine(converter.ToEur(1000));

			Console.WriteLine(converter.EurToUah(1000));
		}
	}

	class Converter
	{
		double usd;
		double eur;
		double rub;

		public Converter(double usd, double eur, double rub)
		{
			this.usd = usd;
			this.eur = eur;
			this.rub = rub;
		}

		public double ToUsd(double amount)
		{
			return amount / usd;
		}

		public double ToEur(double amount)
		{
			return amount / eur;
		}

		public double ToRub(double amount)
		{
			return amount / rub;
		}

		public double UsdToUah(double amount)
		{
			return amount * usd;
		}

		public double EurToUah(double amount)
		{
			return amount * eur;
		}

		public double RubToUah(double amount)
		{
			return amount * rub;
		}

	}
}
