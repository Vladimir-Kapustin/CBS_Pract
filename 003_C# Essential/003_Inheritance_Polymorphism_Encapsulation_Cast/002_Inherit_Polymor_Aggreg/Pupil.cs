using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Inherit_Polymor_Aggreg
{
    class Pupil
    {
        protected string name;

        public virtual void Study() { }

        public virtual void Read() { }

        public virtual void Write() { }

        public virtual void Relax() { }

         public void Print()
        {
            Console.WriteLine(name);
            Study();
            Read();
            Write();
            Relax();
        }
    }
}
