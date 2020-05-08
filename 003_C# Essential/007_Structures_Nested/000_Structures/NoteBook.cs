using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_Structures
{
    struct NoteBook
    {
        string model;
        string manufacturer;
        int price;

        public NoteBook (string model, string manufacturer, int price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }
        
        // Правильность кода. Свойств не было в задании. Я так понимаю, для чтения нормального класса/ структуры должны быть созданы свойства.
        public string Model
        {
            get { return model; }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
        }
        public int Price
        {
            get { return price; }
        }

        // А если нам надо будет ввести одно какое-то поле?
        // тогда нужны дополнительные пользовательские к-ры, НО, поскольку к-р должен инициализировать всё, то - хитрость:
        public NoteBook(string model)
            :this (model,"",0)
        {
        }
        public NoteBook(int price)
            : this("", "", price)
        {
        }                           // хотя что тут такого? нужно ли было всё это? - То же самое можно сделать и в теле дополнительных к-ров, только остальные поля инициализировать в 0.- просто короче. но зачем? другие поля останутся нулевыми, а ситуации, когда в них будт одни значения, а мы пытаемся только некоторым из них присвоить другие через к-р - не может быть...
        
        public void Print()
        {
            Console.WriteLine("Model is {0}", model);
            Console.WriteLine("Manufacturer is {0}", manufacturer);
            Console.WriteLine("Price is {0}", price);
        }
    }
}
