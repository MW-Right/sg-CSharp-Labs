using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_12_PushDataToMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var memoryStream = new MemoryStream())
            {
                byte[] buffer = new byte[100];
                //memoryStream.Write(buffer,0,100);
                memoryStream.Flush(); //Send data
                memoryStream.Position = 0; //Resets pointer to start

                var reader = new StreamReader(memoryStream);
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}
