using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _003_MyDictionary
{
    public class MyList<T>
    {
        T[] array;

        public MyList()
        {
            array = new T[0];
        }

        public void Add(T arg)
        {
            T[] tempArr = new T[array.Length + 1];      //Содание временного массива на 1 элемент больше
            array.CopyTo(tempArr, 0);                   //Копирование элементов массива во временный с нулевой позиции
            tempArr[tempArr.Length - 1] = arg;          //В конец временного массива записываем добавляемый элемент
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

        public IEnumerator<T> GetEnumerator() // Не обязательно классу MyList<T> реализовывать IEnumerable и прочие интерфейсы - для использования в foreach достаточно наличия в классе метода, который возвращает IEnumerator
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                yield return array[i];
            }
        }
        // можно ещё добавить поле position=-1 и в GetEnumerator() сбрасывать его с помощью Reset();
    }
}
