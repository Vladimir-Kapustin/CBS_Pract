using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Extension_Method
{
    public static class MyStaticClass
    {                                                               // Универсальные методы - https://msdn.microsoft.com/ru-ru/library/twcad0zb(v=VS.90).aspx
        public static T[] GetArray<T>(this IEnumerable<T> list)     // IEnumerable<T> здесь - для foreach.  Если поставить просто Т вместо IEnumerable<T>, то foreach нигде не саботает - он же не знает, является ли входящий аргумент перечислимым или нет...
        {
            int count = 0;
            foreach (var item in list)
            {
                count++;
            }

            T[] array = new T[count];   // Хотя можно оказывается было написать [list.Count()];. Count() - это расширяющий метод. 
            int positionArray = 0;

            foreach (var item in list)
            {
                array[positionArray] = item;
                positionArray++;
            }
            return array;
        }
    }
}
