using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Найдите и исправьте ошибки в коде
namespace _3_4_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            string state = "Состояние №";
            switch (a)
            {
                case 0:
                    {
                        state += "0";
                        break;
                    }
                case 1:
                    {
                        state += "1";
                        break;
                    }
                case 2:
                    {
                        state += "2";
                        break;
                    }
                default:
                    {
                        state = "Неопределенное состояние";
                        break;
                    }
            }
            Console.WriteLine(state);
        }
    }
}
