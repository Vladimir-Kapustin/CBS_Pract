using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> dict0 = new Dictionary<int, double>();
            dict0.Add(1234, 100000);
            dict0.Add(4321, 200000);
            dict0.Add(4567489, 1000000.01);
            dict0.Add(9999, 2000000);
            dict0.Add(8888, 550000.45);
            dict0.Add(77717, 456654.15);

            foreach (KeyValuePair<int,double> account in dict0)
            {
                Console.WriteLine("account: {0}, amount: {1}", account.Key, account.Value);
            }

            Console.WriteLine(new string('-', 50));

            SortedDictionary<int, double> dict11 = new SortedDictionary<int, double>();
            dict11.Add(1234, 100000);
            dict11.Add(4321, 200000);
            dict11.Add(4567489, 1000000.01);
            dict11.Add(9999, 2000000);
            dict11.Add(8888, 550000.45);
            dict11.Add(77717, 456654.15);

            foreach (KeyValuePair<int, double> account in dict11)
            {
                Console.WriteLine("account: {0}, amount: {1}", account.Key, account.Value);
            }

            Console.WriteLine(new string('-', 50));

            SortedList<int, double> dict2 = new SortedList<int, double>();
            dict2.Add(1234, 100000);
            dict2.Add(4321, 200000);
            dict2.Add(4567489, 1000000.01);
            dict2.Add(9999, 2000000);
            dict2.Add(8888, 550000.45);
            dict2.Add(77717, 456654.15);

            foreach (KeyValuePair<int, double> account in dict2)
            {
                Console.WriteLine("account: {0}, amount: {1}", account.Key, account.Value);
            }

            Console.WriteLine(new string('-', 50));
        }
    }
}
