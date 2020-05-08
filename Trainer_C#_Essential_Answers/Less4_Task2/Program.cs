using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                        //Проверка, как работают конструкторы абстрактных классов. Напишите в редактор, что будет выведено на экран в результате выполнения кода:
namespace Less4_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA instance = new ClassB();

            Console.ReadKey();
        }
    }

    abstract class ClassA
    {
        public ClassA()
        {
            Console.Write(1);
        }
    }

    class ClassB : ClassA
    {
        public ClassB()
        {
            Console.Write(2);
        }
    }
}

/* Ответ:
12
 */
