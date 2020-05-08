using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите валюту для конвертации (UAH/USD/EUR/RUB)");
            string val = Console.ReadLine().ToLower();

            Console.WriteLine("Введите сумму");
            double sum = double.Parse(Console.ReadLine().ToLower());

            Console.WriteLine("Введите валюту, в которую хотите конвертировать (UAH/USD/EUR/RUB)");
            string convertedVal = Console.ReadLine().ToLower();

            Converter converter = new Converter(26.5, 29.70, 0.4, val, sum, convertedVal);

            converter.Convert();
        }
    }
}
