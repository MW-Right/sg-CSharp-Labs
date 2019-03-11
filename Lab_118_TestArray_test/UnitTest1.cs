using NUnit.Framework;
using Lab_118_ArrayOfTests;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            //Setup code, e.g. Generating a fresh database, any initialisation for all tests
        }

        [TestCase(2000, 7000)]
        [TestCase(10000, 35000)]
        public void TestFileSynchronousRW(int noOfFiles, int maxTime)
        {
            //Arrange
            var instance = new FileOperationSynchronous();
            //Act
            long timeTaken = instance.FileReadWrite(noOfFiles);
            System.Console.WriteLine($"Time taken: {timeTaken} milliseconds");
            //Assert
            Assert.Less(timeTaken, maxTime);
        }
    }
}