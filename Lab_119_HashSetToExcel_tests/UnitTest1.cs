using NUnit.Framework;
using Lab_119_hashSetToExcel;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

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
         *      Input 4 params
         *      Output 4 params
         * Finally launch excel to read this file using Process.Start
         */ 
        [TestCase(10,20,30,10)]
        public void HashSetToExcel1(int a, int b, int c, int d)
        {
            //Arrange
            var instance01 = new HashSetToExcel().HashSetToExcelTest(a, b, c, d);
            //Assert
            Assert.Less(instance01.ElapsedTime1, d * 1000);
        }
    }
}