using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                //В классе MyClass создать приватное строковое поле с именем name, а затем открытое строковое свойство с именем Name, которое будет использовать это поле. Если name - пустая строка или имеет значение null, то метод доступа get должен возвращать строку "Name is not defined", иначе - возвращать значение поля name. Метод доступа set должен просто присваивать полю name значение без каких-либо проверок.
namespace Less1_Task2
{
    class MyClass
    {
        private string name;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                if (String.IsNullOrEmpty(name))
                {
                    return "Name is not defined";
                }
                else
                {
                    return name;
                }
            }
        }
    }
}
