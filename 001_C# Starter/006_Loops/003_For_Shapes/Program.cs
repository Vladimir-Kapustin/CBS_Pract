using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_For_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 5;
            int width = 10;

            # region Rectangle

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            # endregion

            # region Straight-Angle Triangle

            height = 10;    // увеличиваем высоту в 2 раза, чтоб треугольник стал больше (ширину не изменяем)

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            #region Equal-Sided Triangle

            for (int i = 0; i < height; i++)
            {
                for (int k = 1; k < width; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                    if (j > 0)
                    {
                        Console.Write("*");
                    }
                }
                width--;
                Console.WriteLine();
            }
            width = 10; // Ширина была обнулена на 60-й строке, так что возвращаем в первоначальное значение

            #endregion

            #region Rhombus

            for (int i = 0; i < height; i++)
            {
                for (int k = 1; k < width; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                    if (j > 0)
                    {
                        Console.Write("*");
                    }
                }
                width--;
                Console.WriteLine();
            }
            width = 10; // Ширина была обнулена на 84-й строке, так что возвращаем в первоначальное значение

            for (int i = 0; i < height - 1; i++)
            {
                for (int k = 0; k <= i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < width - 1; j++)
                {
                    Console.Write("*");
                    if (j > 0)
                    {
                     Console.Write("*");
                 }
             }
             width--;
             Console.WriteLine();
            }

            #endregion

            // Delay
            Console.ReadKey();
        }
    }
}