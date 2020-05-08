using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Inherit_Polymor_Aggreg
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom schoolClass = new ClassRoom(new ExcelletnPupil ("Petr"), new GoodPupil ("Maxim"));
            schoolClass.Show();

            Console.ReadKey();
        }
    }
}
