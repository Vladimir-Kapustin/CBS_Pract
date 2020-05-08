using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Enumerators
{
    public class Year
    {
        Month[] months = new Month[12];
        int current = 0;

        public void Add(Month month)
        {
            if (current<months.Length)
            {
                months[current] = month;
                current++;
            }
            else
            {
                Console.WriteLine("Коллекция переполнена");
            }
        }

        public string this[int index]
        {
            get
            {
                for (int i = 0; i < months.Length-1; i++)
                {
                    if (months[i].Number==index)
                    {
                        return months[i].ToString();
                    }
                }
                return "Нет месяца, соответствующего данному номеру";
            }
        }

        public IEnumerable MonthsByDays(int days)
        {
            int count = 0;
            for (int i = 0; i < months.Length-1; i++)
            {
                if (months[i].Days==days)
                {
                    yield return months[i];
                    count++;
                }
            }
            if (count==0)
            {
                Console.WriteLine("Нет месяца с таким количеством дней"); 
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < months.Length-1; i++)
            {
                yield return months[i];
            }
        }
    }
}
