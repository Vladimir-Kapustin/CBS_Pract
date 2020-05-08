using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Inherit_Polymor_Aggreg
{
    class ExcelletnPupil : Pupil
    {
        public ExcelletnPupil(string name)
        {
            this.name = name;
        }

        public override void Study() { Console.WriteLine("Studies Excellent"); }

        public override void Read() { Console.WriteLine("Reads Excellent"); }

        public override void Write() { Console.WriteLine("Writes Excellent"); }

        public override void Relax() { Console.WriteLine("Relaxes Excellent"); }
    }
}
