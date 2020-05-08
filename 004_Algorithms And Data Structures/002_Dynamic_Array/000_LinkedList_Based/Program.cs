using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_LinkedList_Based
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.Add(1);
            list.Add(33);
            list.Add(42);
            list.Add(56);
            list.Add(4);
            list.Add(98);
            list.Add(3);
            list.Add(7);
            list.Add(88);
            list.Add(2);

            list.Display();

            ArrayList<int> dArr = new ArrayList<int>(list);

        }
    }
}


//Возможное - "простое" - решение, когда LinkedList реализует интерфейс ICollection<T> - и тогда его можно поместить в динамический массив (т.к. конструктор позволяет) - но для этого нужна реализация методов ICollection<T> - не очень удобное решение.

//ArrayList<int> dArr = new ArrayList<int>(list);
//dArr.Display();