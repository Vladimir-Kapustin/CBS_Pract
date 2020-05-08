using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	class Figure
	{
		string figureName;
		Point[] pointArray;

		public Figure(Point point1, Point point2, Point point3)
		{
			this.figureName = "Triangle";
			pointArray = new Point[] { point1, point2, point3 };
		}

		public Figure(Point point1, Point point2, Point point3, Point point4)
		{
			this.figureName = "Quadrangle";
			pointArray = new Point[] { point1, point2, point3, point4 };
		}

		public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
		{
			this.figureName = "Pentagon";
			pointArray = new Point[] { point1, point2, point3, point4, point5};
		}

		double LengthSide(Point A, Point B)
		{
			return Math.Sqrt(((A.X - B.X) * (A.X - B.X)) + ((A.Y - B.Y) * (A.Y - B.Y)));
		}

		public void PerimeterCalculator()
		{
			double sum = 0;
			for (int i = 0; i < pointArray.Length-1; i++)
			{
				sum += LengthSide(pointArray[i], pointArray[i + 1]);
			}
			sum += LengthSide(pointArray[pointArray.Length - 1], pointArray[0]);

			Console.WriteLine("the name of the figure is: {0}, and it`s perimeter: {1}",
						figureName, sum);
		}
	}
}
