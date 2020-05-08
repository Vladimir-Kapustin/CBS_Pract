using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Invoice
{
    class Invoice
    {
        //Fields
        readonly int account;
        readonly string customer, provider;
        private string article;
        private int quantity;

        //Properties
        public string Article { get { return article; } set { article = value; } }

        public int Quantity { get { return quantity; } set { quantity = value; } }

        //Ctors
        public Invoice() { }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        //Method that calculates the value with or without VAT
        public void ShowCost(bool vat)
        {
            double cost = 0;

            switch (article)
            {
                case "lemon": cost = 7;
                    break;
                case "orange": cost = 10;
                    break;
                case "watermelon": cost = 40;
                    break;
                default: Console.WriteLine("No such product");
                    break;
            }

            if (!vat)
            {
                cost = cost / 6 * 5;
            }

            Console.WriteLine("sum is: {0}", Math.Round(cost * quantity, 2));
        }
    }
}
