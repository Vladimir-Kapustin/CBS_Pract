using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//В классе MyClass перед методом Main() создайте статическую процедуру с именем WriteString со строковым параметром input, которая будет выводить в консоль с новой строки значение input, а затем в методе Main() вызовите эту процедуру с параметром "Hello! It's procedure".
namespace _7_1_Methods
{
    class Program
    {
        static void WriteString(string input)
        {
            Console.WriteLine(input);
        }

        static void Main(string[] args)
        {
            WriteString("Hello! It's procedure");
        }
    }
}
