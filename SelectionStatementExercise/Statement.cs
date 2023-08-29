using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatementExercise
{
    internal class Statement
    {
        public static void ex1() 
        {
            int favNum = 83;
            Console.WriteLine("guess my faveret number and it's between 1 to 100");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput == favNum)
            {
                Console.WriteLine("you guessed my favoret number congrats.");
            }
            else if (userInput > favNum)
            {
                Console.WriteLine("you number is larger then my favoret number, try next time");
            }
            else if (userInput < favNum)
            {
                Console.WriteLine("you number is smaller then my favoret number, try next time");
            }
        }

        public static void ex2()
        {
            Console.WriteLine("Which of these subjects was your favoret. math, science, history, programming or english");
            var favSub = Console.ReadLine();
            switch (favSub)
            {
                case "math":
                    Console.WriteLine("Ha nnnnnnnnuuuuuuuurrrrrrrrrdddddddd");
                    break;
                case "science":
                    Console.WriteLine("well, hopefully your more sane then michael reeves");
                    break;
                case "history":
                    Console.WriteLine("fair, those who don't know history are doomed to repeat it and all that");
                    break;
                case "english":
                    Console.WriteLine("why, just why");
                    break;
                case "programming":
                    Console.WriteLine("nice");
                    break;

            }
        }
    }
}
