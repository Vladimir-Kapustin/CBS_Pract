using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Encapsulation
{
    class Title
    {
         private string title;
        public string Title1
        {
            get { return title; }
            set { title = value; }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Title1);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
