using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Indexers_Matrix
{
    class MyMatrix
    {
        //TODO - доделать задачу.
        int[,] matrix;
        Random rand = new Random();

        public void MakeMatrix(int x, int y)
        {
            matrix = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix[i, j] = rand.Next(99);
                }
            }
        }
        public void PrintMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrix[i, j] = rand.Next(99)); 
                }
                Console.WriteLine();
            }
        }

        public void ChangeMatrix(int x, int y)
        {

        }

        public int this[int index1, int index2]
        {
            get
            {
                return matrix[index1, index2];
            }
            set
            {
                matrix[index1, index2] = value;
            }
        }
    }
}
