using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Inherit_Polymor_Aggreg
{
    class BadPupil : Pupil
    {
        public BadPupil(string name)
        {
            this.name = name;
        }
        
        public override void Study() { Console.WriteLine("Studies Bad"); }

        public override void Read() { Console.WriteLine("Reads Bad"); }

        public override void Write() { Console.WriteLine("Writes Bad"); }

        public override void Relax() { Console.WriteLine("Relaxes Bad"); }
    }
}
