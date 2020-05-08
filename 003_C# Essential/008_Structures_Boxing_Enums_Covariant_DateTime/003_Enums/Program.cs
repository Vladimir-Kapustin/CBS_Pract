using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Enums
{
    public enum Post
    {
        director = 100,
        manager = 130,
        worker = 160,
    }

    public class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if (hours>(int)worker)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the Postition of the employee:\nDirector\nManager\nWorker");
            string position = Console.ReadLine();

            Console.WriteLine("\ninsert fact hours of work of that employee");
            int hours = int.Parse(Console.ReadLine());

            WorkingClass workingClass = new WorkingClass(position, hours);
            workingClass.DeterminePremium();

            Console.ReadKey();
        }
    }
}
