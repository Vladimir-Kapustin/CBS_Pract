using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Encapsulation
{
    class Author
    {
        private string author1;
        public string Author1
        {
            get { return author1; }
            set { author1 = value; }
        }
        public void Show ()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Author1);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
