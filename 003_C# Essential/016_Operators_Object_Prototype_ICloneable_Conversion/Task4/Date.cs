using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Date
    {
        DateTime newDate;

        public Date(int year, int month, int day)
        {
            newDate = new DateTime(year, month, day);
        }

        public DateTime NewDate
        {
            get { return newDate; }
            set { newDate = value; }
        }

        public static TimeSpan operator - (Date date1, Date date2)
        {
            return date1.NewDate.Subtract(date2.NewDate);
        }

        public static DateTime operator + (Date date1, double days)
        {
            return date1.NewDate.AddDays(days);
        }
    }
}
