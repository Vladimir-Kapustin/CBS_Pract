using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Task2
{
    public static class RailWayStation  //действительно - почему бы не создать статический класс - чтобы обрабатывать поступающие в него данные и не создавать объекта?
    {
        public static void FillTrains(Train [] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Train number {0}", i+1);
                Console.WriteLine("insert destination town");
                trains[i].Destination = Console.ReadLine();

                Console.WriteLine("insert number of train");
                trains[i].Number = Int32.Parse(Console.ReadLine());

                Console.WriteLine("insert date");
                trains[i].Time = DateTime.Parse(Console.ReadLine());        // Время вводить вот так: 6:00
            }
            Console.WriteLine();
        }
        public static void SortTrains(Train[] trains)
        {
            Console.WriteLine("Sorting trains.....:");
            
            for (int i = 0; i < trains.Length; i++)
            {
                for (int j = trains.Length - 1; j > i; j--)
                {
                    if (trains[i].Number > trains[j].Number)
                    {
                        Train x = trains[j];
                        trains[j] = trains[i];
                        trains[i] = x;

                    }

                }
            }
            Console.WriteLine();
        }
        public static void ShowTrains(Train [] trains)
        {
            Console.WriteLine("You insered:");
            for (int i = 0; i < trains.Length; i++)
            {
                Console.Write("destination: {0}, ", trains[i].Destination);
                Console.Write("number: {0}, ", trains[i].Number);
                Console.WriteLine("Time: {0}, ", trains[i].Time);
            }
        }
    }
}
