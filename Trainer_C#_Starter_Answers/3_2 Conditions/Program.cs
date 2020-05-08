using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Найдите и исправьте ошибки в коде
namespace _3_2_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            float temperature = 17f;
            if (temperature <= 0)
            {
                Console.WriteLine("Вода - лёд");
            }
            else if (temperature < 100)
            {
                Console.WriteLine("Вода в жидком состоянии");
            }
            else
            {
                Console.WriteLine("Вода - пар");
            }
        }
    }
}
