using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Polymorphysm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите версию документа Pro, Exp, Free");
            string key = Console.ReadLine();
            DocumentWorker doc;

            switch (key)
            {
                case "Pro": doc = new ProDocumentWorker();
                    break;
                case "Exp": doc = new ExpertDocumentWorker();
                    break;
                default: Console.WriteLine("Введен неправильный формат или выбрана бесплатная версия");
                    doc = new DocumentWorker();
                    break;
            }

            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();

            Console.ReadKey();
        }
    }
}
