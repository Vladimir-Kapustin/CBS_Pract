using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Generic_User_Collection
{
    class Car
    {
        string name;
        int year;

        public Car (string name, int year)
        {
            this.name = name;
            this.year = year;
        }

        public string Name
        {
            get { return name; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
    }
}
