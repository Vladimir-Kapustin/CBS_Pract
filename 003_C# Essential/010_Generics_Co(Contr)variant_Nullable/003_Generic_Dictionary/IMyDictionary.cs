using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Generic_Dictionary
{
    interface IMyDictionary <TKey, TValue>
    {
        void Add(int i, TKey key, TValue value);
        string this [int index] { get;}
        int Length { get; }
    }
}
