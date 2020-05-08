using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka;
            Console.WriteLine("Insert some text");
            stroka = Console.ReadLine();

            Console.WriteLine("Insert color:\nblue\nblack\nred\ngreen\nyellow\nmagenta");
            string color = Console.ReadLine().ToLower();            // 2. поэтому лучше создать переменную int, а не string, и в неё запарсить введенную цифру с консоли. А потом отправить в метод.

            object element = Enum.Parse(typeof(EnumColor), color);  // 1. если ввести абракадабру, выдаст исключение: "запрошенное значение не найдено"
            EnumColor enumColor = (EnumColor)element;

            ColorPrinter.Print(stroka, (int)enumColor);

            Console.ReadKey();

        }
    }
}
