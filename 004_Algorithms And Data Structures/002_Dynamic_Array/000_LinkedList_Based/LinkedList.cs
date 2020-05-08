using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_LinkedList_Based
{
    class LinkedList<T> : IEnumerable<T>//, ICollection<T>      Возможное - "простое" - решение, когда LinkedList реализует интерфейс ICollection<T> - и тогда его можно поместить в динамический массив (т.к. конструктор позволяет) - но для этого нужна реализация методов ICollection<T> - не очень удобное решение.
    {
        LinkedListNode<T> _head;
        LinkedListNode<T> _tail;

        public int Count                //св-во - отображающее количество элементов.
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
                _tail.Next.Previous = _tail;
                _tail = node;
            }
            Count++;
        }

        #endregion

        #region Метод Remove, для очистки списка

        public bool Remove()
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
                Console.WriteLine("The List is already empty");
                return false;
            }
        }

        #endregion

        #region Метод RemoveFives, удаляющий все узлы, находящиеся в позициях с номерами, кратными пяти

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

        #region Метод Display, для отображения коллекции

        public void Display()
        {
            Console.WriteLine("The list is:");
            LinkedListNode<T> current = _head;

            if (_head != null)
            {
                while (current != null)
                {
                    Console.Write("{0} ", current.Value);
                    current = current.Next;
                }
            }
            else
            {
                Console.Write("Empty.");
            }
            Console.WriteLine("\nNumber of elements: {0}", Count);
        }

        #endregion

        #region Метод GetEnumerator, для получения нумератора для коллекции

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = _head;

            while (current != null)
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

        #region Метод AddAfter, для добавления нескольких элементов в середину списка

        public void AddAfter(T[] node, int position)
        {
            if (_head == null)
            {
                Console.WriteLine("There`s no elements in the List!");
            }
            else
            {                                       // здесь конечно можно ещё было проверить на выход индекса за пределы диапазона списка - но это уже нюансы, я делать не буду за неимением времени.
                LinkedListNode<T> current = _head;
                for (int i = 1; i < position; i++)
                {
                    current = current.Next;                         // дошли до желаемой позиции
                }
                LinkedListNode<T> temp = current.Next;              // сохранение ссылки на следующий элемент, которая сейчас находится в current.
                for (int i = 0; i < node.Length; i++)
                {
                    LinkedListNode<T> item = new LinkedListNode<T>(node[i]);    //создаём узел для нового элемента и пишем в него входящее значение этого элемента
                    Console.WriteLine("inserting element {0} after {1}", item.Value, current.Value);
                    current.Next = item;                            // сохраняем в current ссылку на входящий элемент, как на следующий.
                    current.Next.Previous = current;                // а в следующем сохраняем ссылку обратно на current.
                    current = current.Next;                         // перешагиваем с current на следующий элемент, который был только что вставлен - и делаем его current`ом.
                    Count++;
                }
                current.Next = temp;                //и теперь в последний вставленный элемент сохраняем ссылку на тот элемент, на который current ссылался изначально - до вставки
                current.Next.Previous = current;    //и ссылку обратно (поскольку список у нас двусвязный)
            }
        }

        #endregion

        #region Метод AddFirst, для добавления элемента в начало списка

        public void AddFirst(T value)
        {
            LinkedListNode<T> current = new LinkedListNode<T>(value);

            if (_head == null)            // конечно можно и другие важные проверки добавить или здесь, или ранее, или далее - за неимением времени не буду - сделю только основное.
            {
                _head = current;
                _tail = current;
            }
            else
            {
                _head.Previous = current;   // в первом элементе ссылаемся на добавляемый до него новый элемент
                current.Next = _head;       // в новом элементе, который теперь стоит перед _head ссылаемся на это _head
                _head = current;            // а теперь этот новый элемент делаем _head`ом
                Count++;
            }
        }

        #endregion

        #region Метод AddLast, для добавления элемента в конец списка

        // Когда указатель указывает на начало списка, то при добавлении элемента приходится перебирать все его узлы, что бы достичь конечного, 
        // при этом степень роста алгоритма составляет О(n). Лучше, когда указатель установлен на конец списка, тогда при добавлении элемента, степень
        // роста равна константе О(1).   

        public void AddLast(T value)
        {
            LinkedListNode<T> current = new LinkedListNode<T>(value);

            if (_head == null)
            {
                _head = current;
                _tail = current;
            }
            else
            {
                _tail.Next = current;           // ситуация аналогичная с предыдущим методом - только немножко наоборот.
                current.Previous = _tail;
                _tail = current;
                Count++;
            }
        }

        #endregion

        #region Индексатор, для доступа к элементам коллекции

        public T this[int index]
        {
            
            get
            {
                if (index < 0 | index > Count)
                {
                    throw new IndexOutOfRangeException();
                }
                
                LinkedListNode<T> current = _head;
                for (int i = 0  ; i < Count-1; i++)
                {
                    if (index==Count-1)
                    {
                        return current.Value;
                    }
                    current = current.Next;
                }
                return current.Value;
            }
            set
            {
                if (index < 0 | index > Count)
                {
                    throw new IndexOutOfRangeException();
                }
                
                LinkedListNode<T> current = _head;
                for (int i = 0; i < Count - 1; i++)
                {
                    if (index == Count - 1)
                    {
                        current.Value = value;
                    }
                    current = current.Next;
                }
            }
        }

        #endregion
    }
}
