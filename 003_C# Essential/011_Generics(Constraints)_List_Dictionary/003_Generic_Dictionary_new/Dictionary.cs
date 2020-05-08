using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Generic_Dictionary_new
{
    class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        readonly MyList<TKey> myKey = null;
        readonly MyList<TValue> myValue = null;

        public Dictionary()
        {
            this.myKey = new MyList<TKey>();
            this.myValue = new MyList<TValue>();
        }
        public void Add(TKey key, TValue value)
        {
            myKey.Add(key);
            myValue.Add(value);
        }

        public string this[int index]   //индексатор для получения значения элемента по указанному индексу
        {
            get
            {
                if (myKey[index] == null)
                {
                    return null;
                }
                else
                    if (index >= 0 && index < myKey.Count)
                    {
                        return myKey[index] + "-" + myValue[index]; // когда myKey[index] конкатенируется с "-", получается строка. Если myKey закрыт типом string, то просто происходит конкатенаия; а если закрыт типом int, то при конкатенации вызвается метод ToString() типа int, который переводит целочисленное значение в строку - и далее, опять же, происходит конкатенация двух строк.
                    }
                    else
                    {
                        Console.WriteLine("Попытка ввести индекс, выходящий за пределы массива");
                        return null;
                    }
            }
        }

        public int Count { get { return myKey.Count; } }        //Свойство только для чтения для получения общего количества пар элементов

        public override string ToString() //Переопределенный метод ToString базового класса Object 
        {
            string stroka = string.Empty;
            for (int i = 0; i < myKey.Count; i++)
            {
                stroka += myKey[i] + " " + myValue[i] + "\n";
            }
            if (stroka != null)
                return stroka;
            return "В словаре нет значений.";
        }
    }
}
