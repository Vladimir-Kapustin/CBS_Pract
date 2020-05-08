using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте индексатор с методом доступа get для класса MyClass, который будет возвращать элементы массива array по индексу типа int.
namespace Less5_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            Console.WriteLine(instance[6]);

            Console.ReadKey();
        }
    }

    class MyClass
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
    }
}
