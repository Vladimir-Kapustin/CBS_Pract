using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Set_AVL_Based_Symmetric_Difference
{
    class Program
    {
        static void Show(Set<int> set)
        {
            foreach (int item in set)
            {
                Console.Write(item);
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 5, 6, 7, 8, 9 };
            
            Set<int> set1 = new Set<int>();
            Set<int> set2 = new Set<int>(array);
            Set<int> resultSet = new Set<int>();

            set1.Add(1);
            set1.Add(2);
            set1.Add(3);
            set1.Add(4);
            set1.Add(5);
            set1.Add(6);

            Console.Write("Set1: ");
            Show(set1);

            Console.Write("\tSet2: ");
            Show(set2);

            resultSet = set1.SymmetricExcept(set2);

            Console.Write("\tResultSet: ");
            Show(resultSet);
            
            Console.WriteLine();
        }
    }
}
