using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Generic_Dictionary
{
    class MyDictionary<TKey, TValue> : IMyDictionary<TKey, TValue>
    {
        TKey[] key = null;
        TValue[] value = null;

        public MyDictionary(int number)
        {
            key = new TKey[number];
            value = new TValue[number];
        }

        public void Add(int i, TKey key, TValue value)
        {
            if (i >= 0 && i <this.key.Length )
            {
                this.key[i] = key;
                this.value[i] = value;
            }
            else
            {
                Console.WriteLine("Попытка выйти за пределы массива");
            }
        }

        public string this[int index]   //индексатор для получения значения элемента по указанному индексу
        {
            get
            {
                if (key[index] == null)
                {
                    return null;
                }
                else
                if (index >= 0 && index < key.Length)
                {
                    return key[index] + "-" + value[index];
                }
                else 
                {
                    Console.WriteLine("Попытка выйти за пределы массива");
                    return null;
                }
            }
        }

        public int Length { get { return key.Length; } }        //Свойство только для чтения для получения общего количества пар элементов
    }
}
