using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_AbstractClass
{
    abstract class Part
    {
        protected string content;   // поле, которое наследуется и используется во всех производных классах
        public abstract string Content { get; set; }
        public abstract void Show();
    }
}
