using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_User_ArrayList
{
    class MyArrayList
    {
         object[] array;                        // Весь смысл - в создании массива типа Object - вот бля как я не догадался. Естесственно!

        public MyArrayList()                    // default ctor, initializing the array
        {
            array = new object[0];
        }

        public void Add(object element)                  // Add - Method for adding elements
        {
            object[] tempArray = new object[array.Length + 1];
            for (int i = 0; i < array.Length; i++) 
            {
                tempArray[i] = array[i];            
            }
            tempArray[array.Length] = element;  
            array = tempArray;                      
        }

        public object this[int index]                    // Indexer - for getting elements by index
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }
                else
                {
                    Console.WriteLine("Попытка обращения к индексу, находящемуся за пределами массива");
                    return null;
                }
            }
        }

        public int Count { get { return array.Length; } }      // Property - for getting length of collection (array)

        public void Clear()                                     // Method - for clearing the collection.
        {
            array = new object[array.Length];
        }

        public override string ToString()
        {
            string stroka = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                stroka += array[i] + "\n";
            }
            return "Размерность массива:" + array.Length + "Элементы массива:\n" + stroka;
        }

        public bool Contains(object item) //Метод-предикат предназначенный для поиска элемента в массиве
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
