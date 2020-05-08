using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_AVL_Tree_And_Balancing
{
    class Program
    {
        static void Main(string[] args)
        {
            AVLTree<int> tree = new AVLTree<int>();

            tree.Add(20);//             1)            20                    2)      20
            tree.Add(12);//                          /  \                          /   \
            tree.Add(15);//                         12   25                       12    25
            tree.Add(6);//                         / \    \                      / \    / \
            tree.Add(9);//                        6  15    30                   6  15  24  30
          //tree.Add(3);// для 1)                / \       / \                   \            
          //tree.Add(1);// для 1)               3   9     27 35                   9             
          //Right                              /               \                                
            tree.Add(25);//                   1                40                                
            tree.Add(30);//                                    /                                
          //tree.Add(27);// для 1)                            38                                
          //tree.Add(35);// для 1)
          //tree.Add(40);// для 1)
          //tree.Add(38);// для 1)
            tree.Add(24);// для 2)      должны быть раскомментированы либо только строки с пометкой 1) либо 2). Без пометок - всегда раскомментированы.
            // Вообще, чтобы правильно работало, нужно раскомментировать 68 строку в классе AVLTree<T> - это балансировка дерева (node.Balance();). Просто в этом случае не получится нарисованное мной дерево в варианте 2) :).

            Console.WriteLine(tree.Contains(12));

           // tree.Remove(15);

            foreach (var item in tree)
            {
                Console.WriteLine(item);
            }

            tree.Remove(15);

            Console.WriteLine("after removal:");

            foreach (var item in tree)
            {
                Console.WriteLine(item);
            }
        }
    }
}
