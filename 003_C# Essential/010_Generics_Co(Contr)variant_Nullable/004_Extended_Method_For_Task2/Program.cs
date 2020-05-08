using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Extended_Method_For_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов в массиве");
            int number = int.Parse(Console.ReadLine());

            MyList<Program> myList = new MyList<Program>(number);       // Объявление класса-коллекции    
                                                                           
            Console.WriteLine(new string('-', 50));                     // Заполнение класса-коллекции элементами типа Program    
            Console.WriteLine("Заполняем...");                             
            for (int i = 0; i < myList.Length; i++)                        
            {                                                              
                myList.Add(i, new Program());                              
            }                                                              
            myList.Add(55, new Program());                              // попытка ввода несуществующего индекса    

            Console.WriteLine("Выводим... Но по-новому - через метод public static T[] GetArray <T> (this MyList<T> list)");
            var array = MyListExtended.GetArray(myList);                // вывод коллекции по-новому
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].GetType());
            }

            Console.ReadKey();
        }
    }
}
