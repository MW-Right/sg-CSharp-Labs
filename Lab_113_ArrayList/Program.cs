using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_113_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayLists iClass = new ArrayLists();
            iClass.ArrayListMethod(1,2,3,4);
        }
    }
    public class ArrayLists
    {
        public int ArrayListMethod(int a, int b, int c, int d)
        {
            //Accept 4 integers
            //Put into array
            //Extract and double and put into queue
            //Extract and double and put into stack
            //Extract and Square and put into dictionary
            //Extract and Put to arrayList
            //Extract and return sum
            int sum = 0;
            int[] myArray = { a, b, c, d };
            Queue<int> myQueue = new Queue<int>();
            Stack<int> myStack = new Stack<int>();           
            Dictionary<int, int> myDic = new Dictionary<int, int>();
            ArrayList myArrayList = new ArrayList();
            myQueue.Clear();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(myArray[i]);
                myQueue.Enqueue(myArray[i] * 2);
            }
            myStack.Clear();
            for (int i = 0; i < 4; i++)
            {
                int x2 = 0;
                x2 = myQueue.Dequeue();
                Console.WriteLine(x2);
                myStack.Push(x2 * 2);
            }
            myDic.Clear();
            for (int i = 0; i < 4; i++)
            {
                int square = myStack.Pop();
                square *= square;
                Console.WriteLine(square);
                myDic.Add(i, square); 
            }
            myArrayList.Clear();
            foreach (var key in myDic)
            {
                Console.WriteLine(key.Value);
                myArrayList.Add(key.Value);
            }
            foreach (int i in myArrayList)
            {
                sum += i;
            }
            return sum;
        }
    }
}
