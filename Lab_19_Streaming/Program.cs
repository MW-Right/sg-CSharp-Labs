using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Lab_19_Streaming
{
    class Program
    {
        static string line = "";
        static List<string> data = new List<string>();
        static void Main(string[] args)
        {
            //Main thread
            Console.WriteLine("Program has started");

            ReadData();
            Console.WriteLine("Sleeping finished");
            ReadDataAsync();

            Console.WriteLine("Code has finished");
            Console.ReadLine();
        }
        static void ReadData()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Yeet");
        }
        static async void ReadDataAsync()
        {
            using (var reader = new StreamReader("definitionOfYeet.txt"))
            {
                while (true)
                {
                    line = await reader.ReadLineAsync();
                    if (line == null) break;
                    data.Add(line);
                }
            }
            data.ForEach(line => Console.WriteLine(line));
        }
    }
}
