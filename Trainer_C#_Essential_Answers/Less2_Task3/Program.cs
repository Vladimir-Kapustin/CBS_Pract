using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                                    //В классе MyClass реализуйте метод IsLuckyTicket, который должен принимать на вход строковое представление шестизначного номера лотерейного билета, и возвращать значение, является ли он «счастливым» - то есть, равна ли сумма первых трех цифр сумме остальных трех. Например: “123006” – счастливый, а “345123” – нет. На любую некорректную входную строку метод должен возвращать значение false.
namespace Less2_Task3
{
    class MyClass
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
                while (count <=3)
                {
                    sumFirst += number % 10;
                    number /= 10;
                    count++;
                }
                sumSecond += number % 10;
                number /= 10;
                count++;
            }

            if (sumFirst==sumSecond)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
    //class Program
    //{

    //    //static void Main (string[] args)                          //Запуск проверки билета на "счастье"
    //    //{
    //    //    Console.WriteLine("Insert number");
    //    //    MyClass my = new MyClass();

    //    //    bool result = my.IsLuckyTicket(Console.ReadLine());

    //    //    if (result==true)
    //    //    {
    //    //        Console.WriteLine("Ticket is lucky");
    //    //    }
    //    //    else
    //    //    {
    //    //        Console.WriteLine("Ticket is not lucky");
    //    //    }
    //    //}
    //}
}
