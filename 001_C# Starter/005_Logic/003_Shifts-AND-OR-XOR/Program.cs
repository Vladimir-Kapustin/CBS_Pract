using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10, z = 15;
            Console.WriteLine(x += y >> x++ * z);           // 5    порядок: *(++), >>, += (операторы назначения += идут последними!)
                                                            //      (инкремент расчитывается после использования х, но в дальнейшем расчёте выражения не считается)
            x = 5; y = 10; z = 15;
            Console.WriteLine(z = ++x & y * 5);             // 2    Порядок: ++, *, &
                                                            //      [0011 0010] = [50 Dec]  &
                                                            //      [0000 0110] = [6  Dec]  =
                                                            //      [0000 0010] = [2  Dec]
            x = 5; y = 10; z = 15;                          
            Console.WriteLine(y /= x + 5 | z);              // 0    (0.66666...) Порядок: +, |, /= (операторы назначения /= идут последними!)
                                                            //      [0000 1010] = [5  Dec]  |     
                                                            //      [0000 1111] = [15 Dec]  = 
                                                            //      [0000 1111] = [15 Dec]
            x = 5; y = 10; z = 15;
            Console.WriteLine(z = x++ & y * 5);             // 0    Порядок: ++(но ИКС исплользуется ДО инкремента!), *, &
                                                            //      [0011 0010] = [50 Dec]  &   
                                                            //      [0000 0101] = [5  Dec]  = 
                                                            //      [0000 0000] = [0  Dec]
            x = 5; y = 10; z = 15;
            Console.WriteLine(x = y << x++ ^ z);            // 335  [0000 1010] = [10 Dec] << 5 =
                                                            //      [0000 0001 0100 0000] = [320 Dec] ^
                                                            //      [0000 0000 0000 1111] = [15  Dec] =
                                                            //      [0000 0001 0100 1111] = [335 Dec]
            x = 100; y = 10; z = 15;
            Console.WriteLine(x = x >> 3 );                 // 12   Этого примера нет в задании - это мои эксперименты.
            Console.ReadKey();
        }
    }
}
