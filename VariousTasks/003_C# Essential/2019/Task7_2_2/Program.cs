using System;                                       // С индексатором решил сделать. Единственный минус - это то, что в классе с поездами массив
using System.Collections.Generic;                   // не строковых значений, а значений типа Train, а по идее индексатор и должен возвращать значения
using System.Linq;                                  // того же типа, что и тип содержащегося в классе массива, а когда мы пробегаемся по массиву 
using System.Text;                                  // и выходим за пределы - нельзя сделать проверку выхода за пределы, и вывести строковое сообщение
using System.Threading.Tasks;                       // об этом, т.к. индексатор в этом случае должен был бы возвращать строковое значение.
                                                    // Но технически можно сделать индексатор с любым возвращаемым значением - поэтому я поизвращался
namespace Task7_2_2                                 // со строковым индексатором, который будет возвращать нужное значение для сообщений об ошибках.
{                                                   // Можно вообще даже сделать индексатор void - и просто фигачить там сообщения. Но это не то...
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество поездов:");
            int number = Convert.ToInt32(Console.ReadLine());

            Station station = new Station(number);

            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Введите информацию о поездах:");
            Console.WriteLine(new string('-', 30));

            station.Add();
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Вы ввели:");

            station.Show();
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("После сортировки:");

            station.Sort();
            station.Show();
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Введите номер искомого поезда:");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Информация об искомом поезде:");
            station.Search(number);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Введите порядковый номер в списке поездов:");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 30));

            // Код для закомментированного индексатора
            //Console.WriteLine("Информация об искомом поезде:");
            //Console.WriteLine("Train number: {0}\nRoute: {1}\n Time: {2:f}", station[number].TrainNumber, station[number].Route, station[number].Time);

            // Код для второго индексатора
            Console.WriteLine("Информация об искомом поезде:");
            Console.WriteLine(station[number]);
        }
    }
}
