using System;
using System.Collections.Generic;                                       // В примере учебного домашнего задания делались 2 отдельные коллекции  
using System.Linq;                                                      // (MyList<T>) - для имён машин (закрытая типом <string>) и для годов ( закрытая типом <DateTime>).
using System.Text;                                                      // Основная же коллекция CarCollection <T> наследовалась от MyList<T>.
using System.Threading.Tasks;                                           // В ней уже создавалось по одному экз-ру: MyList<string> и MyList<DateTime>
                                                                        // Во всех классах переопределялся метод ToString() класса Object.
namespace _002_Generic_User_Collection                                  // Дальше уже делался стандартный вывод - в соотв. с заданием.
{                                                                       // Недостаток: параметр <T> в самом классе CarCollection нигде не используется.
    class CarCollection<T> : ICarCollection<T>                          // Его необходимо только указать потому что CarCollection наследуется от MyList<T>           
    {                                                                   // Собственно, может в этом и состояла цель автора задачи - немного запутать.
        T[] elements;                                                   // Хотя автору приходится из Main, создавая экземпляр CarCollection, указывать для закрытия типа    
                                                                        // параметр типа <string>, который нигде не используется, и который можно 
        public CarCollection ()                                         // заменить чем угодно (int, object, DateTime...) - это не влияет на ход программы.
        {                                                               
            elements = new T[0];                                        
        }                                                               
        
        public void Add(T element)                                      // Add - Method for adding elements
        {
            T[] tempArray = new T[elements.Length + 1];                 // Создаём временный массив на 1 элемент больше чем действующий (для добавления 1 входящего элемента)
            for (int i = 0; i < elements.Length; i++)
            {
                    tempArray[i] = elements[i];                         // Записываем весь действующий массив во временный массив
            }
            tempArray[tempArray.Length] = element;                      // Записываем новый элемент в последний элемент временного массива
            elements = tempArray;                                       // Присваиваем переменной основного массива весь временный массив.
        }

        public T this[int index] { get { return elements[index]; } }    // Indexer - for getting elements by index

        public int Length { get { return elements.Length; } }           // Property - for getting length of collection

        public void Clear ()                                            // Method - for cleaning the collection.
        {
            elements = new T [elements.Length];
        }
    }
}
