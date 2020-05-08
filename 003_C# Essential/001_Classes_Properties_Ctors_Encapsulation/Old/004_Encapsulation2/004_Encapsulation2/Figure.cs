using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Encapsulation2
{
    class Figure
    {
        string name;
        Point point1 = null;
        Point point2 = null;
        Point point3 = null;
        Point point4 = null;
        Point point5 = null;
        public Figure(Point point1, Point point2, Point point3)
        {
            name = "triangle";
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            
        }
        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            name = "rectangle";
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
        }
        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            name = "pentagon";
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
            this.point5 = point5;
        }
        double LengthSide (Point A, Point B)
        {
            double a2 = (B.X - A.X) * (B.X - A.X);
            double b2 = (B.Y - A.Y) * (B.Y - A.Y);
            return Math.Sqrt(a2 + b2);
        }
        public void PerimeterCalculator ()
        {
           if (point4 == null)
           {
               Console.WriteLine("Perimeter of {0} is {1}", name,
               LengthSide(point1, point2) +
               LengthSide(point2, point3) +
               LengthSide(point3, point1)
               );
           }
           else if (point5 == null)
           {
               Console.WriteLine("Perimeter of {0} is {1}", name,
               LengthSide(point1, point2) +
               LengthSide(point2, point3) +
               LengthSide(point3, point4) +
               LengthSide(point4, point1)
               );
           }
           else
           {
               Console.WriteLine("Perimeter of {0} is {1}", name,
               LengthSide(point1, point2) +
               LengthSide(point2, point3) +
               LengthSide(point3, point4) +
               LengthSide(point4, point5) +
               LengthSide(point5, point1)
               );
           }
            
        }
    }
}
