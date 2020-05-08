using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Что выведет на экран данный код?

namespace _7_3_Methods_Recursion
{
    class Program
    {
        static string GenerateEmailByName(string firstName = "Alex", string lastName = "Smith")
        {
            return String.Format("{0}.{1}@itvdn.com", firstName, lastName);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GenerateEmailByName());
            Console.WriteLine(GenerateEmailByName("Den"));
            Console.WriteLine(GenerateEmailByName(lastName: "Howard"));
            Console.ReadKey();
        }
    }
    /* Ответ
Alex.Smith@itvdn.com
Den.Smith@itvdn.com
Alex.Howard@itvdn.com
     */
}
