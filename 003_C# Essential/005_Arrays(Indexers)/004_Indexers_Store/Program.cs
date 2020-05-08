using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                            //Требуется: Создать класс Article, содержащий следующие закрытые поля: • название товара; • название магазина, в котором продается товар; • стоимость товара в гривнах. Создать класс Store, содержащий закрытый массив элементов типа Article. Обеспечить следующие возможности: • вывод информации о товаре по номеру с помощью индекса; • вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет, выдать соответствующее сообщение; Написать программу, вывода на экран информацию о товаре.  // Автор делает инфо о товаре в классе Article, т.е. каждый экземпляр в массиве может сам на себе вызывать метод с выводом информации. Автор также сделал сортировку массива по цене. Архитектуру немного другую сделал. Если есть время, можно покопаться и сделать то же самое. А мой вариант - подойдёт.
namespace _004_Indexers_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Введите номер товара");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Цена товара под номером {0}: {1}", number, store[number].Price);

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Введите имя товара");
            string name = Console.ReadLine();
            Console.WriteLine("Имя магазина, в котором продаётся товар с именем {0}: {1}", name, store[name].StoreName);

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Введите ещё раз номер товара");
            number = Int32.Parse(Console.ReadLine());
            store.ShowInfo(store[number]);
        }
    }
}
