using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Store
    {
        private Article[] articles;

        public Store()
        {
            Console.WriteLine("Сколько товаров вы хотите ввести?");
            articles = new Article[Int32.Parse(Console.ReadLine())];
            Fill();
        }

        private void Fill()
        {
            for (int i = 0; i < articles.Length; i++)
            {
                articles[i] = new Article();
                Console.WriteLine("Введите имя товара {0}:", i + 1);
                articles[i].ProductName = Console.ReadLine();

                Console.WriteLine("Введите имя магазина для товра {0}:", i + 1);
                articles[i].StoreName = Console.ReadLine();

                Console.WriteLine("Введите цену для товара{0}:", i + 1);
                articles[i].Price = Int32.Parse(Console.ReadLine());
            }
        }

        //Индексатор по номеру товара
        public Article this[int number]
        {
            get
            {
                return articles[number];
            }
        }

        //Индаксатор по названию товара
        public Article this[string name]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].ProductName==name)
                        return articles[i];
                }
               Console.WriteLine("Нет товара с таким именем");
                        return null;
            }
        }

        //Программа вывода на экран информации о товаре
        public void ShowInfo(Article product)
        {
            Console.WriteLine("По данному товару информация следующая:"); 
            Console.WriteLine("Product name - {0}", product.ProductName);
            Console.WriteLine("Store name - {0}", product.StoreName);
            Console.WriteLine("Product Price - {0}", product.Price);
        }
    }
}
