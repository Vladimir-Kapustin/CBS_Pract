using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Set_ArrayBased_With_Methods
{
    class Program
    {
        static void Print(SetCustom customSet)
        {
            foreach (var item in customSet)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            SetCustom set1 = new SetCustom();
            SetCustom set2 = new SetCustom();
            SetCustom set3 = new SetCustom();

            set1.Add("John");
            set1.Add("Mark");
            set1.Add("Fred");
            set1.Add("Julie");
            set1.Add(1);
            set1.Add(2);
            set1.Add(3);
            set1.Add(4);
            set1.Add(5);
            Console.WriteLine(new string('-', 60));
            int [] array = { 4, 5, 6, 7 };
            set2.AddRange(array);
            set2.Add("Mark");
            set2.Add("Fred");
            set2.Add("James");
            Console.WriteLine(new string('-', 60));

            //Union
            Console.Write("\nPrinting the set1: ");
            Print(set1);

            Console.Write("\nPrinting the set2: ");
            Print(set2);

            Console.WriteLine("Union:");
            set3 = set1.Union(set2);
            Print(set3);

            //Difference
            Console.WriteLine(new string('-', 60));
            Console.Write("\nPrinting the set1: ");
            Print(set1);

            Console.Write("\nPrinting the set2: ");
            Print(set2);

            Console.WriteLine("Difference:");
            set3 = set1.ExceptWith(set2);
            Console.Write("\nPrinting the set3:  ");
            Print(set3);

            //Intersection
            Console.WriteLine(new string('-', 60));
            Console.Write("\nset1:   ");
            Print(set1);

            Console.Write("\nset2:   ");
            Print(set2);

            Console.WriteLine("Intersection:");
            set3 = set1.IntersectWith(set2);
            Console.Write("\nset3:    ");
            Print(set3);

            //Symmetric Difference
            Console.WriteLine(new string('-', 60));
            Console.Write("\nset1:   ");
            Print(set1);

            Console.Write("\nset2:   ");
            Print(set2);

            Console.WriteLine("Symmetric Difference:");
            set3 = set1.SymmetricExceptWith(set2);
            Console.Write("\nset3:    ");
            Print(set3);

            //Subset?
            Console.WriteLine(new string('-', 60));
            Console.Write("\nset1:   ");
            Print(set1);

            Console.Write("\nset2:   ");
            Print(set2);

            Console.WriteLine("Is the set1 a subset of set2?:   {0}", set1.Subset(set2));
        }
    }
}
