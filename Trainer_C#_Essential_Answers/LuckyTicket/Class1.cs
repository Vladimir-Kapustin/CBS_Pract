using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicket                   //This is the liblrary!
{
    /// <summary>
    ///  Класс Class1
    ///  - это библиотека,
    ///  которая определяет, счастливый билет или нет с помощью метода
    ///  public bool IsLuckyTicket(string ticket).
    ///  Вводится 6-значное число. Если вводимая строка больше 6 символов,
    ///  или если она состоит не из цифр, или если билет не является счастливым
    ///  (сумма первых 3-х цифр НЕ равна сумме последних 3-х цифр),
    ///  возвращается false, иначе - true.
    /// </summary>
    public class Class1
    {
        public bool IsLuckyTicket(string ticket)
        {
            int number;
            if (ticket.Length > 6)
            {
                return false;
            }
            else if (Int32.TryParse(ticket, out number) == false)
            {
                return false;
            }

            int sumFirst = 0;
            int sumSecond = 0;
            int count = 1;

            while (count <= 6)
            {
                while (count <= 3)
                {
                    sumFirst += number % 10;
                    number /= 10;
                    count++;
                }
                sumSecond += number % 10;
                number /= 10;
                count++;
            }

            if (sumFirst == sumSecond)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
