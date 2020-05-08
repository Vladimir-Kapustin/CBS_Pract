using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Task2
{
    class TXTHandler : AbstractHadler
    {
        public override void Open() { Console.WriteLine("Opened TXT Document"); }
        public override void Create() { Console.WriteLine("Created TXT Document"); }
        public override void Change() { Console.WriteLine("Changed TXT Document"); }
        public override void Save() { Console.WriteLine("Saved TXT Document"); }
    }
}
