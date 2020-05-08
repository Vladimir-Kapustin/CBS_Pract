using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Inherit_Polymorph
{
    class Vehicle
    {
        protected int price;
        protected int speed;
        protected int year;
        protected string name;
        
        public Vehicle (int price, int speed, int year)
        {
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

        public virtual void Show()
        {
            Console.WriteLine("Name {0}: Price: {1}, Speed: {2}, Year {3}", name, price, speed, year);
        }
    }
    
    class Plane : Vehicle
    {
        private int height;
        private int passengers;

        public Plane(int height, int passengers, int price, int speed, int year)
            : base(price, speed, year) 
        {
            this.height = height;
            this.passengers = passengers;
            this.name = "Plane";
        }

        public override void Show()
        {
            Console.WriteLine("Name {0}: Price: {1}, Speed: {2}, Year {3}, Height: {4}, Passengers: {5}", name, price, speed, year,
                height, passengers);
        }
    }

    class Car : Vehicle
    {
        public Car (int price, int speed, int year)
            : base(price, speed, year) 
        {
            this.name = "Car";
        }
    }

    class Ship : Vehicle
    {
        private int passengers;
        private string port;

        public Ship (int passengers, string port, int price, int speed, int year)
            : base(price, speed, year) 
        {
            this.passengers = passengers;
            this.port = port;
            this.name = "Ship";
        }
        public override void Show()
        {
            Console.WriteLine("Name {0}: Price: {1}, Speed: {2}, Year {3}, Passengers: {4}, port: {5}", name, price, speed, year,
                passengers, port);
        }
    }
}
