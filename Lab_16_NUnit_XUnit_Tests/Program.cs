using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_16_NUnit_XUnit_Tests
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class TestMeNow
    {
        public double TestThisMethodWorks(int x, int y, int z)
        {
            return Math.Pow((x * y), z);
        }
    }
}
