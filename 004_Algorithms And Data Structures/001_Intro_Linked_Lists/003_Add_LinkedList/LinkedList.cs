using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Add_LinkedList
{
    class LinkedList<T> : IEnumerable<T>
    {
        LinkedListNode<T> _head;
        LinkedListNode<T> _tail;

        public int Count                            //св-во - отображающее количество элементов.
        {
            get;
            set;
        }

        #region Метод для добавления элементов (в односвязном списке элемент добавляется в конец)
       
        public void Add(T item)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(item);

            if (_head == null)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }
            Count++;
        }

        #endregion

        #region Метод очистки списка
        
        public bool Clear()
        {
            if (_head != null)
            {
                _head = null;
                _tail = null;
                Count = 0;
                return true;
            }
            else
            {
                Console.WriteLine("The List is already cleared");
                return false;
            }
        }

        #endregion

        #region Метод, удаляющий все узлы, находящиеся в позициях с номерами, кратными пяти
        
        public bool RemoveFives()
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = null;

            if (_head != null)
            {
                if (Count < 5)
                {
                    Console.WriteLine("The List have even less than 5 elements - you`ll not delete anything");
                    return false;
                }
                else
                {
                    current = _head;
                    int deleted = 0;
                    for (int i = 1; i <= Count; i++)
                    {
                        if (i % 5 == 0)
                        {
                            Console.WriteLine("deleted element {0} with value {1}", i, current.Value);
                            previous.Next = current.Next;
                            deleted++;
                        }
                        previous = current;
                        current = current.Next;
                    }
                    Count = Count - deleted;
                    return true;
                }
            }
            else
            {
                Console.WriteLine("The List is already cleared");
                return false;
            }
        }

        #endregion

        #region Метод для отображения коллекции
        
        public void Display()
        {
            Console.WriteLine("The list is:");
            LinkedListNode<T> current = _head;

            if (_head!=null)
            {
                while (current!=null)
                {
                    Console.Write("{0} ", current.Value);
                    current = current.Next;
                }
            }
            Console.WriteLine("\nNumber of elements: {0}", Count);
        }

        #endregion

        #region Метод для получения нумератора для коллекции

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = _head;

            while (current!=null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<T>).GetEnumerator();
        }

        #endregion

       
    }
}
