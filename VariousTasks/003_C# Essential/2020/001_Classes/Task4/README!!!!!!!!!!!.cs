using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	//class Figure							//--это моё первое решение. второе - на него натолкнуло решение в ответах. там используется массив для хранения точек. вроде как уменьшается количество строчек, и какое-никакое сокрытие происходит. Проход по массиву тоже сокращает количество строчек кода для подсчёта периметра. Первейшее правило программиста - сокращай! Есть много элементов одинаковых -заноси их в массив! Не держи по одному, организовывай всё в единую структуру/сущность. Потом по нему же будет легче проходиться циклом.
	//{
	//	string figureName;
	//	Point point1;
	//	Point point2;
	//	Point point3;
	//	Point point4;
	//	Point point5;

	//	public Figure(Point point1, Point point2, Point point3)
	//	{
	//		this.figureName = "Triangle";
	//		this.point1 = point1;
	//		this.point2 = point2;
	//		this.point3 = point3;
	//	}

	//	public Figure(Point point1, Point point2, Point point3, Point point4)
	//	{
	//		this.figureName = "Quadrangle";
	//		this.point1 = point1;
	//		this.point2 = point2;
	//		this.point3 = point3;
	//		this.point4 = point4;
	//	}

	//	public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
	//	{
	//		this.figureName = "Pentagon";
	//		this.point1 = point1;
	//		this.point2 = point2;
	//		this.point3 = point3;
	//		this.point4 = point4;
	//		this.point5 = point5;
	//	}

	//	double LengthSide(Point A, Point B)
	//	{
	//		return Math.Sqrt(((A.X - B.X) * (A.X - B.X)) + ((A.Y - B.Y) * (A.Y - B.Y)));
	//	}

	//	public void PerimeterCalculator()
	//	{
	//		switch (figureName)
	//		{
	//			case "Triangle":
	//				Console.WriteLine("the name of the figure is: {0}, and it`s perimeter: {1}", 
	//					figureName, 
	//					(LengthSide(point1, point2) + 
	//					LengthSide(point2, point3) + 
	//					LengthSide(point3, point1)));
	//				break;
	//			case "Quadrangle":
	//				Console.WriteLine("the name of the figure is: {0}, and it`s perimeter: {1}", 
	//					figureName, 
	//					(LengthSide(point1, point2) + 
	//					LengthSide(point2, point3) + 
	//					LengthSide(point3, point4) + 
	//					LengthSide(point4, point1)));
	//				break;
	//			case "Pentagon":
	//				Console.WriteLine("the name of the figure is: {0}, and  it`s perimeter: {1}", 
	//					figureName, 
	//					(LengthSide(point1, point2) + 
	//					LengthSide(point2, point3) + 
	//					LengthSide(point3, point4) + 
	//					LengthSide(point4, point5) + 
	//					LengthSide(point5, point1)));
	//				break;
	//			default:
	//				break;
	//		}
	//	}
	//}
}
