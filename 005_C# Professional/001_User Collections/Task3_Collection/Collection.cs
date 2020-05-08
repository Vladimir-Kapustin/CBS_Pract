using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3_Collection.Citizens;

namespace Task3_Collection
{
    class Collection : IEnumerable, IEnumerator  // Реалиацию IEnumerable ставлю, чтобы можно было использовать блок инициализации (так сказал компилятор). IEnumerator - т.к. GetEnumerator возвращает IEnumerator и компилятор требует чтобы возвратилось "что-то" как IEnumerator во время работы foreach.
    {
        Citizen[] people;
        int last = -1;
        int position = -1;

        public Collection()
        {
            people = new Citizen[4];
        }

        #region Добавление элемента

        // Метод Add
        public int Add(Citizen citizen)
        {
           
            int index = -1;
            if (Contains(ref index, citizen))
            {
                Console.WriteLine("Такой человек уже имеется в коллекции");
                return index;
            }

            if (last >= people.Length - 1)
            {
                GrowArray();
            }

            if (citizen is Pensioner)
            {
                int current = 0;
                while (people[current] is Pensioner)
                {
                    current++;                          // находим позицию после последнего пенсионера и ставим туда указатель
                }

                for (int i = last; i >= current; i--)
                {
                    people[i + 1] = people[i];          // раздвигаем массив,
                }
                people[current] = citizen;              // добавляем пенсионера.
                last++;
                return current;                         // возврат номера в очереди добавленного пенсионера.
            }

            people[last + 1] = citizen;                 // добавление НЕ пенсионера
            last++;
            return last;                                // возврат номера в очереди добавленного гражданина.
        }

        // Метод GrowArray
        public void GrowArray()
        {
            int capacity = people.Length == 0 ? 4 : people.Length * 2;

            Citizen[] tempArray = new Citizen[capacity];
            for (int i = 0; i < people.Length; i++)
            {
                tempArray[i] = people[i];
            }
            people = tempArray;
        }

        #endregion

        #region Удаение элемента

        public void Remove()
        {
            for (int i = 0; i < last; i++)
            {
                people[i] = people[i + 1];      // Сдвигаем массив на место удаляемого элемента.
            }
            last--;
        }

        public void Remove(Citizen citizen)
        {
            int number = -1;
            if (!Contains(ref number, citizen))
            {
                Console.WriteLine("В списке нет такого человека");
            }
            else
            {
                for (int i = number; i < last; i++)
                {
                    people[i] = people[i + 1];      // Сдвигаем часть массива на место удаляемого элемента.
                }
                last--;
            }
        }
        #endregion

        #region Метод Contains
        public bool Contains(ref int number, Citizen citizen)
        {
            for (int i = 0; i <= last; i++)
            {
                if (people[i] == citizen)   // проверка идентичности граждан по пасспорту (переопределённый оператор ==)
                {
                    number = i;
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Метод ReturnLast
        public Citizen ReturnLast(ref int number)
        {
            number = last;
            return people[last];
        }

        #endregion

        #region Очистка коллекции
        public void Clear()
        {
            people = new Citizen[4];
            Console.WriteLine("Коллекция очищена");
        }
        #endregion

        #region Итератор
        //public IEnumerable GetEnumerator()    
        //{
        //    for (int i = 0; i < last; i++)
        //    {
        //        yield return people[i];
        //    }
        //}		 
        public IEnumerator GetEnumerator()  // Для того, чтобы перечислять коллекцию и не указывать вверху реализацию интерфейсов IEnumerable/ IEnumerator, здесь в возвращаемом значении надо поставить тип нашей коллекции, а не IEnumerator (видео - 29:14)
        {
            return this;                    // 2-й вариант Итератора: в System.Array уже есть реализация IEnumerable! Поэтому можно делегировать вызов массиву. Тогда можно написать return people.GetEnumerator(); И не реализовывать методы IEnumerator`а.
        }

        object IEnumerator.Current          
        {
            get { return people[position]; }
        }

        bool IEnumerator.MoveNext()
        {
            if (position < last)
            {
                position++;
                return true;
            }
            else
            {
                (this as IEnumerator).Reset();
                return false;
            }
        }

        void IEnumerator.Reset() { position = -1; }

        #endregion
    }
}
