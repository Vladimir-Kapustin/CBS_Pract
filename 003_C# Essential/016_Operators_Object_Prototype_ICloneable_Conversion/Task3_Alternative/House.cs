using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Alternative
{
    public class Street : ICloneable    // задачка-то была сделать метод Clone() - намёк. На реализацию соответствующего ин-са.
    {
        string name;

        public Street(string name)  // правила: делать пользовательский к-р при необходимости
        {
            this.name = name;
        }

        public Street() { }

        public string Name          // правило: всегда делать свойство доступа к закрытому члену. Инкапсуляцая-с.
        {
            get { return name; }
            set { name = value; }
        }

        public object Clone()
        {
            return new Street(this.name);
        }
    }
    class House
    {
        int number;
        Street street;

        public House(Street street, int number)
        {
            this.number = number;
            this.street = street;
        }

        public House() { }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public Street Street
        {
            get { return street; }
            set { street = value; }
        }

        public House Clone()
        {
            return this;
        }

        public House DeepClone()
        {
            return new House(this.street.Clone() as Street, this.Number);
        }

    }
}
