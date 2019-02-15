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
        static void Main(string[] args)
        {
            string gameMode = "";
            string solution = "";
            int score = 0;
            char[] ordered = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            List<char> input = new List<char>();
            Console.WriteLine("How many seconds would you like to play for?");
            int time = Convert.ToInt32(Console.ReadLine());
            DateTime finish = new DateTime();
            finish = DateTime.Now.AddSeconds(time);
            Console.WriteLine("Which game would you like to play?");
            Console.WriteLine("Random (r), Ordered (o)");
            gameMode = Convert.ToString(Console.ReadLine());
            Console.WriteLine(gameMode);
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            if (gameMode == "r")
            {
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
                Console.WriteLine($"You typed {input.Count} characters in {time} seconds");
                Console.WriteLine(solution);
                Console.ReadLine();
            }
            else if (gameMode == "o")
            {
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
                char[] solutionArr = solution.ToCharArray();
                for (int i = 0; i < solutionArr.Length; i++)
                {
                    if (solutionArr[i % 26] == ordered[i % 26])
                    {
                        score++;
                    }
                    else if (solution[i % 26] != ordered[i])
                    {
                        break;
                    }
                }
                Console.WriteLine($"You typed {score} characters in {time} seconds");
                Console.WriteLine(solution);
                Console.ReadLine();
            }
        }
    }
} 
