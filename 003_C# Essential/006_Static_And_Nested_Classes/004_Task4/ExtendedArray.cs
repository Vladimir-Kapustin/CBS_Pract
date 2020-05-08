using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Task4
{
   static class ExtendedArray
    {
       public static int [] Sort (this int [] array)
       {
           // Способ 1.
           //int[] newArray = new int [array.Length];
           //for (int i = 0; i < array.Length; i++)
           //{
           //    for (int j = array.Length - 1; j > i; j--)
           //    {
           //        if (array[i] > array[j])
           //        {
           //            int x = array[j];
           //            array[j] = array[i];
           //            array[i] = x;

           //            if (j==i-1)                        // Это уже моё творчество - комментировать. А то не понятно потом.
           //            {
           //                newArray[i] = array[i];            
           //            }
           //        }

           //    }
           //}
           //return newArray;

           // Способ 2. Мой способ

           int[] newArray = array;
           Array.Sort(newArray);
           return newArray;
       }
    }
}
