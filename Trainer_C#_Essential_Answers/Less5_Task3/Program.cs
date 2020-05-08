using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                        //Создайте индексатор с методами доступа get и set для класса MyClass, который будет проверять, выходит ли индекс за диапазон массива. В случае, если выходит – геттер будет возвращать строку "index out of range", а сеттер – просто не выполнять присвоение.
namespace Less5_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            Console.WriteLine(instance[2]);
            //выход за пределы массива
            Console.WriteLine(instance[10]);

            Console.ReadKey();
        }
    }

    class MyClass
    {
        string[] array = new string[3] { "one", "two", "three" };

        public string this[int index]
        {
            get
            {
                if (index < 0 || index > 2)
                    return "index out of range";

                return array[index];
            }
            set
            {
                if (index >= 0 && index < 3)
                    array[index] = value;
            }
        }
    }
}
