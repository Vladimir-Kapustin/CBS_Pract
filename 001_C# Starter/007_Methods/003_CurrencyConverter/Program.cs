using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_CurrencyConverter			//--здесь нет функциональной связности. Методы выполняют по несколько операций. А надо - по одной... )))
{
    class Program
    {
        // Rates for UAH to USD, EUR:
        static double rateUSD = 25.25;
        static double rateEUR = 27.60;

        static void Main(string[] args)
        {
            Console.WriteLine("Insert amount:");
            double sum = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert currency: UAH, USD or EUR");
            string currency = Console.ReadLine().ToUpper();

            Console.WriteLine("You entered: {0} {1}", sum, currency);
                        
            for (; ; )      // Dejkstra (or Spider...)
            {
                Console.WriteLine("\nTo which currency you want to convert? (UAH, USD or EUR)");
                string changedCurrency = Console.ReadLine().ToUpper();

                switch (changedCurrency)
                {
                    case "UAH":
                        ConvertUAH(ref sum, ref currency);
                        Console.WriteLine("Now You have: {0} {1}", sum, currency);
                        continue;
                    case "USD":
                        ConvertUSD(ref sum, ref currency);
                        Console.WriteLine("Now You have: {0} {1}", sum, currency);
                        continue;
                    case "EUR":
                        ConvertEUR(ref sum, ref currency);
                        Console.WriteLine("Now You have: {0} {1}", sum, currency);
                        continue;
                    case "EXIT":
                        Console.WriteLine("\nExit the program");
                        break;
                    default:
                        Console.WriteLine("You entered invalid currency");
                        break;
                }
                break;
            }
            // Delay
            Console.ReadKey();
        }
                
        // Converters
        #region To UAH
        static void ConvertUAH(ref double amount, ref string currency)
        {
            if (currency == "USD")
            {
                Console.WriteLine("Rate: {0}", 1/rateUSD);
                amount *= rateUSD;
            }
            else if (currency == "EUR")
            {
                Console.WriteLine("Rate: {0}", 1/rateEUR);
                amount *= rateEUR;
            }
            currency = "UAH";
        }
        #endregion

        #region To USD
        static void ConvertUSD(ref double amount, ref string currency)
        {
            if (currency == "UAH")
            {
                Console.WriteLine("Rate: {0}", rateUSD);
                amount /= rateUSD;
            }
            else if (currency == "EUR")
            {
                Console.WriteLine("Rate: {0}", rateUSD / rateEUR);
                amount *= (rateEUR / rateUSD);
            }
            currency = "USD";
        }
        #endregion

        #region To EUR
        static void ConvertEUR(ref double amount, ref string currency)
        {
            if (currency == "UAH")
            {
                Console.WriteLine("Rate: {0}", rateEUR);
                amount /= rateEUR;
            }
            else if (currency == "USD")
            {
                Console.WriteLine("Rate: {0}", rateEUR / rateUSD);
                amount *= (rateUSD / rateEUR);
            }
            currency = "EUR";
        }
        #endregion
    }
}
