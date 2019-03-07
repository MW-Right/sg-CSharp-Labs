using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Lab_119_hashSetToExcel
{
    /*
         * Yeet
         * Start a stopwatch
         * Pass 3 numbers to an array
         * Double the numbers and pass to a LINKED List
         * Double numbers and pass to a HASH set
         * Add 15, Treble numbers and pass to a dictionary
         * Stop the stopwatch
         * Return the test as a custom object containing:
         *          ElapsedTime
         *          FirstNumber
         *          SecondNumber
         *          ThirdNumber
         * Test passes if stopwatch time less than time passed in 4th variable (d) (set to 10 seconds for this test)
         * Not part of the test
         * Output all values to .csv test file and append to existing file.
         *      Datetime stamp
         *      Input 4 params
         *      Output 4 params
         * Finally launch excel to read this file using Process.Start
         */
    class Program
    {
        static void Main(string[] args)
        {
            HashSetToExcel test = new HashSetToExcel();
            test.HashSetToExcelTest(10, 20, 30, 10);
        }
    }
    public class HashSetToExcel
    {
        public Custom HashSetToExcelTest(int a, int b, int c, int d)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            int[] myArr = new int[] { a, b, c };
            LinkedList<int> myLinkedList = new LinkedList<int>();
            for (int i = 0; i < myArr.Length; i++)
            {
                myLinkedList.AddFirst(myArr[i] * 2);
                Console.WriteLine(myLinkedList.First.Value);
                Console.WriteLine("LinkedList checked");
            }
            HashSet<int> myHash = new HashSet<int>();
            foreach (var i in myLinkedList)
            {
                myHash.Add(i * 2);
            }
            Dictionary<int, int> myDic = new Dictionary<int, int>();
            for (int j = 0; j < 3; j++)
            {
                    myDic.Add(j, ((myHash.ElementAt(j) + 15) * 3));
            }
            foreach (var k in myDic)
            {
                Console.WriteLine(k);
            }
            s.Stop();
            Custom yeet = new Custom();
            yeet.FirstNum1 = myDic[0];
            yeet.SecondNum1 = myDic[1];
            yeet.ThirdNum1 = myDic[2];
            yeet.ElapsedTime1 = s.ElapsedMilliseconds;
            Console.WriteLine(yeet.ElapsedTime1);
            //Write to csv to store in excel
            string fileName = "data.csv";
            if (!(File.Exists(fileName)))
            {
                string header = "Number1,Number2,Number3,Time Taken\n";
                File.WriteAllText(fileName, header);
            }
            string values = $"{yeet.FirstNum1}, {yeet.SecondNum1}, {yeet.ThirdNum1}, {yeet.ElapsedTime1}";
            File.AppendAllText(fileName, values);
            Process.Start(fileName);
            return yeet;
        }
    }
    public class Custom
    {
        long ElapsedTime = 0;
        int FirstNum = 0;
        int SecondNum = 0;
        int ThirdNum = 0;

        public Custom()
        {

        }
        public Custom(int FirstNum, int SecondNum, int ThirdNum, long ElapsedTime)
        {
            this.FirstNum = FirstNum;
            this.SecondNum = SecondNum;
            this.ThirdNum = ThirdNum;
            this.ElapsedTime = ElapsedTime;
        }

        public long ElapsedTime1 { get => ElapsedTime; set => ElapsedTime = value; }
        public int FirstNum1 { get => FirstNum; set => FirstNum = value; }
        public int SecondNum1 { get => SecondNum; set => SecondNum = value; }
        public int ThirdNum1 { get => ThirdNum; set => ThirdNum = value; }
    }
}
