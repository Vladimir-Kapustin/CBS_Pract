using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Queue_Priorities_Correct
{
    public class Deque<T>
    {
        T[] _items = new T[0];

        // Количество элементов в двусвязной очереди     
        int _size = 0;

        // Указатель на первый (самый старый) элемент очереди.     
        int _head = 0;

        // Указатель на последний (новый) элемент очереди.     
        int _tail = -1;

        #region Метод allocateNewArray, увеличивает внутренний массив

        private void allocateNewArray(int startingIndex)
        {

            // начальный размер массива равен 4, при увеличение массива размер удваивается.

            int newLength = (_size == 0) ? 4 : _size * 2;

            T[] newArray = new T[newLength];

            if (_size > 0)
            {
                int targetIndex = startingIndex;

                // Копирование содержимого ...         
                // Если не было обхода массива индексами, то копирование элементов.         
                // в ином случае копирование с указателя head до конца массива end, а затем от 0 до tail.  
                // Если указатель tail меньше чем head, осуществить им обход массива.         

                if (_tail < _head)
                {
                    // Копирование от _items[head].._items[end] -> newArray[0]..newArray[N].             
                    for (int index = _head; index < _items.Length; index++)
                    {

                        newArray[targetIndex] = _items[index];
                        targetIndex++;
                    }

                    // Копирование от _items[0].._items[tail] -> newArray[N+1]..             

                    for (int index = 0; index <= _tail; index++)
                    {
                        newArray[targetIndex] = _items[index];
                        targetIndex++;
                    }
                }
                else
                {
                    // Копировать от _items[head].._items[tail] -> newArray[0]..newArray[N]             
                    for (int index = _head; index <= _tail; index++)
                    {
                        newArray[targetIndex] = _items[index];
                        targetIndex++;
                    }
                }

                _head = startingIndex;
                _tail = targetIndex - 1;


            }
            else
            {    // Если массив пустой.         
                _head = 0;
                _tail = -1; //потому что если мы добавим элемент в пустой массив то значение _tail сдвинется с -1 до 0 и тогда _head и _tail будут указывать на один и тот же элемент, который единственный пока в списке.
            }

            _items = newArray;      //перезаписали массив увеличенным массивом.
        }

        #endregion

        #region Метод EnqueueFirst, добавляет новый элемент в начало очереди

        public void EnqueueFirst(T item)
        {

            // Увеличение размера внутреннего массива
            if (_items.Length == _size)
            {

                allocateNewArray(1);

            }

            if (_head > 0)
            {
                _head--;
            }
            else
            {
                // Оборот вокруг конца массива         
                _head = _items.Length - 1;
            }

            _items[_head] = item;

            _size++;
        }

        #endregion

        #region Метод EnqueueLast, добавляет новый элемент в конец очереди

        public void EnqueueLast(T item)
        {

            // Размер массива нужно увеличить 

            if (_items.Length == _size)
            {
                allocateNewArray(0);
            }

            // Обход массива

            if (_tail == _items.Length - 1)
            {
                _tail = 0;
            }

            else
            {
                _tail++;
            }

            _items[_tail] = item;
            _size++;
        }

        #endregion

        #region  DequeueFirst и DequeueLast - Сделано самостоятельно (в качестве задания)

        public T DequeueFirst()
        {
            if (_tail == -1)  //если пустой массив
            {
                throw new InvalidOperationException();
            }

            if (_head > _tail)              //если хед после тейла
            {       //обход начала массива
                if (_head == _items.Length - 1) //если хэд последний
                {
                    _head = 0;                  //то передвигаем его вперёд на начало массива - инкрементировать нельзя, т.к. выйдет за пределы массива.
                    _size--;
                    return _items[_items.Length - 1];   //и возвращаем его бывшее значение, когда он стоял в конце списка
                }
                else
                {                               //если хэд был не последний, но после тейла
                    _head++;                    //moving head pointer forward
                    _size--;
                    return _items[_head - 1];   //returning deleted element
                }
            }
            else if (_head < _tail)     //хед до тейла, но они не равны
            {                   //если хэд меньше тейла
                _head++;
                _size--;
                return _items[_head - 1];   //returning deleted element
            }

            //если в массиве остался один элемент, на который указывают и голова и хвост
            T temp = _items[_head]; //записываем в буферную переменную значение хэда где бы он ни находился
            _head = 0;              //ставим хэд и тейл как бы в исходные позиции, соответствующие пустому массиву
            _tail = -1;
            return temp;            //возвращаем последнее значение хэда.
        }

        public T DequeueLast()
        {
            if (_tail == -1)  //если пустой массив
            {
                throw new InvalidOperationException();
            }

            if (_tail < _head)
            {       //обход массива "обратно"
                if (_tail == 0)   //если тейл стоит в начале массива
                {
                    _tail = _items.Length - 1;    //устанавливаем тейл в конец массива
                    _size--;
                    return _items[0];           //возвращаем бывшее значение тейла
                }
                else
                {
                    _tail--;                    //просто уменьшаем и
                    _size--;
                    return _items[_tail + 1];   //возвращаем бывшее значение тейла
                }
            }
            else if (_tail > _head)
            {
                _tail--;                    //просто уменьшаем и
                _size--;
                return _items[_tail + 1];   //возвращаем бывшее значение тейла
            }

            //если в массиве остался один элемент, на который указывают и голова и хвост
            T temp = _items[_tail]; //записываем в буферную переменную значение тейла где бы он ни находился
            _head = 0;              //ставим хэд и тейл как бы в исходные позиции, соответствующие пустому массиву
            _tail = -1;
            return temp;            //возвращаем последнее значение тейла.
        }

        #endregion

        #region Метод PeekFirst, возвращает первый элемент в очереди

        public T PeekFirst()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("Двусвязная очередь пуста");
            }

            return _items[_head];
        }

        #endregion

        #region Метод PeekLast, возвращает последний элемент в очереди

        public T PeekLast()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("Двусвязная очередь пуста");
            }

            return _items[_tail];
        }

        #endregion

        #region Свойство Count, содержит количество элементов в двусвязной очереди

        public int Count
        {
            get
            {
                return _size;
            }
        }

        #endregion

        #region Метод EnqueWithPriority, для извлечения элементов в соответствии с приоритетом (выполнение задания)

        public T EnqueWithPriority(Deque<int> instance)
        {
            Deque<int> temp = new Deque<int>();
            
            int max = instance._items.Max();
            for (int i = 0; i <= max; i++)
            {
                while (instance.PeekLast() != i)
                {
                    temp.EnqueueFirst(instance.DequeueLast());
                }    
            }
            

        }

        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {

            Deque<int> instanse = new Deque<int>();


            // First -> указатель на начало очереди
            // Last  -> указатель на конец очереди

            instanse.EnqueueLast(1);     // -> -> -> -> -> -> ->  
            instanse.EnqueueLast(2);     // Двусвязная очередь:  3 -> 2 -> 1
            instanse.EnqueueLast(3);     // -> -> -> -> -> -> ->

            instanse.EnqueueFirst(4);    // -> -> -> -> -> -> ->
            instanse.EnqueueFirst(5);    // Двусвязная очередь:  3 -> 2 -> 1 -> 4 -> 5 -> 6
            instanse.EnqueueFirst(6);    // -> -> -> -> -> -> ->


            Console.WriteLine("Первый элемент в очереди: {0}", instanse.PeekFirst());
            Console.WriteLine("Последний элемент в очереди: {0}", instanse.PeekLast());

            int i = instanse.DequeueFirst();
            Console.WriteLine("Был удалён первый элемент {0}", i);

            Console.WriteLine("Первый элемент в очереди: {0}", instanse.PeekFirst());
            Console.WriteLine("Последний элемент в очереди: {0}", instanse.PeekLast());

            // -> -> -> -> -> -> ->
            // Двусвязная очередь:  3 -> 2 -> 1 -> 4 -> 5 
            // -> -> -> -> -> -> ->

            int j = instanse.DequeueLast();
            Console.WriteLine("Был удалён последний элемент {0}", j);

            Console.WriteLine("Первый элемент в очереди: {0}", instanse.PeekFirst());
            Console.WriteLine("Последний элемент в очереди: {0}", instanse.PeekLast());

            // -> -> -> -> -> -> ->
            // Двусвязная очередь:  2 -> 1 -> 4 -> 5
            // -> -> -> -> -> -> ->
        }
    }
}
