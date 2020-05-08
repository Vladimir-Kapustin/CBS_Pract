using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _000_Recursion_In_Threads
{
    class Program
    {
        static int variable = 0;
        static void TheMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                variable++;
                Console.WriteLine("Started Method {0}", variable);
                Thread newThread = new Thread(TheMethod);
                newThread.Start();
            }
        }

        static void Main(string[] args)
        {
            ThreadStart recursion = new ThreadStart(TheMethod);
            Thread thread = new Thread(recursion);
            thread.Start();

        }
    }
}
