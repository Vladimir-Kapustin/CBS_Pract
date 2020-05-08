using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Enumerators
{
    public class Month
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public int Days { get; set; }

        public override string ToString()
        {
            return string.Format("Месяц: {0}, номер: {1}, количество дней: {2}", Name, Number, Days);
        }
    }
}
