using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_112_collectoins
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
        * recieve 3 numbers
        * put these threenumbers in an array
        * output numbers , double each one and put in a stack
        * repeat ie output numbers, double and store in queue
        * output numbers, square them and put in a list<int>
        * add up numbers in the list<int> and return total
        */
            CollectionsLab(1, 2, 3);

        }
        public static void CollectionsLab(int num1, int num2, int num3)
        {
            int[] myArray = new int[] { num1, num2, num3 };
            Stack<int> myStack = new Stack<int>();
            Queue<int> myQueue = new Queue<int>();
            List<int> myList = new List<int>();
            int sum = 0;
            Console.WriteLine("\nNumbers stored in the array");
            foreach (var i in myArray)
            {
                Console.WriteLine(i);
                myStack.Push(i * 2);
            }
            Console.WriteLine("\nNumbers stored in the stack");
            foreach (var i in myStack)
            {
                Console.WriteLine(i);
                myQueue.Enqueue(i * 2);
            }
            Console.WriteLine("\nNumbers stored in the Queue");
            foreach (var i in myQueue)
            {
                Console.WriteLine(i);
                myList.Add(i * i);
            }
            foreach (var i in myList)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of the list is {sum}");
        }
    }
}
