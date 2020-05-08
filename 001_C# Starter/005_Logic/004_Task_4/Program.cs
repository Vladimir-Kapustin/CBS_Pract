using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Расчёт премий сотрудникам. Задача на короткозамкнутые вычисления (&&).

namespace _004_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your regular salary:");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert your work experience:");
            int experience = Convert.ToInt32(Console.ReadLine());

            if (experience >= 0 && experience < 5)
            {
                Console.WriteLine("Your premium is: {0}", salary * 0.1);
            }
            else if (experience >= 5 && experience < 10)
            {
                Console.WriteLine("Your premium is: {0}", salary * 0.15);
            }
            else if (experience >= 10 && experience < 15)
            {
                Console.WriteLine("Your premium is: {0}", salary * 0.25);
            }
            else if (experience >= 15 && experience < 20)
            {
                Console.WriteLine("Your premium is: {0}", salary * 0.35);
            }
            else if (experience >= 2 && experience < 25)
            {
                Console.WriteLine("Your premium is: {0}", salary * 0.45);
            }
            else if (experience >= 25)
            {
                Console.WriteLine("Your premium is: {0}", salary * 0.5);
            }
            else
            {
                Console.WriteLine("You have inserted negative value...");
            }
        }
    }
}
