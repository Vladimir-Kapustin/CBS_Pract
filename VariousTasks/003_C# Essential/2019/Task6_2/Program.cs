using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_3
{
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки : " + str);
        }
    }

    static class FindAndReplaceManager
    {
        public static void FindNext(string str)
        {
            Book b = new Book();
            b.FindNext(str);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FindAndReplaceManager.FindNext("my string");
        }
    }
}
