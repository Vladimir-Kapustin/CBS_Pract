using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0002_Another_Alternative_AddTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 6, 7, 13, 5, 47, 9, 7, 8, 2, 4, 18, 96 };

            Collection<int> col = new Collection<int>();

            foreach (int item in Method(array))
            {
                col.Add(item);
            }

            foreach (int item in col)
            {
                Console.WriteLine(item);
            }
        }

        static IEnumerable<int> Method(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==0)
                {
                    yield return array[i];
                }
            }
        }
    }

    public class Collection<T> : IEnumerable<T>
    {
        List<T> list = new List<T>();

        public void Add(T item)
        {
            list.Add(item);
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in list)
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

//-----------------------------------------------------------------ИЛИ (ЕЩЁ ПРОЩЕ)----------------------------------------------

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] array = { 5, 6, 7, 13, 5, 47, 9, 7, 8, 2, 4, 18, 96 };

//        IEnumerable<int> col = Method(array);

//        foreach (int item in col)
//        {
//            Console.WriteLine(item);
//        }
//    }

//    static IEnumerable<int> Method(int[] array)
//    {
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] % 2 == 0)
//            {
//                yield return array[i];
//            }
//        }
//    }
//}
