using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var object1 = new Object();
            var object2 = new
            {
                name = "hi",
                age = 22,
                dob = "06/03/1996"
            };

            byte b = 128;
            byte bMin = 0;
            byte bMax = 255;

            byte[] buffer = new byte[4000]; //leads to the concept of buffering, data is sent in arrays of bytes
        }
    }
}
