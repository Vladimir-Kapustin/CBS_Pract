using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection nv = new NameValueCollection
                {
                    {"Петров", "Фармацевтика"},
                    {"Сидоров", "Продукты питания"},
                    {"Кристофоров", "Бытовая химия"},
                    {"Johnson", "Фармацевтика"},
                    {"Синичкин","Одежда"},
                    {"Унакий","Продукты питания"},
                    {"Петров", "Строительные материалы"},
                    {"Кристофоров", "Одежда"},
                    {"Унакий", "Бытовая химия"},
                    {"Синичкин", "Фармацевтика"}
                };
            
            foreach (String s in nv.AllKeys)
            {
                Console.WriteLine("{0,-20} {1}", s, nv[s]);
            }


        }
    }
}