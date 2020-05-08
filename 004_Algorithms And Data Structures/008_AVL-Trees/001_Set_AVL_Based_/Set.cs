using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Set_AVL_Based_Symmetric_Difference
{
    public class Set<T> : IEnumerable<T> where T : IComparable<T>
    {
        private readonly AVLTree<T> _items = new AVLTree<T>(); 

        #region Конструктор по умолчанию и пользовательский, добавляющий сразу несколько элементов
        public Set()
        {

        }

        public Set(IEnumerable<T> range)    
        {
            AddRange(range);
        }

        #endregion

        #region Добавление элементов во множество
        public void Add(T value)
        {
            if (_items.Contains(value))
            {
                throw new InvalidOperationException("Такое значение уже содержится в множестве");
            }
            _items.Add(value);
        }
        #endregion

        #region Добавление нового множества элементов
        public void AddRange(IEnumerable<T> range)
        {
            foreach (T item in range)
            {
                Add(item);
            }
        }
        #endregion

        #region Удаение элементов из множества
        public bool Remove(T value)
        {
            return _items.Remove(value);
        }

        #endregion

        #region Проверка наличия элементов во множестве
        public bool Contains(T value)
        {
            return _items.Contains(value);
        }
        #endregion

        #region Количество элементов во множестве
        public int Count ()
        {
            return _items.Count;
        }
        #endregion

        #region Итератор
        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }
        #endregion

        #region Объединение множеств
        public Set<T> Union(Set<T> set)
        {
            Set<T> newSet = new Set<T>(_items);
            foreach (T item in set)
            {
                if (!Contains(item))
                {
                    newSet.Add(item);
                }
            }
            return newSet;
        }
        #endregion

        #region Разность множеств
        public Set<T> Except(Set<T> set)
        {
            Set<T> newSet = new Set<T>(_items);
            foreach (T item in set)
            {
                newSet.Remove(item);
            }
            return newSet;
        }
        #endregion

        #region Пересечение множеств
        public Set<T> Intersect(Set<T> set)
        {
            Set<T> newSet = new Set<T>();
            foreach (T item in set)
            {
                if (Contains(item))
                {
                    newSet.Add(item);
                }
            }
            return newSet;
        }
        #endregion

        #region Симметрическая разность множеств
        public Set<T> SymmetricExcept(Set<T> set)
        {
            Set<T> union = Union(set);
            Set<T> intersect = Intersect(set);
            Set<T> newSet = union.Except(intersect);
            return newSet;
        }
        #endregion
    }
}
