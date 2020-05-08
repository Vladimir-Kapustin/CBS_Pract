using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedDictionary od = new OrderedDictionary(new Comparer());// реализация - не чувствителен к регистру
            od.Add("One", "Один");
            od.Add("Two","два");
            //od.Add("one", "АДЫН");        // даст исключение, если реализация - чувствителен к регистру
            od.Add("Three", "три");
            od.Add("Four", "Четыре");

            foreach (DictionaryEntry d in od)
            {
                Console.WriteLine("{0}: {1}", d.Key,d.Value);
            }
        }
    }

    public class Comparer : IEqualityComparer
    {
        CaseInsensitiveComparer comparer = new CaseInsensitiveComparer(); // реализация - не чувствителен к регистру

        public new bool Equals(object x, object y)
        {
            return comparer.Compare(x, y) == 0;                           // реализация - не чувствителен к регистру
            //return x.Equals(y);                                         // реализация - чувствителен к регистру
        }

        public int GetHashCode(object obj)
        {
            return obj.ToString().ToLowerInvariant().GetHashCode();
        }
    }
}
