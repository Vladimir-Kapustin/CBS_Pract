using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[8];

            trains[0] = new Train("Moscow", 89, new DateTime(2019, 03, 03, 17, 43, 00));
            trains[1] = new Train("Kiev", 64, new DateTime(2019, 03, 25, 21, 00, 00));
            trains[2] = new Train("Minsk", 157, new DateTime(2019, 03, 04, 18, 30, 00));
            trains[3] = new Train("Lvov", 138, new DateTime(2019, 03, 15, 17, 15, 00));
            trains[4] = new Train("Simferopol", 44, new DateTime(2019, 03, 11, 09, 23, 00));
            trains[5] = new Train("Riga", 33, new DateTime(2019, 03, 16, 19, 01, 00));
            trains[6] = new Train("Vladivostok", 256, new DateTime(2019, 03, 07, 20, 35, 00));
            trains[7] = new Train("Vilnus", 12, new DateTime(2019, 03, 22, 18, 55, 00));

            ShowAll(trains);
            Console.WriteLine(new string('-', 30));

            Sort(trains);

            ShowAll(trains);
            Console.WriteLine(new string('-', 30));

            Show(trains, 44);
            Console.WriteLine(new string('-', 30));

            Show(trains, 55);

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

        public static void Show(Train[] trains, int trainNumber)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].TrainNumber==trainNumber)
                {
                    Console.WriteLine("Train number: {0}\nRoute: {1}\n Time: {2:f}", trains[i].TrainNumber, trains[i].Route, trains[i].Time);
                    return;
                }
            }
            Console.WriteLine("No such train with such number: {0}", trainNumber);
        }
    }

    public struct Train
    {
        string route;
        int trainNumber;
        DateTime time;

        public Train(string route, int trNumber, DateTime departTime)
        {
            this.route = route;
            this.trainNumber = trNumber;
            this.time = departTime;
        }

        public string Route { get { return route; } }
        public int TrainNumber { get { return trainNumber; } }
        public DateTime Time { get { return time; } }
    }
}
