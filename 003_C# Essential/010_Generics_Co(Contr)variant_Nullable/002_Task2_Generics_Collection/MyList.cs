using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Task2_Generics_Collection
{
    class MyList<T> : IMyList<T>  where T : new()   /*where T : new() - ограничение параметра типа Т, 
                                                    * означает что в качестве типа Т можно поставить 
                                                    * только тот тип у которого есть открытый конструктор 
                                                    * по умолчанию */
    {
        // объявление массива
        T[] array = null;
        // конструктор по умолчанию, устанавливающий размер массива
        public MyList (int arg)
        {
            array = new T[arg];
        }
        // метод добавления элемента
        public void Add(int index, T value)
        {
            if (index >= 0 && index < array.Length)
            {
                array[index] = value;
            }
            else
            {
                Console.WriteLine("Попытка ввести индекс, находящийся за пределами массива");
            }
            
        }
        // индексатор для получения значения элемента по указанному индексу
        public T this [int index]
        {
            get
            {
                if (index>=0 && index<array.Length)
                {
                    return array[index];
                }
                else
                {
                    Console.WriteLine("Попытка ввести индекс, находящийся за пределами массива");
                    return new T();
                }
            }
        }
        // свойство только для чтения для получения общего количества элементов.
        public int Length
        {
            get
            {
                return array.Length;
            }
        }
    }
}
