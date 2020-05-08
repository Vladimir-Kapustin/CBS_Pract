using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Generic_Dictionary_new
{
    interface IDictionary<TKey, TValue>
    {
        void Add(TKey key, TValue value);
        string this[int index] { get; }
        int Count { get; }
    }
}
