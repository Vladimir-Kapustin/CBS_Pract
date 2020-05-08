using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Alternative
{
    public class Calendar : IEnumerable, IEnumerator
    {
        int[] months = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        int position = -1;

        public object Current
        {
            get
            {
                return months[position] + " - " + days[position]; // забавно... это я списал с ответов: взял 2 инта соединил и вернул их как обжект, при этом не берётся во внимание, что это свойство можно вызвать, когда позишн равен -1... :)) аффтар жжот
            }
        }

        public bool MoveNext()
        {
            if (position < months.Length - 1)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public string GetDaysByMonth(int month)
        {
            string newString = string.Empty;
            for (int i = 0; i < months.Length; i++)
            {
                if (months[i]==month)
                {
                    newString = months[i] + " - " + days[i];
                }
            }
            return newString;
        }

        public string GetMonthsByDays(int day)
        {
            string newString = string.Empty;
            for (int i = 0; i < days.Length; i++)
            {
                if (days[i]==day)
                {
                    newString += months[i] + " - " + days[i] + "\n";
                }
            }
            return newString;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Calendar calendar = new Calendar();

            foreach (var item in calendar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Выбор месяца");
            Console.WriteLine(calendar.GetDaysByMonth(5));

            Console.WriteLine("Печать месяцев по количеству дней:");
            Console.WriteLine(calendar.GetMonthsByDays(30));
        }
    }
}
