//#define MICHAELTEST
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_17_Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting app");
#if DEBUG
            Console.WriteLine("This is debug code");
#endif
#if MICHAELTEST
            Console.WriteLine("This is michael test");
#endif
            Console.WriteLine("Finishing app");
        }
    }
}
