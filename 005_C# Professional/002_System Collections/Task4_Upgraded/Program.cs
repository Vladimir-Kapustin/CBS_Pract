using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Upgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedDictionary od = new OrderedDictionary(new Comparer())
            {
                {new Car(50, 60, "Johnny"), "Red"},
                {new Car(55, 65, "Freddie"), "Brown"},
                {new Car(45, 73, "Wally"), "Black"},
                {new Car(55, 65, "Bobbie"), "Green"}
            };

            //od.Add(new Car(50, 60, "Johnny"), "Red");
            //od.Add(new Car(55, 65, "Freddie"), "Brown");
            //od.Add(new Car(45, 73, "Wally"), "Black");
            //od.Add(new Car(55, 65, "Freddie"), "Green");

            foreach (DictionaryEntry d in od)
            {
                Console.WriteLine("{0}: {1}", d.Key, d.Value);
            }
        }
    }

    public class Comparer : IEqualityComparer
    {
        public new bool Equals(object x, object y)
        {
            Car car1 = (Car)x;
            Car car2 = (Car)y;

            return car1.Height == car2.Height;
        }

        public int GetHashCode(object obj)
        {
            Car car = (Car)obj;
            return car.Length;
        }
    }

    public class Car
    {
        int length;
        int height;
        string petName;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public string PetName
        {
            get { return petName; }
            set { petName = value; }
        }

        public Car(int length, int height, string petName)
        {
            this.length = length;
            this.height = height;
            this.petName = petName;
        }

        //public override bool Equals(object obj)               // вот это нельзя делать: Итрерфейс IEqualityComparer применяется в тех случаях, когда НЕЛЬЗЯ изменить механизм проверки на равенство В САМОМ КЛАССЕ КЛЮЧА!
        //{
        //    Car car = (Car)obj;
        //    return this.length == car.length && this.height == car.height;
        //}

        //public override int GetHashCode()
        //{
        //    return this.petName.ToString().ToLowerInvariant().GetHashCode();
        //}

        public override string ToString()
        {
            return petName;
        }
    }
}
