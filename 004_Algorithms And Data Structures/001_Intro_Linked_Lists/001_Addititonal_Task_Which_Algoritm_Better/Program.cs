using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Addititonal_Task_Which_Algoritm_Better
{
    class Program
    {
        static void Main(string[] args)
        {
            // T(n) = 20*n^2 +10    -   O(n^2)
            // T(n) = 500*n         -   O(n)

            // O(n) is better

            // But O(n^2) is better when 0 < n <= 24    -   then better is O(n) :

            // n	1	2	    3	    4	    5	    6	    7	    8	    9	    10	    11	    12	    13	    14	    15	    16	    17	    18	    19	    20	    21	    22	    23	    24	    25	    26	    27	    28	    29	    30
            // 1)	30	90	    190	    330	    510	    730	    990	    1290	1630	2010	2430	2890	3390	3930	4510	5130	5790	6490	7230	8010	8830	9690	10590	11530	12510	13530	14590	15690	16830	18010
            // 2)	500	1000	1500	2000	2500	3000	3500	4000	4500	5000	5500	6000	6500	7000	7500	8000	8500	9000	9500	10000	10500	11000	11500	12000	12500	13000	13500	14000	14500	15000
            //      470	910	    1310	1670	1990	2270	2510	2710	2870	2990	3070	3110	3110	3070	2990	2870	2710	2510	2270	1990	1670	1310	910	    470	    -10	    -530	-1090	-1690	-2330	-3010

        }
    }
}
