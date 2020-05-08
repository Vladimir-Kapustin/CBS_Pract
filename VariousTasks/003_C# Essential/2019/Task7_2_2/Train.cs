using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_2_2
{
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
