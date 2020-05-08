using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Generic_Dictionary_new
{
    interface IMyList<T>
    {
        void Add(T value);              //сигнатура метода для ввода значений в массив
        T this[int index] { get; }      //сигнатура индексатора
        int Count { get; }              //сигнатура свойства Length
    }

    class MyList<T> : IMyList<T>
    {
        T[] array;                          // array declaration

        public MyList()                     // default ctor, initializing the array
        {
            array = new T[0];
        }

        public void Add(T element)                  // Add - Method for adding elements
        {
            T[] tempArray = new T[array.Length + 1];// Создаём временный массив на 1 элемент больше чем действующий (для 
            for (int i = 0; i < array.Length; i++)  //добавления 1 входящего элемента)
            {
                tempArray[i] = array[i];            // Записываем весь действующий массив во временный массив
            }
            tempArray[array.Length] = element;      // Записываем новый элемент в последний элемент временного массива
            array = tempArray;                      // Присваиваем переменной основного массива весь временный массив.
        }

        public T this[int index]                    // Indexer - for getting elements by index
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }
                else
                {
                    Console.WriteLine("Попытка обращения к индексу, находящемуся за пределами массива");
                    return default(T);
                }
            }
        }

        public int Count { get { return array.Length; } }       // Property - for getting length of collection (array)

        public void Clear()                                     // Method - for clearing the collection.
        {
            array = new T[array.Length];
        }

        public override string ToString()
        {
            string stroka = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                stroka += array[i] + "\n";
            }
            return "Размерность массива:" + array.Length + "Элементы массива:\n" + stroka;
        }

        public bool Contains(T item)    //Метод-предикат предназначенный для поиска элемента в массиве
        {
            for (int i = 0; i < array.Length; i++)
            {
                if ((int)(object)array[i] == (int)(object)item)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
