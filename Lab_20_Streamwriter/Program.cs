using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_20_Streamwriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Overwrite mode
            using (var writer = new StreamWriter("data.txt"))
            {
                for (int i = 0; i < 10000; i++)
                {
                    writer.WriteLine($"DataLine: {i}");
                }
            }

            //Append Mode
            using (var writer = new StreamWriter("data.txt", true))
            {
                writer.WriteLine("Metro Boomin Want Some More");
            }

            //Set Encoding (UTF8 default)
            using (var writer = new StreamWriter("data.txt", true, Encoding.UTF8))
            {
                writer.WriteLine("Yeet");
            }
            
            //Huge files, you can speed up the process by altering the 'buffer size'
            //Buffer size - the unit of data transfer
            using (var writer  = new StreamWriter("data.txt", true, Encoding.UTF8, 10000))
            {
                writer.WriteLine("Yabba dabb yeet");
            }
        }
    }
}
