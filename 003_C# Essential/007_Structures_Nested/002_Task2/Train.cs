using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Task2
{
    public struct Train
    {
        string destination;

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        DateTime time;

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
    }
}
