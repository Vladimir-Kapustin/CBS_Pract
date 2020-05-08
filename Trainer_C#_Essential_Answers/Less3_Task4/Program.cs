using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                        //В дочернем классе BMW_X5 переопределите метод Drive так, чтобы он возвращал такую же строку, что и в базовом классе BMW, только чтобы вместо марки авто “BMW” выводилась марка “BMW X5”
namespace Less3_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            BMW auto = new BMW_X5();

            Console.WriteLine(auto.Drive(80));

            Console.ReadKey();
        }
    }

    class BMW
    {
        public virtual string Drive(ushort speed)
        {
            return "I'm a BMW auto and I run with speed " + speed + " km/h";
        }
    }

    class BMW_X5 : BMW
    {
        public override string Drive(ushort speed)
        {
            return "I'm a BMW X5 auto and I run with speed " + speed + " km/h";     
        }
    }
}
//--тут наверное на внимательность - надо было заметить, что надо написать не BMW_X5, а BMW X5 без подчёркивания. то же и в следующей задаче.
