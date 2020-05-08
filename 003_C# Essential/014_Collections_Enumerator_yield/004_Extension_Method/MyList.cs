using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _004_Extension_Method
{
    public class MyList<T> : IEnumerable<T>
    {
        T[] array;
        int position = -1;

        public MyList()
        {
            array = new T[0];
        }

        public void Add(T arg)
        {
            T[] tempArr = new T[array.Length + 1];    //Содание временного массива на единицу больше
            array.CopyTo(tempArr, 0);                 //Копирование элементов массива во временный с нулевой позиции
            tempArr[tempArr.Length - 1] = arg;        //В конец временного массива записываем добавляемый элемент
            array = tempArr;
        }

        public T this[int index]        //indexer - get element from collection
        {
            get { return array[index]; }
        }

        public int Count                //Property - returns length of collection
        {
            get { return array.Length; }
        }

        public void Clear()
        {
            array = new T[0];
        }

        public void Reset()
        {
            position = -1;
        }
        // Реализация GetEnumerator с методом Reset()
        public IEnumerator<T> GetEnumerator() // Не обязательно классу MyList<T> реализовывать IEnumerable и прочие интерфейсы - для использования в foreach достаточно наличия в классе метода, который возвращает IEnumerator
        {
            while (true)     //реализация GetEnumerator с полем position
            {
                if (position < Count-1)
                {
                    position++;
                    yield return array[position];
                }
                else                // если position вышел за пределы
                {
                    Reset();        // обнуляем счётчик
                    yield break;    // а это чтобы вышел из цикла - цикл-то бесконечный.
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
