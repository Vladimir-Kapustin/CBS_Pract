using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10, z = 15;

            // x += y >> x++ * z; 
            // z = ++x & y * 5; 
            // y /= x + 5 | z; 
            // z = x++ & y * 5; 
            // x = y << x++ ^ z;

            Console.WriteLine(x += y >> x++ * z);	// 5. Order: 1) * 2) >> 3) += 4) x++ (хоть постфиксный инкремент и самый приоритетный, но делает он свою операцию ТОЛЬКО после того, как х использован! А использован он уже при вычислении всего выражения.)
			Console.WriteLine(z = ++x & y * 5);		// 2. Order: 1) * 2) ++x 3) & 4) =
			Console.WriteLine(y /= x + 5 | z);		// 0. Order: 1) + 2) | 3) /= 
			Console.WriteLine(z = x++ & y * 5);		// 0. Order: 1) * 2) & 3) = 4) x++
			Console.WriteLine(x = y << x++ ^ z);	// 0. такое впечатление, что сначала идёт ^, а потом <<... хотя в документации наоборот...
		}															
	}																
}																	
