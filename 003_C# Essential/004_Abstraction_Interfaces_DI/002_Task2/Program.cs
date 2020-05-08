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
            Redactor redactor = new Redactor();
            Console.WriteLine("choose your document");
            redactor.ChooseDocument(Console.ReadLine());

            redactor.Open();
            redactor.Create();
            redactor.Change();
            redactor.Save();

            Console.ReadKey();
        }
    }
}
