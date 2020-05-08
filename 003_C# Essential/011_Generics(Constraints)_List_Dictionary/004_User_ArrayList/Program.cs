using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_User_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList my = new MyArrayList();

            my.Add(5);
            my.Add("asdfasfsfd");
            my.Add(false);
            my.Add(new Program());

            Console.WriteLine(my.ToString()); 

            Console.ReadKey();

        }
    }
}
