using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("i345", "ASUS", 7000);
            notebook.Show();
        }
    }

    public struct Notebook
    {
        string model;
        string producer;
        int price;

        public Notebook(string model, string producer, int price)
        {
            this.model = model;
            this.producer = producer;
            this.price = price;
        }

        public void Show()
        {
            Console.WriteLine("The model is: {0}\nThe manufacturer: {1}\nPrice is: {2}", model, producer, price);
        }
    }
}
