using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                        // Проверка, действительно ли все классы наследуются от Object
                                        // Напишите в редактор кода, что будет выведено на экран в результате выполнения данной программы:

namespace Less3_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (new MyClass() is Object)
            {
                Console.WriteLine("I'm object!");
            }
            else
            {
                Console.WriteLine("I’m not object!");
            }

            Console.ReadKey();
        }
    }

    class MyClass { }
}
/* Ответ:
 
I'm object! 

*/
