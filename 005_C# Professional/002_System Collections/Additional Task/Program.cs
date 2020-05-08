using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList list = new SortedList(/*new ReverseSorting()*/); //Снять комментарий. // Сразу сортировка в обратном (хотя чётко как по заданию: сначала вывести коллекцию по возрастанию, потом - по убыванию. Т.е. создать две)

            list.Add("A", "one");
            list.Add("D", "four");
            list.Add("C", "three");
            list.Add("B", "two");
            list.Add("e", "five");


            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine("{0}, {1}", item.Key, item.Value);
            }
        }
    }

    class ReverseSorting : IComparer
    {
        CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

        public int Compare(object x, object y)
        {
            return -1 * comparer.Compare(x, y);
            // return comparer.Compare(y, x);   // - то же самое (x, y поменяли местами).
        }
    }
}
