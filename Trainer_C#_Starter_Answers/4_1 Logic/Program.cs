using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите в редакторе кода результат выполнения следующей программы:

namespace _4_1_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            bool trueVal = true, falseVal = false;

            Console.WriteLine(trueVal && falseVal);
            Console.WriteLine(trueVal || falseVal);
            Console.WriteLine(trueVal && !falseVal);        //Это текст задания - можно запустить и увидеть ответ.
            Console.WriteLine(!trueVal || falseVal);
            Console.WriteLine(!trueVal);
            Console.WriteLine(trueVal ^ falseVal);
            Console.WriteLine(trueVal && !falseVal);
        }
    }
/* Ответ
 
false            
true            
true            
false                                                     
false            
true            
true            

 */
}
