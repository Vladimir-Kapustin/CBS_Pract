﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Task2
{
    static class FindAndReplaceManager
    {
        public static string FindNext(string str)
        {
            Book b = new Book();
            Console.WriteLine("Найдено: {0} ", b.FindNext(str) + str);
            Console.WriteLine("Заменено:");
            return "Found Some Text with " + "New Word";
        }
    }
}
