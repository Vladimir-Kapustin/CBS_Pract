using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pointOne = new Point(1, 2, 3);

            Point pointTwo = new Point(4, 5, 6);

            Point pointThree = pointOne + pointTwo;

            Console.WriteLine("point One: {0}", pointOne);
            Console.WriteLine("point Two: {0}", pointTwo);
            Console.WriteLine("point Three: {0}", pointThree);
        }
    }
}
