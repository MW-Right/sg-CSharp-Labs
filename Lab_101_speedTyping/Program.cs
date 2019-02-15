using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp4
{
    class Program
    {
        //Declaring variables for the Program class
        static List<char> input = new List<char>();
        static DateTime finish = new DateTime();
        static string solution = "";
        static int time = 0;
        static string gameMode = "";
        static int score = 0;
        static char[] ordered = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        static void Main(string[] args)
        {
            //Get user input
            Console.WriteLine("How many seconds would you like to play for?");
            time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Which game would you like to play?");
            Console.WriteLine("Random (r), Ordered (o)");
            gameMode = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            if (gameMode == "r")
            {
                TakeKeyInput();
                Score();
            }
            else if (gameMode == "o")
            {
                TakeKeyInput();
                char[] solutionArr = solution.ToCharArray();
                for (int i = 0; i < solutionArr.Length; i++)
                {
                    if (solutionArr[i % 26] == ordered[i % 26])         //Use the % operator to avoid out of bounds exception
                    {
                        score++;
                    }
                    else if (solution[i % 26] != ordered[i % 26])
                    {
                        break;
                    }
                }
                //Check and print score
                Score();
            }
        }
        public static void TakeKeyInput()
        {
            finish = DateTime.Now.AddSeconds(time);
            while (true)
            {
                input.Add(Console.ReadKey().KeyChar);
                Console.WriteLine("");
                if (DateTime.Compare(finish, DateTime.Now) <= 0)
                {
                    break;
                }
            }
            foreach (var item in input)
            {
                solution += item;
            }
        }
        public static void Score()              //Check and print score
        {
            Console.WriteLine($"You typed {score} characters in {time} seconds");
            Console.WriteLine(solution);
            Console.ReadLine();
        }
    }
} 
