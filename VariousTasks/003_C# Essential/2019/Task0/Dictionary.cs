using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] value = new string[5];
        private string[] valueUkr = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; value[0] = "book"; valueUkr[0] = "книга";
            key[1] = "ручка"; value[1] = "pen"; valueUkr[1] = "ручка";
            key[2] = "солнце"; value[2] = "sun"; valueUkr[2] = "сонце";
            key[3] = "яблоко"; value[3] = "apple"; valueUkr[3] = "яблуко";
            key[4] = "стол"; value[4] = "table"; valueUkr[4] = "стiл";
        }

        public string this[string index]            //--Здесь 2 индексатора. Правило: индексаторы могут отличаться друг от друга только типом и количеством индексов. можно сказать: "перегрузки" индексаторов могут отличаться друг от друга и/или количеством индексов.
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                        return key[i] + " - (анг.) " + value[i] + " - (укр.) " + valueUkr[i];
                    if (value[i] == index)
                        return value[i] + " - (рус.) " + key[i] + " - (укр.) " + valueUkr[i];
                    if (valueUkr[i]==index)
                        return valueUkr[i] + " - (анг.) " + value[i] + " - (рус.) " + key[i];
                }
                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - (анг.) " + value[index] + " - (укр.) " + valueUkr[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
}
