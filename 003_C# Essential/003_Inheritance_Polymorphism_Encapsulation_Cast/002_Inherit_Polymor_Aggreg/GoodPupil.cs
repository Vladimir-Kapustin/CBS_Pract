using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Inherit_Polymor_Aggreg
{
    class GoodPupil : Pupil
    {
        public GoodPupil (string name)
        {
            this.name = name;
        }

        public override void Study() { Console.WriteLine("Studies Good"); }

        public override void Read() { Console.WriteLine("Reads Good"); }

        public override void Write() { Console.WriteLine("Writes Good"); }

        public override void Relax() { Console.WriteLine("Relaxes Good"); }
    }
}
