using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;       //--начиная с этого задания, здесь теперь будут не только те задания, которые я не сделал, когда 1-й раз проходил курс, но и будут повторяться, возможно не все... Проходя повторно курс, я расчитывал не делать снова все ДЗ, т.к. это долго, а поделать только те, которые не сделал в прошлый раз. А недостаток практики решил восполнять проходя короткие задания на тренажёре. Но, начиная с этого урока - 006 - тренажёр "прикрыли". Теперь придётся: 1) делать недоделанные задания, 2) делать выборочно (чтоб время сэкономить) домашние задания из оставшихся уроков.

namespace Task6_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert 1st operand");
            double operand1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert operation: +, -, *, /");
            string operation = Console.ReadLine();

            Console.WriteLine("Insert 2st operand");
            int operand2 = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "+":
                    Calculator.Add(operand1, operand2);
                    break;
                case "-":
                    Calculator.Subtract(operand1, operand2);
                    break;
                case "*":
                    Calculator.Multiply(operand1, operand2);
                    break;
                case "/":
                    Calculator.Divide(operand1, operand2);
                    break;
                default:
                    Console.WriteLine("Wrong operation character");
                    break;
            }

        }
    }

    public static class Calculator
    {
        public static void Add(double a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void Subtract(double a, int b)
        {
            Console.WriteLine(a - b);
        }

        public static void Multiply(double a, int b)
        {
            Console.WriteLine(a * b);
        }

        public static void Divide(double a, int b)
        {
            Console.WriteLine(Math.Round((a/b), 2));
        }
    }
}
