using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Encapsulation
{
    class Content
    {
         private string content;
        public string Content1
        {
            get { return content; }
            set { content = value; }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content1);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
