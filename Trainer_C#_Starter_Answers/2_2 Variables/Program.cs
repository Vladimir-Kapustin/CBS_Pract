using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Поставьте там, где это действительно необходимо, операторы явного преобразования типа (кастинга), чтобы код стал работающим
namespace _2_2_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 256;
            double d = a;
            short b = (short)a;

            char c = 't';
            byte c2 = (byte)c;
            ushort c3 = c;
        }
    }
}
