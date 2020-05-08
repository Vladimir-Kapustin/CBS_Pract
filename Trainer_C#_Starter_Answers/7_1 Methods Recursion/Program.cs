using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//В класс Program СРАЗУ после метода StringsSumLength поместите его перегруженную версию, которая будет принимать две строки s1 и s2 и возвращать их суммарную длину.
namespace _7_1_Methods_Recursion
{
    class Program
    {
        static int StringsSumLength(string s)
        {
            return s.Length;
        }

        static int StringsSumLength(string s1, string s2)
        {
            return (s1 + s2).Length;
        }

        static void Main(string[] args)
        {

        }
    }
}
