using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Alternative
{
    class Date
    {
        DateTime date;

        public Date(DateTime date)
        {
            this.date = date;
        }

        public static int operator -(Date date1, Date date2)
        {
            TimeSpan timeSpan = date1.date.Subtract(date2.date);
            return timeSpan.Days;
        }

        public static Date operator +(Date date1, int days)
        {
            DateTime newDate = date1.date.AddDays(days);
            return new Date(newDate);
        }

        public static int SubtractionDates(Date date1, Date date2)
        {
            return date1 - date2;
        }

        public static Date AdditionDays(Date date1, int days)
        {
            return date1 + days;
        }

        public override string ToString()
        {
            return string.Format(date.ToString("d"));   // "d" - этот формат нашёл здесь: https://msdn.microsoft.com/ru-ru/library/system.datetime.date(v=vs.110).aspx#Anchor_2. На странице DateTime - не всё, на DateTime.ToString() - тоже мало.
        }
    }
}
