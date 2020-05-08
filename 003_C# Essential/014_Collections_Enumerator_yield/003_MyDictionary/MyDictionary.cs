using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_MyDictionary
{
    class MyDictionary <TKey, TValue>
    {
        readonly MyList<TKey> myKey = new MyList<TKey>();
        readonly MyList<TValue> myValue = new MyList<TValue>();

        public void Add(TKey key, TValue value)
        {
            myKey.Add(key);
            myValue.Add(value);
        }

        public TValue this[int index]
        {
            get
            {
                if (index>=0 && index<=myKey.Count)
                {
                    return myValue[index];
                }
                else
                {
                    return default(TValue);   
                }
            }
        }

        public TValue this[TKey index]
        {
            get
            {
                for (int i = 0; i < myKey.Count-1; i++)
                {
                    if ((string)(object)myKey[i] == (string)(object)index)  // вот эти приведения "(string)(object)" делаются для того, чтобы сравнить операнды, тип которых TKey можно было сравнивать. Два операнда заполняемого типа (таких как TKey) сравнить нельзя - компилятор выдаст ошибку.
                    {
                        return myValue[i];
                    }
                }
                return default(TValue);
            }
        }

        public int Count
        {
            get
            {
                return myKey.Count;
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            for (int i = 0; i < myKey.Count-1; i++)
            {
                yield return (string)(object)myKey[i] + "-" + (string)(object)myValue[i];
            }
        }
    }
}
