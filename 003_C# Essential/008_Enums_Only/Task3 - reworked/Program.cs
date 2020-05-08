using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3___reworked      // Upgraded Version of Task3.
{
    public enum Post
    {
        Manager = 35,
        Grunt = 40,
        VicePresident = 25
    }

    class Program
    {
        static void Main(string[] args)     // Шикарный краткий метод Main().
        {
            Console.WriteLine("Choose position (Manager/ Grunt/ VicePresident):");
            string position = Console.ReadLine();

            Console.WriteLine("Type amount of hours:");
            int hours = Int32.Parse(Console.ReadLine());

            Process process = new Process(position, hours);
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

    public class Process
    {
        Accauntant accauntant = new Accauntant();

        Post worker;
        int hours;

        public Process(string position, int hours)
        {
            if (!Enum.IsDefined(typeof(Post), position))
            {
                Console.WriteLine("No such position!");
            }
            else
            {
                this.worker = (Post)Enum.Parse(typeof(Post), position);
                this.hours = hours;
                DeterminePremium();
            }
        }

        public void DeterminePremium()
        {
            Console.WriteLine("The {0} worked for {1} hours and asking for bonus", worker, hours);  // вынес за пределы свича
            bool decision = accauntant.AskForBonus(worker, hours);  // вынес за пределы свича - краткость кода.

            switch (worker)
            {
                case Post.Manager:
                    Console.WriteLine("Accauntant says: {0}", decision ? "OK" : "No, work harder!");
                    break;
                case Post.Grunt:
                    Console.WriteLine("Accauntant says: {0}", decision ? "You must be kidding..." : "No way! Go and work!!!");
                    break;
                case Post.VicePresident:
                    Console.WriteLine("Accauntant says: {0}", decision ? "OK, Sir!" : "OK, Sir!"); // Или просто: "Accauntant says: "OK, Sir!"
                    break;
            }
        }
    }
}