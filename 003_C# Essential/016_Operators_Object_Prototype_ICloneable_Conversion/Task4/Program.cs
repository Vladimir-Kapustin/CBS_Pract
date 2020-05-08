using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date(2016, 09, 30);
            Date date2 = new Date(2009, 03, 11);

            TimeSpan days = date1 - date2;

            Console.WriteLine("разница между датами {0} и {1} - {2} дней", 
                date1.NewDate.Date.ToString("d"), date2.NewDate.Date.ToString("d"), days.Days);

            DateTime futureDate = date1 + 360;

            Console.WriteLine("Next future date: {0}", futureDate.ToString("d"));
        }
    }
}
