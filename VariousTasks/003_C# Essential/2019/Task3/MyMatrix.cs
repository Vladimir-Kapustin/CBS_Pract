using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MyMatrix
    {
        int[][] array;
        Random random = new Random();

        //пользовательский конструктор, заполняющий матрицу
        public MyMatrix(int row, int column)
        {
            array = new int[row][];

            for (int i = 0; i < row; i++)
            {
                array[i] = new int[column];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = random.Next(0, 100);
                }
            }
        }

        //индексатор
        public int this[int row, int column]
        {
            get
            {
                if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array[row].Length)
                {
                    return array[row][column];
                }
                else
                {
                    Console.WriteLine("Попытка обращения за пределы массива");
                    return 0;
                }
            }
            set
            {
                if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array[row].Length)
                {
                    array[row][column] = value;
                }
                else
                {
                    Console.WriteLine("Попытка обращения за пределы массива");
                }
            }
        }

        //вывод матрицы на экран
        public void Show()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write("{0} ", array[i][j]);
                }
                Console.WriteLine();
            }
        }
        
        //изменение размеров матрицы
        public void ChangeSize(int newRow, int newColumn)
        {
            if (newRow <= 0 || newColumn <= 0)
                Console.WriteLine("Неверно задан размер матрицы");

            int[][] tempArray = new int[newRow][];
            for (int i = 0; i < newRow; i++)
            {
                tempArray[i] = new int[newColumn];
                for (int j = 0; j < newColumn; j++)
                {
                    if (i >= array.GetLength(0))
                    {
                        tempArray[i][j] = random.Next(0, 100);
                        continue;
                    }
                    if (j >= array[i].Length)
                    {
                        tempArray[i][j] = random.Next(0, 100);
                        continue;
                    }
                    tempArray[i][j] = array[i][j];
                }
            }
            array = tempArray;
        }

        //отображение части матрицы
        public void ShowPart(int row, int column, int endRow, int endColumn)
        {
            if (row < 0 || column < 0 || endRow < 0 || endColumn < 0 || row >= array.GetLength(0) || 
                column >= array[row].Length || endRow >= array.GetLength(0) || endColumn >= array[endRow].Length)
            {
                Console.WriteLine("Попытка обращения за пределы массива");
                return;
            }

            for (int i = row; i <= endRow; i++)
            {
                for (int j = column; j <=endColumn; j++)
                {
                    Console.Write("{0} ", array[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
