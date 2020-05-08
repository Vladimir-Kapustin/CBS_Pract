using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Task2_Generics_Collection
{
    interface IMyList <T>
    {
        void Add(int index, T value); //сигнатура метода для ввода значений в массив
        T this[int index] { get; }  //сигнатура индексатора
        int Length { get; } //сигнатура свойства Length
    }
}
