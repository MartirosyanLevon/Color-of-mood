using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_of_mood
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the word of song - Color of mood *****");
            Console.WriteLine("You have 5 attemt");
            string exit = "exit";
            Console.WriteLine("If you do not want to continue playing write {0}", exit);
            int attemt = 0;
            int maxattemt = 5;
            string color = "black";
            while (attemt < maxattemt)
            {
                attemt++;
                Console.WriteLine("It is your {0} attemt", attemt);
                string value = Console.ReadLine();

                if (value == exit)
                {
                    break;
                }

                if (value != color)
                {
                    continue;
                }

                if (value == color)
                {
                    Console.WriteLine("Congratulations!!!");
                    Console.WriteLine("You are Guess {0} attemt", attemt);
                    Console.Write("BLACK STAR MAFIA _ ");
                    Console.WriteLine("Color of mood Black!");
                    break;
                }


            }
            Console.WriteLine("THE END");
            Console.ReadKey();
        }
    }
}
