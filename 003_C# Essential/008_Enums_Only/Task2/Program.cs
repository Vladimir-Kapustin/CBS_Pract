using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public enum Colors  // Сначала посмотреть своё решение - потом читать комментарии.
    {
        None,
        Black,
        White,
        Red,
        Yellow,
        Blue,
        Green,
        Grey
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку и номер цвета (от 0 до 7)");
            Paint.Print(Console.ReadLine(), Int32.Parse(Console.ReadLine()));
        }
    }

    public static class Paint
    {
        public static void Print(string stroka, int color)
        {
            if (!Enum.IsDefined(typeof(Colors), color))             // 4. Это можно было в default (оно и понятно по логике) опустить.
            {
                Console.WriteLine("Выбранный цвет недопустим");
                return;
            }
            
            Console.WriteLine("The corresponding color to your choice is: {0} ", (Colors)color);
            
            switch (color)
            {
                case 0:                                                     
                    goto default;
                case 1: // лучше так: case (int)Colors.Black: ConsoleCoor.ForegroundColor.Black;    // 3. а здесь можно было писать само перечисление и константу и приводить к int - саму константу цвета из нашего перечисления мы не приравняем к Console.ForegroundColor - это невозможно, но для удобочитаемости самого кода, мы можем привести перечисления к int и в блоке case выбрать соответствющий цвет из ForegroundColor:  case (int)Colors.Black: ConsoleCoor.ForegroundColor.Black; К тому же приведение само определит цифру для case - а вдруг мы определили в перечислении отфанарные значения?
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    goto default;   //лучше break;                          // 2. а здесь можно было ставить брейк, как обычно; goto лучше избегать.
                case 2:
                    Console.ForegroundColor = ConsoleColor.White;
                    goto default;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    goto default;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    goto default;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    goto default;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Green;
                    goto default;
                case 7:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    goto default;
                default:
                    Console.WriteLine("Your string is: {0} ", stroka);      // 1. это можно было за пределы свича опустить, ведь в дефолте выполняется действие, если ни один кейс не произошёл, т.е. неправильно отсылать все кейсы на дефолт через goto.
                    Console.ResetColor();
                    // сюда лучше было записать вот так (вместо верхнего блока на 34 стр.):
                    // Console.WriteLine("Выбранный цвет недопустим");
                    break;
            }
            // лучше так (вместо того, что написано в default на 69 стр.):
            // Console.WriteLine("Your string is: {0} ", stroka);
            // Console.ResetColor();
        }
    }
}
