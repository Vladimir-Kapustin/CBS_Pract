using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_Alternative_Additional_Task  // Это реализация дополнительного задания к уроку в соответствии с тем, КАК оно 
{                                           // написано...
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 6, 7, 2, 4, 6, 7, 9, 1, 10, 18, 55 };

            foreach (int item in Method(array))
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static Collection<int> Method(int[] array)
        {
            Collection<int> someColl = new Collection<int>();

            for (int i = 0; i < array.Length; i++)
            {
                someColl.Add(array[i]);
            }

            return someColl;
        }
    }

    public class Collection<T> : IEnumerable<T>
    {
        List<T> elements = new List<T>();

        public void Add(T item)
        {
            elements.Add(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in elements)
            {
                yield return item;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
