using System;

namespace _000_Indexers
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] value = new string[5];
        private string[] value2 = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; value[0] = "book"; value2[0] = "книга";
            key[1] = "ручка"; value[1] = "pen"; value2[1] = "самописка";
            key[2] = "солнце"; value[2] = "sun"; value2[2] = "сонце";
            key[3] = "яблоко"; value[3] = "apple"; value2[3] = "яблуко";
            key[4] = "стол"; value[4] = "table"; value2[4] = "стiл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                        return key[i] + " - " + value[i] + ", " + value2[i] + "(ukr)";
                    if (value[i] == index)
                        return key[i] + " - " + value[i] + ", " + value2[i] + "(ukr)";
                    if (value2[i] == index)
                        return key[i] + " - " + value[i] + ", " + value2[i] + "(ukr)";
                }

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index] + ", " + value2[index] + "(ukr)";
                else
                    return "Попытка обращения за пределы массива.";
            }
        }      
    }
}
