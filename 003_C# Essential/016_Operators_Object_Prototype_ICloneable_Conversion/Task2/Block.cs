using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Block
    {
        int first, second, third, fourth;

        public Block(int first, int second, int third, int fourth)
        {
            this.first = first;
            this.second = second;
            this.third = third;
            this.fourth = fourth;
        }

        public override bool Equals(object obj) // Алгоритм: 1. Принимаем только object (ведь мы можем сравнивать с любым объектом), 2. Проверяем не пустой ли он, 3. Проверяем соответствие типов данного класса и входящего объекта, 4. Приводим объект к типу класса, 5. Проверяем равенство.
        {
            if (obj==null || obj.GetType()!=this.GetType())
            {
                return false;
            }

            Block block = (Block)obj;
            if ((first == block.first) && (second == block.second) && (third == block.third) && (fourth == block.fourth))
            {
                return true;
            }
            else
            {
                return false;
            }
            // можно было просто написать такую строку:
            // return (side1 == p.side1) && (side2 == p.side2) && (side3 == p.side3) && (side4 == p.side4);
        }

        public override int GetHashCode()
        {
            return first * second * third * fourth; // можно исключающее или, что угодно.
        }

        public override string ToString()
        {
            return string.Format("First field: {0}\n" + "Second field: {1}\n" + "Third field: {2}\n" + "Fourth field: {3}", first, second, third, fourth);
        }

    }
}
