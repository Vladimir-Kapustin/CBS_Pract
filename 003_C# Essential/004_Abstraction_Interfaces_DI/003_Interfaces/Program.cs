using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose operation: Play or Record");
            Player player = new Player();

            switch (Console.ReadLine().ToLower())
            {
                case "play": 
                    player.Play();
                    (player as IPlayable).Pause();
                    (player as IPlayable).Stop();
                    break;
                case "record": 
                    player.Record();
                    (player as IRecordable).Pause();
                    (player as IRecordable).Stop();
                    break;
                default: Console.WriteLine("no such operation");
                    break;
            }
            Console.ReadKey();
        }
    }
}
