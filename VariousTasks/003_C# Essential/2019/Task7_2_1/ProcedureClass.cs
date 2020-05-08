using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_2_1
{
    static class ProcedureClass
    {
        public static void Add(Train[] trains)
        {
            string route;
            int number;
            DateTime time;
            
            string temp;

            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Введите направление");
                route = Console.ReadLine();
                route = string.IsNullOrEmpty(route) ? "Маршрут не задан" : route;

                Console.WriteLine("Введите номер поезда");
                temp = Console.ReadLine();
                number = string.IsNullOrEmpty(temp) ? 0 : Convert.ToInt32(temp);

                Console.WriteLine("Введите дату и время");                              //--примерно в таком формате "17:50 03.12.2019", можно добавлять секунды, сокращать может что-то - такой формат не совпадает со статьёй на Docs.microsoft, это от формата времени в системе зависит, по-видимому...
                temp = Console.ReadLine();
                time = string.IsNullOrEmpty(temp) ? DateTime.Now : DateTime.Parse(temp);

                trains[i] = new Train(route, number, time);
            }
            
        }
        
        public static void Sort(Train[] array)       // Bubble sort
        {
            int cycles = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < cycles; j++)
                {
                    Swap(array, j, (j + 1));
                }
                cycles--;
            }
        }

        static void Swap(Train[] array, int left, int right)
        {
            if (array[left].TrainNumber > array[right].TrainNumber)
            {
                Train temp = array[left];
                array[left] = array[right];
                array[right] = temp;
            }
        }

        public static void ShowAll(Train[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Train number: {0}\nRoute: {1}\n Time: {2:f}", array[i].TrainNumber, array[i].Route, array[i].Time);
            }
        }

        public static void Search(Train[] trains, int trainNumber)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].TrainNumber == trainNumber)
                {
                    Console.WriteLine("Train number: {0}\nRoute: {1}\n Time: {2:f}", trains[i].TrainNumber, trains[i].Route, trains[i].Time);
                    return;
                }
            }
            Console.WriteLine("No such train with such number: {0}", trainNumber);
        }
    }
}
