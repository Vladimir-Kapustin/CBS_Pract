using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Task2_Generics_Collection
{
    public class SomeClass
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов в массиве");
            int number = int.Parse(Console.ReadLine());

            //Объявление класса-коллекции
            MyList<SomeClass> myList = new MyList<SomeClass>(number);

            //Заполнение класса-коллекции элементами типа SomeClass
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Заполняем...");
            for (int i = 0; i < myList.Length; i++)
            {
                myList.Add(i, new SomeClass());
            }
            myList.Add(55, new SomeClass()); //попытка ввода несуществующего индекса

            //вывод коллекции
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Выводим...");
            for (int i = 0; i < myList.Length; i++)
            {
                Console.WriteLine(myList[i].GetType().Name);
            }

            Console.ReadKey();
        }
    }
}
