using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test_Verification
{
    class Program
    {
        static void Main(string[] args)
        {
            // правильные и неправильные варианты создания потоков:
            Thread thread = new Thread(() => { });
            Thread thread1 = new Thread();
            Thread thread2 = new Thread((x) => { });
            Thread thread3 = new Thread((x, y) => { });
        }
    }
}
