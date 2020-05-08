using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Lambda_Expressions
{
    public delegate int SecondaryDelegate ();
    public delegate int PrimaryDelegate (SecondaryDelegate [] delegates);
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            SecondaryDelegate[] array = new SecondaryDelegate[10]; // Создаём массив экземпляров класса делегата SecondaryDelegate и каждый делегат в этом массиве сообщаем с методом (с помощью лямбда-выражения), возвращающим случайное значение.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => rand.Next(100);                           //Lambda-Expression
            }

            PrimaryDelegate average = (SecondaryDelegate[] toAverage) =>
                {
                    int sum = 0;
                    for (int i = 0; i < toAverage.Length; i++)
                    {
                        sum += toAverage [i]();                           // On each element of array - invoke its method stored in delegate
                    }                                                     // ( "() => rand.Next(100);" )
                    return sum/ toAverage.Length;
                };
            int result = average(array);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
