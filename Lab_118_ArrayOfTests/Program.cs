using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Lab_118_ArrayOfTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read Write number of lines
            //FileOperationSynchronous.FileReadWrite(2000);
            //Console.WriteLine(FileOperationSynchronous.FileReadWrite(2000)); 
            //Create 1000 files
            var test = new FileOperationSynchronous();
            test.FileOperation02(100);

        }

    }
    public class FileOperationSynchronous
    {
        public long FileReadWrite(int noOfFiles)
        {
            string data = "Saving some data - ";
            //Create a stopwatch
            var s = new Stopwatch();
            s.Start();
            //Write 1000 times to a file synchronously
            for (int i = 0; i < noOfFiles; i++)
            {
                File.WriteAllText("data.txt", data + i);
            }
            //Read 1000 times that same file
            for (int i = 0; i < noOfFiles; i++)
            {
                File.ReadAllText("data.txt"); }
            //End stop watch
            Console.WriteLine($"The process took {s.ElapsedMilliseconds}");
            s.Stop();
            return s.ElapsedMilliseconds;
        }

        public long TaskArrayFileRW(int numOfFiles)
        {
            var s = new Stopwatch();
            //One task      (input) => {method body}
            Task singleTask = Task.Run(() => { });
            Task.WaitAll(singleTask);
            s.Stop();
            return s.ElapsedMilliseconds;

            //complete and test RW 1000 files then 10000 as task
            //Bonus: create new project, add northwind, update contact information
        }
        //public long FileOperation(int numOfFiles)
        //{
        //    var s = new Stopwatch();
        //    s.Start();
        //    string path = "";
        //    for (var i = 1; i < numOfFiles; i++)
        //    {
        //        string FileName = "MyTest" + i + ".txt";
        //        path = FileName;
        //        // Create a file to write to. 
        //        using (StreamWriter sw = File.CreateText(path))
        //        {
        //            sw.WriteLine("Hello");
        //        }
        //    }
        //    s.Stop();
        //    return s.ElapsedMilliseconds;
        //}
        public long FileOperation02(int numOfFiles)
        {
            Task[] tasks = new Task[numOfFiles];
            Stopwatch s = new Stopwatch();
            for (int i = 0; i < numOfFiles; i++)
            {
                int j = i;
                tasks[i] = Task.Run(() => WriteFile(j));
            }
            Task.WaitAll(tasks);
            return s.ElapsedMilliseconds;
        }
        public void WriteFile(int i)
        {
            string FileName = "MyTest" + i.ToString("D3") + ".txt";
            string path = FileName;
            // Create a file to write to. 
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Hello");
            }
        }
    }
}
