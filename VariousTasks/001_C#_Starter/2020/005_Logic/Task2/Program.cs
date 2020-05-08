using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			//--1 Способ - логическое ИЛИ на 1 (если результат - само число, то чётное, иначе - нечётное)
            Console.WriteLine("1st way");
																	
            while (true)
            {
                Console.WriteLine("Insert!");                           
                int number = Convert.ToInt32(Console.ReadLine());

                if ((number | 1) != number)								//	0000 1100    
                {														//		 0001    |
                    Console.WriteLine("OK");                            //	     1101
                }                                                            
                else                                                       
                {
                    Console.WriteLine("NOT OK");
                }

                Console.WriteLine("Continue? (Y/N)");
                string response = Console.ReadLine();

                switch (response.ToLower())
                {
                    case "y": 
                        continue;
                    case "n":
                        break;
                    default:
                        break;
                }
                break;
            }

            //--2 Способ - логическое И на 1 (если результат = 0, то чётное, если = 1, то нечётное)
            Console.WriteLine("2nd way");

            for (;;)                                      
            {                                             
                Console.WriteLine("Insert!");
                int number = Convert.ToInt32(Console.ReadLine());

                if ((number & 1) == 0)								    //	0000 1100    
                {														//		 0001    &
                    Console.WriteLine("Even");                          //	     0000
                }
                else
                {
                    Console.WriteLine("Odd");
                }

                Console.WriteLine("Continue? (Y/N)");
                string response = Console.ReadLine();

                switch (response.ToLower())
                {
                    case "y":
                        continue;
                    case "n":
                        break;
                    default:
                        break;
                }
                break;                                      
            }
		}
	}
}
