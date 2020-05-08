using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Street
    {
        string name;

        public Street(string name)
        {
            this.name = name;
        }

        public Street() { }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return name;
        }
    }

    class House
    {
        int number;
        Street street;

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

        public House(int number, string street)
        {
            this.number = number;
            this.street = new Street(street);
        }

        public House() { }

        public House Clone()    // Shallow copy
        {
            return (House)MemberwiseClone();    // можно return this; но, похоже, с MemberwiseClone() быстрее.
        }

        public House DeepClone()    // Deep copy
        {
            House house = (House)MemberwiseClone();
            house.street = new Street(this.street.Name);
            return house;
        }

        public void PrindInfo()
        {
            Console.WriteLine("Номер дома: {0}, " + "Улица: {1}, ", number, street);
        }
    }
}
