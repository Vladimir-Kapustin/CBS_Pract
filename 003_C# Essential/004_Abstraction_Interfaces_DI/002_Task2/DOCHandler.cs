using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Task2
{
    class DOCHandler : AbstractHadler
    {
        public override void Open() { Console.WriteLine("Opened DOC Document"); }
        public override void Create() { Console.WriteLine("Created DOC Document"); }
        public override void Change() { Console.WriteLine("Changed DOC Document"); }
        public override void Save() { Console.WriteLine("Saved DOC Document"); }
    }
}
