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
			Figure figure = new Figure(new Point(10, 10, "A"), new Point(20, 30, "B"), new Point(30, 20, "C"));

			figure.PerimeterCalculator();

			Figure figure1 = new Figure(new Point(10, 10, "A"), new Point(20, 30, "B"), new Point(30, 20, "C"), new Point(20, 0, "D"));

			figure1.PerimeterCalculator();

			Figure figure2 = new Figure(new Point(10, 10, "A"), new Point(20, 30, "B"), new Point(30, 20, "C"), new Point(20, 0, "D"), new Point(15, -10, "E"));

			figure2.PerimeterCalculator();

		}
	}
}
