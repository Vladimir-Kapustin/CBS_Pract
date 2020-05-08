using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_yield
{
    class MyCollection<T>
    {
        // fields or attributes
        int position = -1;
        T[] array;
        int current = 0;

        // implementation of enumerator
        public T Current
        {
            get { return array[position]; }         //  - это я слэшиками поотмечал места, где ошибки.
        }

        public bool MoveNext()
        {
            if (position < array.Length - 1)        // OK
            {
                position++;
                return true;
            }
            return false;                           // (else - ?)
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
            Reset();
        }

        public T this[int index]    // indexer
        {
            get { return array[index]; }
        }

        // implementation of collection

        public MyCollection()       //ctor
        {
            array = new T[0];
        }

        public void Add(T item)
        {
            if (array.Length == 0 || current == array.Length - 1)
            {
                array = GrowArray(array);
            }

            array[current] = item;
            current++;
            Count++;
        }

        public T[] GrowArray(T[] array)
        {
            int capacity = array.Length == 0 ? 4 : array.Length * 2;

            T[] tempArray = new T[capacity];
            for (int i = 0; i < array.Length - 1; i++)
            {
                tempArray[i] = array[i];
            }
            return tempArray;
        }

        public void Clear()
        {
            array = new T[0];
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (item.Equals(array[i]))
                    return true;
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            T[] tempArray = new T[array.Length];
            for (int i = 0; i < array.Length - 1; i++)
            {
                tempArray[i] = array[i];
            }
            array = tempArray;
        }

        public int Count
        {
            get;
            set;
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i <= Count - 1; i++)
            {
                yield return array[i];
            }
        }
    }
}
