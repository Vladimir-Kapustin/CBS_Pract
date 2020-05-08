using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                        //Симметрично проассоциируйте класс Class1 с классом Class2, используя аналогичную нотацию именования.
namespace Less2_Task4
{
    class Class1 { Class2 class2; }
    class Class2 { Class1 class1; }
}
