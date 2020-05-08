using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[8]; // Массив нельзя помещать в "рабочий" класс, который делает всю работе - там нифига с ним нельзя сделать - методы его не видят, цикл с заполнением не видит. надо здесь его создавать как говориться в качестве объекта, а потом уже этот объект загонять в "рабочий" класс и там его обрабатывать.

            RailWayStation.FillTrains(trains);

            RailWayStation.SortTrains(trains);

            RailWayStation.ShowTrains(trains);

            Console.ReadKey();

        }
    }
}
