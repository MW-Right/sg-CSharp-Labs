using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_104_array_list_queue_stack_dict_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Put 10 numbers in an array
            int[] numberArr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Move the items to a list and add 1 to each number
            List<int> numberList = new List<int>();
            foreach (var i in numberArr)
            {
                numberList.Add(numberArr[i] + 1);
            }
            //Move to a stack and add 1
            Stack<int> numberStack = new Stack<int>();
            for (var i = 0; i < numberList.Count; i++)
            {
                int stackValue = numberList[i];
                numberStack.Push(stackValue + 1);
            }
            
            //Move to a queue and add 1
            Queue<int> numberQueue = new Queue<int>();
            for (int i = 0; i < 10; i++)
            {
                int queueValue = numberStack.Pop();
                numberQueue.Enqueue(queueValue + 1);
            }
            //Move to a dictionary and add 1
            Dictionary<int, int> numberDictionary = new Dictionary<int, int>();
            for (int i = 0; i < 10; i++)
            {
                numberDictionary.Add(i, numberQueue.Dequeue() + 1);
            }
            //Return the total
            int total = 0;
            foreach (var i in numberDictionary)
            {
                total += i.Value;
                Console.WriteLine(i);
            }
            Console.WriteLine(total);
        }
    }
}
