using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Task2
{
    abstract class AbstractHadler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }
}
