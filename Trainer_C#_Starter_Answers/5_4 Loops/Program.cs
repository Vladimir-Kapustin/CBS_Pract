using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Найдите и исправьте ошибки в коде. Метод Console.ReadKey должен вызываться после завершения работы цикла!
namespace _5_4_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            short sh = 305;
            while (sh <= 400)
            {
                Console.Write("{0} <= 400", sh);
                sh++;
            }

            Console.ReadKey();  
        }
    }
}
