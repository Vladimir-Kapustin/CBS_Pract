using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Extended_Method_For_Task2
{
    public class MyList<T>                                 /*where T : new() - ограничение параметра типа Т, 
                                                            * означает что в качестве типа Т можно поставить 
                                                            * только тот тип у которого есть открытый конструктор 
                                                            * по умолчанию */
    {

        T[] array;                                  // объявление массива
        int length;

        public MyList(int arg)                      // конструктор по умолчанию, устанавливающий размер массива
        {
            array = new T[arg];
            length = arg;
        }

        public void Add(int index, T value)         // метод добавления элемента
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

        public T this[int index]                    // индексатор для получения значения элемента по указанному индексу
        {
            get
            {
                 return array[index];
            }
        }

        public int Length                           // свойство только для чтения для получения общего количества элементов.
        {
            get
            {
                return length;
            }
        }
    }
}
