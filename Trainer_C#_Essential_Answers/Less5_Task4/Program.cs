using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                            //Создайте двумерный индексатор с методом доступа get для класса MyClass, который будет принимать целочисленный и строковой индексы и будет возвращать конкатенацию строкового индекса и соответствующего элемента массива (без пробела!), который будет найден по обычному целочисленному индексу. Проверки за выход диапазона массива можно не делать.
namespace Less5_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            Console.WriteLine(instance[6, " six"]);
            Console.WriteLine(instance[4, " fourth item"]);

            Console.ReadKey();
        }
    }

    class MyClass
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public string this[int index, string value]
        {
            get
            {
                return value + array[index];                //вот этот вариант прокатил, тренажёр его "съел", но он показывает неправльный результат: six7 и fourth item5 (а должен быть six6 и fourth item4)
                // был первый ответ: return string.Format(value + array[index - 1]);
            }
        }
    }
}
