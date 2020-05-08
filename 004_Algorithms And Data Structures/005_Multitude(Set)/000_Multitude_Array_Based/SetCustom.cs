﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_Multitude_Array_Based
{
    class SetCustom : IEnumerable
    {
        object[] _array;
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//                      FROM HOMEWORK FROM LESSON 2 - DYNAMIC ARRAY. (CHANGED: ArrayList - is no more generic)                //
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        #region ctor without parameters
        public SetCustom() : this(0) { }
        #endregion

        #region ctor with parameters
        public SetCustom(int length)
        {
            _array = new object[length];
        }
        #endregion

        #region ctor with parameters
        public SetCustom(ICollection list) //ICollection<T> здесь нужен только потому, что в нём есть св-во Count, с помощью которого мы можем установить размер внутреннего массива ArrayList. Т.о. здесь можно использовать любой тип (речь пока не идёт о том, что можно добавлять одновременно элементы разного типа, а о том, что класс ArrayList можно закрывать любым типом), лишь бы в нём был Count. Или, если нет Count, то, если это массив, то использовать Length, либо, если список - то добавить в него св-во Count.
        {
            int index = 0;
            _array = new object[list.Count];

            foreach (var item in list)
            {
                _array[index++] = item;
                Count++;
            }
        }
	    #endregion

        #region Property Count for counting elements
        public int Count
        {
            get;
            set;
        }
        #endregion

        #region Method GetEnumerator - iterator (enumerator)
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _array[i];
            }
        }
        #endregion

        #region Method Add - adds new element to the end of array
        public void Add(object item)
        {
            if (_array.Length == 0 | _array.Length == Count)
            {
                GrowArray();
            }
            Console.WriteLine("Adding new item to the end: {0}", item);
            _array[Count++] = item;
        }
        #endregion

        #region Method GrowArray - for growing the array
        public void GrowArray()
        {
            int newSize = _array.Length == 0 ? newSize = 4 : newSize = _array.Length << 1;
            object[] tempArray = new object[newSize];
            _array.CopyTo(tempArray, 0);
            _array = tempArray;
        }
        #endregion

        #region Method Insert - inserts the element to array
        public void Insert(object item, int index)      // не буду проверять пустой ли массив - будем предполагать, что при создании эеземпляра он был заполнен, или, по крайней мере был использован метод Add
        {
            if (index > Count)
            {
                throw new IndexOutOfRangeException();
            }

            if (index == Count)    //проверка - если элемент просто хотят вставить в конец массива - просто вызывается Add
            {
                Add(item);
            }
            else if (_array.Length == Count)      //если ёмкости массива недостаточно
            {
                GrowArray();
                Console.WriteLine("\nInserting element {0} on position {1}", item, index);
                Array.Copy(_array, index, _array, index + 1, Count - index);
                _array[index] = item;
                Count++;
            }
            else                                // если ёмкости массива достаточно,то то же самое, но без увеличения массива
            {
                Console.WriteLine("\nInserting element {0} on position {1}", item, index);
                Array.Copy(_array, index, _array, index + 1, Count - index);
                _array[index] = item;
                Count++;
            }
        }
        #endregion        
        
        #region Method RemoveAt - removes the element from the specified index
        public void RemoveAt(int index)
        {
            if (index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                Console.WriteLine("\nRemoving element at index {0}: {1}", index, _array[index]);
                Array.Copy(_array, index + 1, _array, index, Count - (index + 1));  //здесь недостаток: когда он сдвигает эелементы влево - правый крайний элемент остаётся в массиве _array. Поскольку мы счётчик Count уменьшаем, то доступ к этому элементу через foreach не получить, однако в памяти он есть и даже не как мусор - его можно затереть только добавляя новые элементы в массив.
            }
            Count--;
        }
        #endregion

        #region Method Display - Printing the array
        public void Display()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.Write("  {0}", _array[i]);
            }
            Console.WriteLine("\t\telements: {0};\tlogical length - {1}", Count, _array.Length);
        }
        #endregion

        #region Method Remove - deleting specified value from the array
        public bool Remove(object item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_array[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Property "Item" - indexer for access to each element
        public object this[int index]
        {
            get
            {
                if (index >= Count | index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return _array[index];
                }
            }
            set
            {
                if (index > Count - 1 | index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    _array[index] = value;
                }
            }
        }
        #endregion

        #region Method IndexOf - searches the element and returns its index
        public int IndexOf(object item)
        {                           //В классе ArrayList такой метод возвращает "zero based" значение - либо он возвращает индекс элемента, либо, если его нет, то "-1".
            for (int i = 0; i < Count; i++)
            {
                if (_array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion

        #region Method Contains - predicate, determines the existance of the element
        public bool Contains(object item)
        {
            return IndexOf(item) != -1;
        }
        #endregion

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//                                       HOMEWORK FOR LESSON 5 - MULTITUDE (SET)                                              //
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////    
    
    
    
    }
}
