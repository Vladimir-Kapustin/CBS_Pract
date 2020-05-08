using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Indexers_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matr = new MyMatrix();

            matr.MakeMatrix(5, 6);
            matr.PrintMatrix();

            Console.ReadKey();

        }
    }
}
