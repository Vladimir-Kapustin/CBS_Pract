using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_2_2
{
    class Station
    {
        Train[] trains;

        public Station(int numberOfTrains)
        {
            trains = new Train[numberOfTrains];
        }

        public void Add()
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

        public void Sort()       // Bubble sort
        {
            int cycles = trains.Length - 1;
            for (int i = 0; i < trains.Length; i++)
            {
                for (int j = 0; j < cycles; j++)
                {
                    Swap(trains, j, (j + 1));
                }
                cycles--;
            }
        }

        void Swap(Train[] array, int left, int right)
        {
            if (array[left].TrainNumber > array[right].TrainNumber)
            {
                Train temp = array[left];
                array[left] = array[right];
                array[right] = temp;
            }
        }

        public void Show()
        {
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Train number: {0}\nRoute: {1}\n Time: {2:f}", trains[i].TrainNumber, trains[i].Route, trains[i].Time);
            }
        }

        //public Train this[int number]                     //обычный индексатор, который возвращает Train - здесь не получится сделать проверку на выход за пределы массива.
        //{
        //    get
        //    {
        //        return trains[number-1];
        //    }
        //}

        public string this[int number]                    //не совсем правильный индексатор, хотя... ничем синтаксически не ошибочен.
        {
            get
            {
                for (int i = 0; i < trains.Length; i++)
                {
                    if (number - 1 == i)
                        return string.Format("Train number: {0}\nRoute: {1}\n Time: {2:f}", trains[i].TrainNumber, trains[i].Route, trains[i].Time);
                }
                return "нет такого поезда";
            }
        }

        public void Search(int number)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].TrainNumber == number)
                {
                    Console.WriteLine("Train number: {0}\nRoute: {1}\n Time: {2:f}", trains[i].TrainNumber, trains[i].Route, trains[i].Time);
                    return;
                }
            }
            Console.WriteLine("Такого поезда нет");
        }
    }
}
