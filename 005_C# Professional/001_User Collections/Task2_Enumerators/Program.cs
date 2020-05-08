using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Enumerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Year year = new Year();

            year.Add(new Month() { Name = "Yanuary", Number = 1, Days = 31 });
            year.Add(new Month() { Name = "February", Number = 2, Days = 28 });
            year.Add(new Month() { Name = "March", Number = 3, Days = 31 });
            year.Add(new Month() { Name = "April", Number = 4, Days = 30 });
            year.Add(new Month() { Name = "May", Number = 5, Days = 31 });
            year.Add(new Month() { Name = "June", Number = 6, Days = 30 });
            year.Add(new Month() { Name = "July", Number = 7, Days = 31 });
            year.Add(new Month() { Name = "August", Number = 8, Days = 31 });
            year.Add(new Month() { Name = "September", Number = 9, Days = 30 });
            year.Add(new Month() { Name = "October", Number = 10, Days = 31 });
            year.Add(new Month() { Name = "November", Number = 11, Days = 30 });
            year.Add(new Month() { Name = "December", Number = 12, Days = 31 });

            year.Add(new Month() { Name = "13th Month...", Number = 13, Days = 32 });

            Console.WriteLine(year[3]);
            Console.WriteLine(year[13]);

            Console.WriteLine("Перечисление месяцев с 31 днём:");
            foreach (Month item in year.MonthsByDays(31))
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Перечисление месяцев с 28 днями:");
            foreach (Month item in year.MonthsByDays(28))
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Перечисление месяцев с 15 днями:");
            foreach (Month item in year.MonthsByDays(15))
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
