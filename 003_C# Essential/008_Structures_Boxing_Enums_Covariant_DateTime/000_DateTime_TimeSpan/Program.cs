using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_DateTime_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthDate = new DateTime(2016, 12, 06);
            Console.WriteLine("Birth data in this year: {0}", birthDate);

            DateTime now = DateTime.Now;

            TimeSpan period = birthDate - now;

            Console.WriteLine("Days remaining till birthdate: {0}", period.Days);

            Console.ReadKey();
        }
    }
}
