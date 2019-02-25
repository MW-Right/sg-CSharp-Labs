using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_116_TryCatchThrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 0;

            try
            {
                try
                {
                    int z = x / y;
                    throw new Exception("Phil's Special Exception");
                }
                catch(DivideByZeroException e)
                {
                    Console.WriteLine("Yeet");
                    Console.WriteLine(e.Message);
                }
                catch
                {
                    Console.WriteLine("You made a mistake");
                    throw;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("\n\nDisplay exception Message");
                Console.WriteLine(e.Message);
                Console.WriteLine("\nDisplay exception data");
                Console.WriteLine(e.Data);
            }
        }
    }
}
