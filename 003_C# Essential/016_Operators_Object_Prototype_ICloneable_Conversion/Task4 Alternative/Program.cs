using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Alternative
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date(new DateTime(2016, 10, 02));
            Date date2 = new Date(new DateTime(2009, 03, 11));

            Console.WriteLine("Разница между датами: {0} и {1}", date1, date2);
            Console.WriteLine("{0} дня (дней)", Date.SubtractionDates(date1, date2));

            Console.WriteLine("Дата, после добавления к дате {0}", date1);
            Console.WriteLine("{0} дней - {1}", 256, Date.AdditionDays(date1, 256));

        }
    }
}
