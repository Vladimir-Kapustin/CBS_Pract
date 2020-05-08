using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Task2
{
    class Redactor
    {
        AbstractHadler handler;

        public void ChooseDocument(string format)
        {
            switch (format.ToLower())
            {
                case "doc": handler = new DOCHandler();
                    break;
                case "txt": handler = new TXTHandler();
                    break;
                case "xml": handler = new XMLHadler();
                    break;
                default: Console.WriteLine("No such format");
                    break;
            }
        }

        public void Open()
        {
            handler.Open();
        }
        public void Create()
        {
            handler.Create();
        }
        public void Change()
        {
            handler.Change();
        }
        public void Save()
        {
            handler.Save();
        }
    }
}
