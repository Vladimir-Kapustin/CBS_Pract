using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            string someWord = "my word";
            
            string stringToFind = b.FindNext(someWord);
            Console.WriteLine(stringToFind + "'"+ someWord + "'");

            Console.WriteLine(new string ('-',30));

            string newWord = FindAndReplaceManager.FindNext(someWord);
            Console.WriteLine(newWord);

            Console.ReadKey();
        }
    }
}
