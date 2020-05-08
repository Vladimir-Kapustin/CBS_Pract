using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_yield
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 6, 4, 9, 7, 5, 2, 4, 16, 8, 71, 46, 22 };

            //MyCollection<int> someCollection = new MyCollection<int>();   // Запутывающими словами в этом задании являются "...возвращает коллекцию...". Здесь первый вариант решения: 
                                                                            // метод, в котором находится yield по определению не может вернуть какой-то класс коллекции, а может только тип IEnumerable или IEnumerator.
            //foreach (int item in MyMethod(array))                         // Хитрость в том, что как раз коллекция может быть приведена к этим типам. Так вот, если уж формировать КОНКРЕТНЫЙ класс коллекции, то только
            //{                                                             // за пределами этого метода (а не в самом методе - хотя сказано: "метод возвращает коллекцию"). Этот метод должен возвращать IEnumerable, а уж 
            //    someCollection.Add(item);                                 // потом, тем, что из него возвращается можно во внешнем коде формировать коллекцию. (дальше смотри комментарий ниже)
            //}

            foreach (int item in MyMethod(array))                           // в первом варианте решения указан в скобках someCollection, а не MyMethod. Вобщем коллекцию можно было не создавать - со всем "богатством" методов в ней.
            {
                Console.WriteLine(item);
            }

        }

        static IEnumerable<int> MyMethod(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 2 > 0)   // если число нечётное,
                {
                    yield return (array[i]*array[i]); // возвести в квадрат и добавить.
                }
            }
        }
    }
}
