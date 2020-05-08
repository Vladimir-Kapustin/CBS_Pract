using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _002_IEnumerable_IEnumerator
{
    public interface IMyList<T>    // Это так, необязательно... в задании сказано "интерфейс взаимодействия". Вот здесь я и прописываю этот интерфейс. Другой класс может его реализовать.
    {
        void Add(T arg);
        T this[int index] { get; }
        int Count { get; }
        void Clear();
    }

    public class MyList<T>
    {
        T[] array;

        public MyList()
        {
            array = new T[0];
        }

        public void Add(T arg)
        {
            T[] tempArray = new T[array.Length + 1];
            
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            tempArray[tempArray.Length - 1] = arg;
            array = tempArray;

            // Можно ещё и так:
            //T[] tempArr = new T[array.Length + 1];    //Содание временного массива на единицу больше
            //array.CopyTo(tempArr, 0);                 //Копирование элементов массива во временный с нулевой позиции
            //tempArr[tempArr.Length - 1] = arg;        //В конец временного массива записываем добавляемый элемент
            //array = tempArr;
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
        // можно ещё добавить поле position и в GetEnumerator сбрасывать его с помощью Reset();
    }
}
