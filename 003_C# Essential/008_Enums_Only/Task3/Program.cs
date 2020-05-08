using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public enum Post
    {
        Manager = 35,
        Grunt = 40,
        VicePresident = 25
    }

    class Program
    {
        static void Main(string[] args)
        {
            Accauntant accauntant = new Accauntant();

            //Console.WriteLine("Choose position (Manager/ Grunt/ VicePresident):");
            //string choice = Console.ReadLine();

            //Console.WriteLine("Type hours:");
            //int hours = Int32.Parse(Console.ReadLine());

            Post manager = Post.Manager;
            Post grunt = Post.Grunt;
            Post vicePresident = Post.VicePresident;
            
            Console.WriteLine("The {0} worked for 36 hours and asking for bonus:\nAccauntant says: {1}\n", manager, // эти три блока лучше вынести в другой класс.
                accauntant.AskForBonus(manager,36) ?  "OK" : "No, wokr harder!");

            Console.WriteLine("The {0} worked for 45 hours and asking for bonus:\nAccauntant says: {1}\n", grunt,
                accauntant.AskForBonus(grunt, 45) ? "You must be kidding..." : "No way! Go and work!!!");

            Console.WriteLine("The {0} worked for 10 hours and asking for bonus:\nAccauntant says: {1}\n", vicePresident,
                accauntant.AskForBonus(vicePresident, 10) ? "OK, Sir!" : "OK, Sir!");
        }
    }

    public class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if (hours > (int)worker)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
