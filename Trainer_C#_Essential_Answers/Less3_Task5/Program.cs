using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                        //В классе Derived переопределите метод Method так, чтобы он возвращал возвращаемое значение этого же метода из базового класса + пробел + "derived " + i
namespace Less3_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Base obj = new Derived();
            Console.WriteLine(obj.Method(5));

            Console.ReadKey();
        }
    }

    class Base
    {
        public virtual string Method(int i)
        {
            return "Base " + i;
        }
    }

    class Derived : Base
    {
        public override string Method(int i)
        {
            return "Base " + i + " " + "derived " + i;
        }
    }
}
//--тут наверное на внимательность - ну где пробелы там поставить и т.п.