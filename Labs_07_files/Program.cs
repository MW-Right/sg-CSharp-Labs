using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //file read as string
                string data01 = File.ReadAllText("file.txt");           //File relative to .exe file
                Console.WriteLine(data01);
            }
            catch(FileNotFoundException ex)                             //Handling exception
            {
                Console.WriteLine("No yeet for you");
            }
            finally                                                     //Always runs regardless
            {
                Console.WriteLine("Create the file you moron");
            }
        }
    }
}
