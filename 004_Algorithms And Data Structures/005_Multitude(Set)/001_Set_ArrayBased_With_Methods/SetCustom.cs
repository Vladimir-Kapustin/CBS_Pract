using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Set_ArrayBased_With_Methods
{
    class SetCustom : IEnumerable
    {
        object[] _items;
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//                      FROM HOMEWORK FROM LESSON 2 - DYNAMIC ARRAY. (CHANGED: ArrayList - is no more generic)                //
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        #region ctor - without parameters
        public SetCustom() : this(0) { }
        #endregion

        #region ctor - with parameters
        public SetCustom(int length)
        {
            _items = new object[length];
        }
        #endregion

        #region ctor - with parameters
        public SetCustom(ICollection list) //ICollection<T> здесь нужен только потому, что в нём есть св-во Count, с помощью которого мы можем установить размер внутреннего массива ArrayList. Т.о. здесь можно использовать любой тип (речь пока не идёт о том, что можно добавлять одновременно элементы разного типа, а о том, что класс ArrayList можно закрывать любым типом), лишь бы в нём был Count. Или, если нет Count, то, если это массив, то использовать Length, либо, если список - то добавить в него св-во Count.
        {
            int index = 0;
            _items = new object[list.Count];

            foreach (var item in list)
            {
                if (item!=null)
                {
                    _items[index++] = item;
                    Count++;
                }
            }
        }
	    #endregion

        #region Property Count - for counting elements
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
                yield return _items[i];
            }
        }
        #endregion

        #region Method Add - adds new element to the end of array
        public void Add(object item)
        {
            if (_items.Length == 0 | _items.Length == Count)
            {
                GrowArray();
            }
            Console.WriteLine("Adding new item to the end: {0}", item);
            _items[Count++] = item;
        }
        #endregion   

        #region Method GrowArray - for growing the array
        public void GrowArray()
        {
            int newSize = _items.Length == 0 ? newSize = 4 : newSize = _items.Length << 1;
            object[] tempArray = new object[newSize];
            _items.CopyTo(tempArray, 0);
            _items = tempArray;
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
            else if (_items.Length == Count)      //если ёмкости массива недостаточно
            {
                GrowArray();
                Console.WriteLine("\nInserting element {0} on position {1}", item, index);
                Array.Copy(_items, index, _items, index + 1, Count - index);
                _items[index] = item;
                Count++;
            }
            else                                // если ёмкости массива достаточно,то то же самое, но без увеличения массива
            {
                Console.WriteLine("\nInserting element {0} on position {1}", item, index);
                Array.Copy(_items, index, _items, index + 1, Count - index);
                _items[index] = item;
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
                Console.WriteLine("\nRemoving element at index {0}: {1}", index, _items[index]);
                Array.Copy(_items, index + 1, _items, index, Count - (index + 1));  //здесь недостаток: когда он сдвигает эелементы влево - правый крайний элемент остаётся в массиве _array. Поскольку мы счётчик Count уменьшаем, то доступ к этому элементу через foreach не получить, однако в памяти он есть и даже не как мусор - его можно затереть только добавляя новые элементы в массив.
            }
            Count--;
        }
        #endregion

        #region Method Display - Printing the array
        public void Display()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.Write("  {0}", _items[i]);
            }
            Console.WriteLine("\t\telements: {0};\tlogical length - {1}", Count, _items.Length);
        }
        #endregion

        #region Method Remove - deleting specified value from the array
        public bool Remove(object item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_items[i].Equals(item))
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
                    return _items[index];
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
                    _items[index] = value;
                }
            }
        }
        #endregion

        #region Method IndexOf - searches the element and returns its index
        public int IndexOf(object item)
        {                           //В классе ArrayList такой метод возвращает "zero based" значение - либо он возвращает индекс элемента, либо, если его нет, то "-1".
            for (int i = 0; i < Count; i++)
            {
                if (_items[i].Equals(item))
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

        //Adding elements to the Set - see above (Method Add)

        #region Method AddRange - adds new set of elements to the existing set
        public void AddRange(IEnumerable range)
        {
            foreach (var item in range)
            {
                Add(item);
            }
        }
        #endregion

        //Deleting elements from the Set - see above (Method Remove)

        //Determining the existance of the element in the Set - see above (Method Contains)

        //Number of elements in the Set - see above (Property Count)

        //Enumerator - see above (Method GetEnumerator)

        #region Method Union - unions two sets
        public SetCustom Union(SetCustom other)
        {
            SetCustom result = new SetCustom(_items);
            foreach (var item in other)
            {
                if (!Contains(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        #endregion

        #region Method ExceptWith - returns difference between two sets
        public SetCustom ExceptWith(SetCustom other)
        {
            SetCustom result = new SetCustom(_items);
            foreach (var item in other)
            {
               result.Remove(item);
            }
            return result;
        }
        #endregion

        #region Method IntersectWith - returns an intersection of two stes
        public SetCustom IntersectWith(SetCustom other)
        {
            SetCustom result = new SetCustom();
            foreach (var item in _items)
            {
                if (other.Contains(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        #endregion

        #region Method SymmetricExceptWith - returns symmetric difference between two sets
        public SetCustom SymmetricExceptWith(SetCustom other)
        {
            SetCustom union = Union(other);
            SetCustom intersect = IntersectWith(other);
            return union.ExceptWith(intersect);
        }
        #endregion

        #region Method Subset - predicate, determines whether the current set is a subset of another set
        public bool Subset(SetCustom other)
        {
            SetCustom result = new SetCustom(_items);
            foreach (var item in other._items)
            {
                    result.Remove(item);
            }

            if (result==null)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        #endregion
    }
}
