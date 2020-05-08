using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Generic_User_Collection
{
    public interface ICarCollection <T>
    {
        void Add(T element);
        T this[int index] { get; }
        int Length { get; }
    }
}
