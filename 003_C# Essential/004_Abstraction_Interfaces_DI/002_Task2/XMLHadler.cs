using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Task2
{
    class XMLHadler : AbstractHadler
    {
        public override void Open() { Console.WriteLine("Opened XML Document"); }
        public override void Create() { Console.WriteLine("Created XML Document"); }
        public override void Change() { Console.WriteLine("Changed XML Document"); }
        public override void Save() { Console.WriteLine("Saved XML Document"); }
    }
}
