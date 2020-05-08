using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Extended_Method_For_Task2
{
    public static class MyListExtended
    {
        public static T[] GetArray <T> (this MyList<T> list)
        {
            T[] arrayList = new T[list.Length];

            for (int i = 0; i < list.Length; i++)
			{
			 arrayList[i] = list[i];
			}
            return arrayList;
        }
    }
}
