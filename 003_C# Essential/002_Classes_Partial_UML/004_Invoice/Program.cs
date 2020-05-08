using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(10000, "Trofimov", "Trade LTD");
            invoice.Article = "watermelon";
            invoice.Quantity = 50;

            //false - означает вывести стоимость без НДС. true - с НДС.
            invoice.ShowCost(false);
            invoice.ShowCost(true);
        }
    }
}
