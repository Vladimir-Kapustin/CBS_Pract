using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Pro C# 5 And .Net Framework 4.5 Platform");
            book.Author = "Andrew Troelsen";
            book.Content = "Eat some of these french fries!";

                book.Show();
                Console.ReadKey();
        }
    }
}
