using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//В теле метода Main создайте две переменные: первую – с именем s типа string и значением "Hi, everybody", вторую – с именем c типа char и значением ‘R’. После этого выведите в консоль по очереди значения этих переменных так, чтобы каждое значение было с новой строки. Считайте, что пространство имен System уже подключено.
namespace _1_3_Machine_Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hi, everybody";
            char c = 'R';
            Console.WriteLine(s);
            Console.WriteLine(c);
        }
    }
}
