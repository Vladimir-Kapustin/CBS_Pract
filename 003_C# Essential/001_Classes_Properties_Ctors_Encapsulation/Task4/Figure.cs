using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4     //В отличие от старого варианта, где работа к-ров сведена к минимуму - там только инициализируются поля - здесь в к-рах инициализируется только 2 поля и ведётся расчёт периметров... Но зато в классе меньше полей, а также нет условных конструкций в методе PetimeterCalculator(), а значит меньше памяти использовано. Авторы сделали немного другое решение :), создав массив элементов Point и делая его размер и добавляя в него элементы в зависимости от конструктора. Получилось немного лаконичнее.
{
    class Figure
    {
        private string name;
        private double perimeter = 0;
        
        public Figure(Point point1, Point point2, Point point3)
        {
            this.name = "Triangle";
            perimeter = LengthSide(point1, point2) + LengthSide(point2, point3) + LengthSide(point3, point1);
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            this.name = "Rectangle";
            perimeter = LengthSide(point1, point2) + LengthSide(point2, point3) + LengthSide(point3, point4) + LengthSide(point4, point1);
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            this.name = "Pentagon";
            perimeter = LengthSide(point1, point2) + LengthSide(point2, point3) + LengthSide(point3, point4) + LengthSide(point4, point5) + LengthSide(point5, point1);
        }


        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((A.X - B.X),2) + Math.Pow((A.Y - B.Y),2));
        }

        public void PerimeterCalculator()
        {
            Console.WriteLine("The Perimeter of {0} is {1}", name, perimeter);
        }
    }
}
